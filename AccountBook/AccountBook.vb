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
        EntryFm.ShowDialog()
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
#End Region

End Class