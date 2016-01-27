Public Class AddCategoryFm
    Public Sub New(explan As String, name As String)
        InitializeComponent()
        LblExplan.Text = explan
        TxtCategoryName.Text = name
    End Sub
    Public Sub New(explan As String)
        InitializeComponent()
        LblExplan.Text = explan
    End Sub
End Class