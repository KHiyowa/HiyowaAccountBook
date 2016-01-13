Public Class AccountBook

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
            FrmEntry.GroupingCb.Text,
            FrmEntry.ArticleTb.Text,
            Integer.Parse(FrmEntry.CostTb.Text),
            FrmEntry.NoteTb.Text)
        End If

    End Sub
#End Region

#Region "終了"
    ' 終了ボタン
    Private Sub QuitTsmi_Click(sender As Object, e As EventArgs) Handles QuitTsmi.Click
        CloseApp()
    End Sub
    Private Sub QuitBtn_Click(sender As Object, e As EventArgs) Handles QuitBtn.Click
        CloseApp()
    End Sub

    ' 終了
    Private Sub CloseApp()
        Application.Exit()
    End Sub

    Private Sub AccountBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", True)
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", False)
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", False)
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", False)
    End Sub
#End Region

End Class