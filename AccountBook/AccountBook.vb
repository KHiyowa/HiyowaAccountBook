Imports System.IO
Imports System.Text
Public Class AccountBook
    Dim Saved As Boolean = True
    Dim SaveFilePath As Path

#Region "ロード"
    Private Sub AccountBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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
            MoneyDataSet.MoneyDataTable.AddMoneyDataTableRow(
            FrmEntry.MonCalendar.SelectionRange.Start,
            AddCategory(FrmEntry.CmbCategory.Text),
            FrmEntry.TxtItem.Text,
            Integer.Parse(FrmEntry.MTxtMoney.Text),
            FrmEntry.TxtRemarks.Text)
        End If
        ChangeSavedState(False)
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
            AccountDgv.Rows(NowRow).Cells(0).Value =
                FrmEntry.MonCalendar.SelectionRange.Start
            AccountDgv.Rows(NowRow).Cells(1).Value = AddCategory(FrmEntry.CmbCategory.Text)
            AccountDgv.Rows(NowRow).Cells(2).Value = FrmEntry.TxtItem.Text
            AccountDgv.Rows(NowRow).Cells(3).Value = Integer.Parse(FrmEntry.MTxtMoney.Text)
            AccountDgv.Rows(NowRow).Cells(4).Value = FrmEntry.TxtRemarks.Text
        End If
        ChangeSavedState(False)
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
        Dim NowRow As Integer = AccountDgv.CurrentRow.Index
        AccountDgv.Rows.RemoveAt(NowRow)
        ChangeSavedState(False)
    End Sub
#End Region

#Region "保存"
    ' 保存状態によってキャプションを変更
    Private Sub ChangeSavedState(state As Boolean)
        If state Then
            Me.Text = "ひよわ家計簿"
            Saved = True
        Else
            Me.Text = "ひよわ家計簿 *"
            Saved = False
        End If
    End Sub

    ' 保存ボタンを押したとき
    Private Sub SaveTsmi_Click(sender As Object, e As EventArgs) Handles SaveTsmi.Click
        SaveData()
    End Sub

    Sub SaveData()
        If Saved Then Return ' すでに保存されていれば何もしない
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
        ChangeSavedState(True)
    End Sub
#End Region

#Region "読出"
    Sub LoadData()
        Dim path As String = "MoneyData.csv"
        Dim DelimStr As String = ","
        Dim delimiter As Char() = DelimStr.ToArray()
        Dim StrData As String()
        Dim StrLine As String
        Dim FileExists As Boolean = File.Exists(path)

        If FileExists Then
            Dim sr As StreamReader = New StreamReader(
                path,
                Encoding.Default)
            Do While sr.Peek() >= 0
                StrLine = sr.ReadLine()
                StrData = StrLine.Split(delimiter)
                MoneyDataSet.MoneyDataTable.AddMoneyDataTableRow(
                    DateTime.Parse(StrData(0)),
                    StrData(1),
                    StrData(2),
                    Integer.Parse(StrData(3)),
                    StrData(4))
            Loop
            sr.Close()
        End If
    End Sub
#End Region

#Region "設定"
    Private Sub SettingTsmi_Click(sender As Object, e As EventArgs) Handles SettingTsmi.Click
        Dim FrmSetting As SettingFm = New SettingFm(CategoryDataSet1)
        Dim DrRet As DialogResult = FrmSetting.ShowDialog()

        If DrRet = DialogResult.OK Then
            ' 分類の再構築
            CategoryDataSet1.Clear()
            CategoryDataSet1.Merge(FrmSetting.CategoryDataSet)
            SaveCategory()
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
        ChangeSavedState(True)
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

#Region "終了"
    ' 終了ボタン
    Private Sub QuitTsmi_Click(sender As Object, e As EventArgs) Handles QuitTsmi.Click
        CloseApp()
    End Sub

    ' 終了メニュー
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        CloseApp()
    End Sub

    ' 強制終了メニュー
    Private Sub ForcedShutdownTsmi_Click(sender As Object, e As EventArgs) Handles ForcedShutdownTsmi.Click
        Dim dr As DialogResult = MsgBox("編集中のデータが破棄されますが、よろしいですか?" _
                                        , vbYesNo + vbQuestion, "強制終了")
        If dr = DialogResult.Yes Then
            ChangeSavedState(True)
            CloseApp()
        End If
    End Sub

    ' 終了
    Private Sub CloseApp()
        Me.Close()
    End Sub

    ' フォームを閉じるとき
    Private Sub AccountBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveData()
    End Sub
#End Region

End Class