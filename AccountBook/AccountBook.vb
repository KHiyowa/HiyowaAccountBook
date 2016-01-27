Imports System.IO
Imports System.Text
Public Class AccountBook
    Dim SaveFilePath As String
    Dim DataFileDir As String = "\Data"
    Dim ConfFileName As String = "Settings.ini"
    Public CategoryFileDir As String = "\Category"

#Region "ロード"
    Private Sub AccountBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 乱数初期化
        Randomize()
        ' データのロード
        LoadData()
    End Sub
#End Region

#Region "追加"
    ' 追加ボタン
    Private Sub AddTsmi_Click(sender As Object, e As EventArgs) Handles AddTsmi.Click
        ShowEntryForm()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ShowEntryForm()
    End Sub

    ' 追加
    Private Sub ShowEntryForm()
        Dim FrmEntry As EntryFm = New EntryFm(CategoryDataSet1)
        Dim DrRet As DialogResult = FrmEntry.ShowDialog()

        If DrRet = DialogResult.OK Then
            ' リストに反映
            Dim FileName As String = CreateFilename() + ".habr"

            MoneyDataSet.MoneyDataTable.AddMoneyDataTableRow(
                FrmEntry.MonCalendar.SelectionRange.Start,
                AddCategory(FrmEntry.CmbCategory.Text),
                FrmEntry.TxtItem.Text,
                Integer.Parse(FrmEntry.MTxtMoney.Text),
                FrmEntry.TxtRemarks.Text,
                FileName)

            ' ファイルに書き込み
            SaveData(FileName,
                FrmEntry.MonCalendar.SelectionRange.Start.ToString + "," _
                + FrmEntry.CmbCategory.Text + "," _
                + FrmEntry.TxtItem.Text + "," _
                + FrmEntry.MTxtMoney.Text + "," _
                + FrmEntry.TxtRemarks.Text)
        End If


    End Sub
#End Region

#Region "変更"
    Private Sub ChangeBtn_Click(sender As Object, e As EventArgs) Handles ChangeBtn.Click
        UpdateData()
    End Sub

    Private Sub ChangeTsmi_Click(sender As Object, e As EventArgs) Handles ChangeTsmi.Click
        UpdateData()
    End Sub

    Private Sub UpdateData()
        Dim NowRow As Integer = AccountDgv.CurrentRow.Index
        Dim OldDate As DateTime = DateTime.Parse(AccountDgv.Rows(NowRow).Cells(0).Value.ToString())
        Dim OldCategory As String = AccountDgv.Rows(NowRow).Cells(1).Value.ToString()
        Dim OldItem As String = AccountDgv.Rows(NowRow).Cells(2).Value.ToString()
        Dim OldMoney As Integer = Integer.Parse(AccountDgv.Rows(NowRow).Cells(3).Value.ToString())
        Dim OldRemarks As String = AccountDgv.Rows(NowRow).Cells(4).Value.ToString()

        Dim FrmEntry As EntryFm = New EntryFm(CategoryDataSet1,
                                            OldDate,
                                            OldCategory,
                                            OldItem,
                                            OldMoney,
                                            OldRemarks)

        Dim DrRet As DialogResult = FrmEntry.ShowDialog()

        If DrRet = DialogResult.OK Then
            Dim FileName As String = AccountDgv.Rows(NowRow).Cells(5).Value

            ' 表に反映
            AccountDgv.Rows(NowRow).Cells(0).Value =
                FrmEntry.MonCalendar.SelectionRange.Start
            AccountDgv.Rows(NowRow).Cells(1).Value = AddCategory(FrmEntry.CmbCategory.Text)
            AccountDgv.Rows(NowRow).Cells(2).Value = FrmEntry.TxtItem.Text
            AccountDgv.Rows(NowRow).Cells(3).Value = Integer.Parse(FrmEntry.MTxtMoney.Text)
            AccountDgv.Rows(NowRow).Cells(4).Value = FrmEntry.TxtRemarks.Text

            ' ファイルに書き込み
            SaveData(FileName,
                FrmEntry.MonCalendar.SelectionRange.Start.ToString + "," _
                + FrmEntry.CmbCategory.Text + "," _
                + FrmEntry.TxtItem.Text + "," _
                + FrmEntry.MTxtMoney.Text + "," _
                + FrmEntry.TxtRemarks.Text)
        End If
    End Sub
#End Region

#Region "削除"
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        DeleteData()
    End Sub

    Private Sub DeleteTsmi_Click(sender As Object, e As EventArgs) Handles DeleteTsmi.Click
        DeleteData()
    End Sub

    Private Sub DeleteData()
        ' 現在の行番号を取得
        Dim NowRow As Integer = AccountDgv.CurrentRow.Index
        ' 当該の行のファイル名を取得
        Dim FileName As String = AccountDgv.Rows(NowRow).Cells(5).Value

        ' 表から削除
        AccountDgv.Rows.RemoveAt(NowRow)
        ' ファイルを削除
        DeleteFile(DataFileDir, FileName)
    End Sub
