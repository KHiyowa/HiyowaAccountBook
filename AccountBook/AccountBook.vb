Imports System.IO
Imports System.Text
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

#Region "保存"
    ' 保存ボタンを押したとき
    Private Sub SaveTsmi_Click(sender As Object, e As EventArgs) Handles SaveTsmi.Click
        SaveData()
    End Sub
    Sub SaveData()
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
        LoadData()
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", True)
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", False)
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", False)
        CategoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", False)
    End Sub

    ' フォームを閉じるとき
    Private Sub AccountBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveData()
    End Sub
#End Region

End Class