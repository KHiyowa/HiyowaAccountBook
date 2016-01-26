Imports AccountBook1

Public Class EntryFm

#Region "コンストラクタ"
    Private Sub New()
        ' 引数のないコンストラクトは使用しない
    End Sub

    Public Sub New(DsCategory As CategoryDataSet)
        InitializeComponent()
        CategoryDataSet.Merge(DsCategory)
    End Sub

    Public Sub New(DsCategory As CategoryDataSet,
               NowDate As DateTime,
               category As String,
               item As String,
               money As Integer,
               remarks As String)

        InitializeComponent()
        CategoryDataSet.Merge(DsCategory)
        MonCalendar.SetDate(NowDate)
        CmbCategory.Text = category
        TxtItem.Text = item
        MTxtMoney.Text = money.ToString()
        TxtRemarks.Text = remarks
    End Sub
#End Region

End Class