#End Region

#Region "保存"
    ' データ保存
    Private Sub SaveData(FileName As String, StrData As String)
        WriteFile(DataFileDir, FileName, StrData)
    End Sub

    ' カテゴリ保存
    Public Sub SaveCategory(FileName As String, StrData As String)
        WriteFile(CategoryFileDir, FileName, StrData)
    End Sub

    ' ファイル書き込み
    Private Sub WriteFile(Dir As String, FileName As String, StrData As String)
        ' ファイルに書き込み
        Dim sw As StreamWriter = New StreamWriter(SaveFilePath + Dir + "\" + FileName, False, Encoding.UTF8)
        sw.WriteLine(StrData)
        sw.Close()
    End Sub

    ' ファイル削除
    Public Sub DeleteFile(Dir As String, FileName As String)
        File.Delete(SaveFilePath + Dir + "\" + FileName)
    End Sub

    ' 集計ツールボタン
    Private Sub ExportTsmi_Click(sender As Object, e As EventArgs) Handles ExportTsmi.Click
        ExportData()
        Process.Start("SpreadSheet.xlsm")
    End Sub

    ' CSV出力
    Sub ExportData()
        Dim path As String = "MoneyData.csv"    '  出力ファイル名
        Dim StrData As String = ""              '  行分のデータ
        Dim sw As StreamWriter = New StreamWriter(
            path,
            False,
            Encoding.Default)
        For Each DrMoney As MoneyDataSet.MoneyDataTableRow In MoneyDataSet.MoneyDataTable
            StrData = DrMoney.日付.ToShortDateString() + "," _
            + DrMoney.分類 + "," _
            + DrMoney.品名 + "," _
            + DrMoney.金額.ToString() + "," _
            + DrMoney.備考
            sw.WriteLine(StrData)
        Next
        sw.Close()
    End Sub
#End Region

#Region "読出"
    Sub LoadData()
        LoadSetting()
        LoadCategory()
        LoadBook()
    End Sub

    ' 再読込ボタン
    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Reload()
    End Sub

    ' 再読込メニュー
    Private Sub ReloadTsmi_Click(sender As Object, e As EventArgs) Handles ReloadTsmi.Click
        Reload()
    End Sub

    ' 自動で再読込
    Private Sub ReloadTimer_Tick(sender As Object, e As EventArgs) Handles ReloadTimer.Tick
        Reload()
    End Sub

    ' 再読込処理
    Private Sub Reload()
        LoadCategory()
        LoadBook()
    End Sub

    ' 設定の読み出し
    Sub LoadSetting()
        Dim path As String = ConfFileName
        Dim FileExists As Boolean = File.Exists(path)

        If FileExists Then
            Dim sr As StreamReader = New StreamReader(
                path,
                Encoding.Default)
            SaveFilePath = sr.ReadLine()
            ReloadTimer.Enabled = Boolean.Parse(sr.ReadLine())
            sr.Close()
        Else
            SaveFilePath = SelectDataFolder(System.IO.Directory.GetCurrentDirectory())
            SaveConfig()
        End If
    End Sub

    ' データフォルダの選択
    Public Function SelectDataFolder(path As String)
        FbdPickDataFolder.Description = "データフォルダを選択してください。" & Chr(13) &
            "選択しない場合は、プログラムフォルダの直下にデータフォルダが作成されます。"
        FbdPickDataFolder.SelectedPath = path

        'ダイアログを表示する
        If FbdPickDataFolder.ShowDialog(Me) = DialogResult.OK Then
            '選択されたフォルダのパスを返却
            Return FbdPickDataFolder.SelectedPath
        End If
        Return path
    End Function

    Sub LoadCategory()
        Dim DelimStr As String = ","
        Dim delimiter As Char() = DelimStr.ToArray()
        Dim StrData As String()
        Dim StrLine As String
        Dim FileNames As String()

        CategoryDataSet1.Clear()

        ' カテゴリフォルダの中身をすべて読み込み
        Try
            FileNames = Directory.GetFiles(SaveFilePath + CategoryFileDir, "*.habc")
        Catch ex As Exception
            Directory.CreateDirectory(SaveFilePath + CategoryFileDir)
            SaveCategory(CreateFilename() + ".habc", "給料" + "," + True.ToString)
            SaveCategory(CreateFilename() + ".habc", "食費" + "," + False.ToString)
            SaveCategory(CreateFilename() + ".habc", "雑費" + "," + False.ToString)
            SaveCategory(CreateFilename() + ".habc", "住居" + "," + False.ToString)
            FileNames = Directory.GetFiles(SaveFilePath + CategoryFileDir, "*.habc")
        End Try

        For Each file In FileNames
            Dim sr As StreamReader = New StreamReader(file, Encoding.Default)

            StrLine = sr.ReadLine()
            StrData = StrLine.Split(delimiter)
            CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow(
                    StrData(0),
                    Boolean.Parse(StrData(1)),
                    Path.GetFileName(file))
            sr.Close()
        Next
    End Sub

    Private Sub LoadBook()
        Dim DelimStr As String = ","
        Dim delimiter As Char() = DelimStr.ToArray()
        Dim StrData As String()
        Dim StrLine As String
        Dim FileNames As String()

        ' データフォルダの中身をすべて読み込み
        Try
            FileNames = Directory.GetFiles(SaveFilePath + DataFileDir, "*.habr")
        Catch ex As Exception
            Directory.CreateDirectory(SaveFilePath + DataFileDir)
            Return
        End Try

        MoneyDataSet.Clear()
        For Each file In FileNames
            Dim sr As StreamReader = New StreamReader(file, Encoding.Default)

            StrLine = sr.ReadLine()
            StrData = StrLine.Split(delimiter)
            MoneyDataSet.MoneyDataTable.AddMoneyDataTableRow(
                    DateTime.Parse(StrData(0)),
                    StrData(1),
                    StrData(2),
                    Integer.Parse(StrData(3)),
                    StrData(4),
                    Path.GetFileName(file))
            sr.Close()
        Next
    End Sub
#End Region

#Region "設定"
    Private Sub SettingTsmi_Click(sender As Object, e As EventArgs) Handles SettingTsmi.Click
        Dim FrmSetting As SettingFm = New SettingFm(SaveFilePath, ReloadTimer.Enabled, CategoryDataSet1)
        Dim DrRet As DialogResult = FrmSetting.ShowDialog()

        If DrRet = DialogResult.OK Then
            ' 分類の再構築
            CategoryDataSet1.Clear()
            CategoryDataSet1.Merge(FrmSetting.CategoryDataSet)

            ' ファイルパスとDropbox使用設定の保存
            SaveFilePath = FrmSetting.TxtSavePath.Text
            ReloadTimer.Enabled = FrmSetting.CkbDropbox.Checked
            SaveConfig()
        End If
    End Sub

    Sub SaveConfig()
        Dim path As String = ConfFileName    '  出力ファイル名
        Dim sw As StreamWriter = New StreamWriter(
            path,
            False,
            Encoding.UTF8)
        sw.WriteLine(SaveFilePath)
        sw.WriteLine(ReloadTimer.Enabled.ToString)
        sw.Close()
    End Sub

    Private Function AddCategory(name As String)
        ' 入力されたカテゴリが存在するかどうか確認
        Dim found As Boolean = False
        For Each DrCategory As CategoryDataSet.CategoryDataTableRow In CategoryDataSet1.CategoryDataTable
            If DrCategory.分類 = name Then
                found = True
                Exit For
            End If
        Next

        ' 存在しなければ、作成するかどうかのダイアログを出す
        If found <> True Then
            Dim FrmAddCategory As AddCategoryFm =
                New AddCategoryFm("新しい分類が入力されました。" & Chr(13) &
                        "この分類を登録しますか?" & Chr(13) &
                        "登録しておくと、次回からリストに表示されるようになります。",
                    name)
            Dim DrRet As DialogResult = FrmAddCategory.ShowDialog()

            If DrRet = DialogResult.OK Then
                name = FrmAddCategory.TxtCategoryName.Text
                Dim FileName As String = CreateFilename() + ".habc"
                CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow _
                    (name,
                     FrmAddCategory.RbnIncome.Checked,
                     FileName)
                SaveCategory(FileName,
                             name + "," _
                             + FrmAddCategory.RbnIncome.Checked.ToString)
            End If
        End If
        Return name
    End Function

#End Region

#Region "ファイル名生成"


    Public Function CreateFilename()
        ' 乱数からからSHA1ハッシュ値を計算してファイル名にする


        ' 作成日時をbyte型配列に格納
        Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(Rnd().ToString)
        ' SHA256オブジェクトを作成
        Dim sha As System.Security.Cryptography.SHA1 = System.Security.Cryptography.SHA1.Create()
        ' ハッシュ値を計算
        Dim bs As Byte() = sha.ComputeHash(data)
        ' 解放
        sha.Clear()

        ' byte型配列を16進数の文字列に変換
        Dim result As String = BitConverter.ToString(bs).ToLower().Replace("-", "")

        ' 結果を返却
        Return result
    End Function
#End Region

#Region "終了"
    ' 終了ボタン
    Private Sub QuitTsmi_Click(sender As Object, e As EventArgs) Handles QuitTsmi.Click
        CloseApp()
    End Sub

    ' 終了メニュー
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        CloseApp()
    End Sub

    ' 終了
    Private Sub CloseApp()
        Me.Close()
    End Sub
#End Region

End Class