Imports System.IO
Imports System.Text
Public Class AccountBook
    Dim SaveFilePath As String
    Dim DataFileDir As String = "\Data"
    Dim ConfFileDir As String = "\Conf"

#Region "ロード"
    Private Sub AccountBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim CreatedAt As DateTime = System.DateTime.Now
            Dim FileName As String = CreateFilename(CreatedAt) + ".habr"

            MoneyDataSet.MoneyDataTable.AddMoneyDataTableRow(
                FrmEntry.MonCalendar.SelectionRange.Start,
                AddCategory(FrmEntry.CmbCategory.Text),
                FrmEntry.TxtItem.Text,
                Integer.Parse(FrmEntry.MTxtMoney.Text),
                FrmEntry.TxtRemarks.Text,
                CreatedAt,
                FileName)

            ' ファイルに書き込み
            SaveData(FileName,
                FrmEntry.MonCalendar.SelectionRange.Start.ToString + "," _
                + FrmEntry.CmbCategory.Text + "," _
                + FrmEntry.TxtItem.Text + "," _
                + FrmEntry.MTxtMoney.Text + "," _
                + FrmEntry.TxtRemarks.Text + "," _
                + CreatedAt.ToString + "," _
                + FileName)
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
            Dim CreatedAt As DateTime = AccountDgv.Rows(NowRow).Cells(5).Value
            Dim FileName As String = AccountDgv.Rows(NowRow).Cells(6).Value

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
                + FrmEntry.TxtRemarks.Text + "," _
                + CreatedAt.ToString + "," _
                + FileName)
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
        Dim FileName As String = AccountDgv.Rows(NowRow).Cells(6).Value

        ' 表から削除
        AccountDgv.Rows.RemoveAt(NowRow)
        ' ファイルを削除
        System.IO.File.Delete(SaveFilePath + "\Data\" + FileName)
    End Sub
#End Region

#Region "保存"

    Sub SaveData(FileName As String, StrData As String)
        ' ファイルに書き込み
        Dim sw As StreamWriter = New StreamWriter(SaveFilePath + DataFileDir + "\" + FileName, False, Encoding.UTF8)
        sw.WriteLine(StrData)
        sw.Close()

    End Sub

    ' 集計ツールボタン
    Private Sub ExportTsmi_Click(sender As Object, e As EventArgs) Handles ExportTsmi.Click
        ExportData()
        Process.Start("SpreadSheet.xlsm")
    End Sub

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
        LoadBook()
    End Sub

    ' 再読込メニュー
    Private Sub ReloadTsmi_Click(sender As Object, e As EventArgs) Handles ReloadTsmi.Click

    End Sub

    Sub LoadSetting()
        Dim path As String = "SavePath.ini"
        Dim FileExists As Boolean = File.Exists(path)

        If FileExists Then
            Dim sr As StreamReader = New StreamReader(
                path,
                Encoding.Default)
            SaveFilePath = sr.ReadLine()
            sr.Close()
        Else
            SaveFilePath = System.IO.Directory.GetCurrentDirectory()
        End If
    End Sub

    Sub LoadCategory()
        Dim path As String = "CategoryData.csv"
        Dim DelimStr As String = ","
        Dim delimiter As Char() = DelimStr.ToArray()
        Dim StrData As String()
        Dim StrLine As String
        Dim FileExists As Boolean = File.Exists(path)

        CategoryDataSet1.Clear()

        If FileExists Then
            Dim sr As StreamReader = New StreamReader(
                path,
                Encoding.Default)
            Do While sr.Peek() >= 0
                StrLine = sr.ReadLine()
                StrData = StrLine.Split(delimiter)
                CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow(
                    StrData(0),
                    Boolean.Parse(StrData(1)))
            Loop
            sr.Close()
        Else
            CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", True)
            CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", False)
            CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", False)
            CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", False)
        End If
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
                    DateTime.Parse(StrData(5)),
                    Path.GetFileName(file))
            sr.Close()
        Next
    End Sub
#End Region

#Region "設定"
    Private Sub SettingTsmi_Click(sender As Object, e As EventArgs) Handles SettingTsmi.Click
        Dim FrmSetting As SettingFm = New SettingFm(SaveFilePath, CategoryDataSet1)
        Dim DrRet As DialogResult = FrmSetting.ShowDialog()

        If DrRet = DialogResult.OK Then
            ' 分類の再構築
            CategoryDataSet1.Clear()
            CategoryDataSet1.Merge(FrmSetting.CategoryDataSet)
            SaveCategory()

            ' ファイルパスの保存
            SaveFilePath = FrmSetting.TxtSavePath.Text
            SavePath()
        End If
    End Sub
    Sub SaveCategory()
        Dim path As String = "CategoryData.csv"    '  出力ファイル名
        Dim StrData As String = ""              '  行分のデータ
        Dim sw As StreamWriter = New StreamWriter(
            path,
            False,
            Encoding.Default)
        For Each DrCategory As CategoryDataSet.CategoryDataTableRow In CategoryDataSet1.CategoryDataTable
            StrData = DrCategory.分類 + "," + DrCategory.収入.ToString
            sw.WriteLine(StrData)
        Next
        sw.Close()
    End Sub

    Sub SavePath()
        Dim path As String = "SavePath.ini"    '  出力ファイル名
        Dim sw As StreamWriter = New StreamWriter(
            path,
            False,
            Encoding.UTF8)
        sw.WriteLine(SaveFilePath)
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
                CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow _
                    (name, FrmAddCategory.RbnIncome.Checked)
                SaveCategory()
            End If
        End If
        Return name
    End Function

#End Region

#Region "SHA1"
    Private Function CreateFilename(CreatedAt As DateTime)
        ' 作成日時からSHA1ハッシュ値を計算してファイル名にする

        ' 作成日時をbyte型配列に格納
        Dim data As Byte() = System.Text.Encoding.UTF8.GetBytes(CreatedAt.ToString)
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