Public Class SettingFm
#Region "コンストラクタ"
    Private Sub New()
        ' 引数のないコンストラクトは使用しない
    End Sub

    Public Sub New(SaveFilePath As String, UseDropbox As Boolean, DsCategory As CategoryDataSet)
        InitializeComponent()
        TxtSavePath.Text = SaveFilePath
        CkbDropbox.Checked = UseDropbox
        CategoryDataSet.Merge(DsCategory)
    End Sub

    ' カテゴリ追加ボタン
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim FrmAddCategory As AddCategoryFm =
        New AddCategoryFm("新しい分類を入力し、" & Chr(13) &
            "その分類が収入か支出かを選択してください。")
        Dim DrRet As DialogResult = FrmAddCategory.ShowDialog()

        If DrRet = DialogResult.OK Then
            ' ファイル名を生成
            Dim FileName As String = AccountBook.CreateFilename() + ".habc"

            ' ファイルを書き込み
            CategoryDataSet.CategoryDataTable.AddCategoryDataTableRow _
                (Name,
                 FrmAddCategory.RbnIncome.Checked,
                 FileName)
            AccountBook.SaveCategory(FileName,
                         FrmAddCategory.TxtCategoryName.Text + "," _
                         + FrmAddCategory.RbnIncome.Checked.ToString)
        End If
    End Sub

    ' カテゴリ変更ボタン


    ' カテゴリ削除ボタン
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        ' 現在の行番号を取得
        Dim NowRow As Integer = CategoryDgv.CurrentRow.Index
        ' 当該の行のファイル名を取得
        Dim FileName As String = CategoryDgv.Rows(NowRow).Cells(2).Value

        ' 表から削除
        CategoryDgv.Rows.RemoveAt(NowRow)
        ' ファイルを削除
        AccountBook.DeleteFile(AccountBook.CategoryFileDir, FileName)
    End Sub

    Private Sub BtnReference_Click(sender As Object, e As EventArgs) Handles BtnReference.Click
        TxtSavePath.Text = AccountBook.SelectDataFolder(TxtSavePath.Text)
    End Sub

#End Region
End Class