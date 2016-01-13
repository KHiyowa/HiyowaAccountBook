Imports AccountBook1

Public Class EntryFm

    Public Sub New(DsCategory As CategoryDataSet)
        InitializeComponent()
        CategoryDataSet.Merge(DsCategory)
    End Sub

End Class
