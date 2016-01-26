Public Class SettingFm
#Region "コンストラクタ"
    Private Sub New()
        ' 引数のないコンストラクトは使用しない
    End Sub

    Public Sub New(SaveFilePath As String, DsCategory As CategoryDataSet)
        InitializeComponent()
        TxtSavePath.Text = SaveFilePath
        CategoryDataSet.Merge(DsCategory)
    End Sub
#End Region
End Class