Public Class AddCategoryFm
    Public Sub New(explan As String, name As String)
        InitializeComponent()
        LblExplan.Text = explan
        TxtCategoryName.Text = name
    End Sub
End Class