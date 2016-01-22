Public Class SettingFm
#Region "コンストラクタ"
    Private Sub New()
        ' 引数のないコンストラクトは使用しない
    End Sub

    Public Sub New(DsCategory As CategoryDataSet)
        InitializeComponent()
        CategoryDataSet.Merge(DsCategory)
    End Sub
#End Region
End Class