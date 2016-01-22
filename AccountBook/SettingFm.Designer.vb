<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingFm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblSavePath = New System.Windows.Forms.Label()
        Me.TxtSavePath = New System.Windows.Forms.TextBox()
        Me.BtnReference = New System.Windows.Forms.Button()
        Me.LblCatEdit = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.ChangeBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CategoryDataSet = New AccountBook1.CategoryDataSet()
        Me.CategoryDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.収入DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSavePath
        '
        Me.LblSavePath.AutoSize = True
        Me.LblSavePath.Location = New System.Drawing.Point(12, 13)
        Me.LblSavePath.Name = "LblSavePath"
        Me.LblSavePath.Size = New System.Drawing.Size(77, 12)
        Me.LblSavePath.TabIndex = 0
        Me.LblSavePath.Text = "ファイル保存先:"
        '
        'TxtSavePath
        '
        Me.TxtSavePath.Location = New System.Drawing.Point(95, 10)
        Me.TxtSavePath.Name = "TxtSavePath"
        Me.TxtSavePath.Size = New System.Drawing.Size(279, 19)
        Me.TxtSavePath.TabIndex = 1
        '
        'BtnReference
        '
        Me.BtnReference.Location = New System.Drawing.Point(380, 8)
        Me.BtnReference.Name = "BtnReference"
        Me.BtnReference.Size = New System.Drawing.Size(75, 23)
        Me.BtnReference.TabIndex = 2
        Me.BtnReference.Text = "参照(&R)..."
        Me.BtnReference.UseVisualStyleBackColor = True
        '
        'LblCatEdit
        '
        Me.LblCatEdit.AutoSize = True
        Me.LblCatEdit.Location = New System.Drawing.Point(12, 42)
        Me.LblCatEdit.Name = "LblCatEdit"
        Me.LblCatEdit.Size = New System.Drawing.Size(75, 12)
        Me.LblCatEdit.TabIndex = 4
        Me.LblCatEdit.Text = "カテゴリの編集:"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(174, 257)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 9
        Me.DeleteBtn.Text = "削除(&D)"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'ChangeBtn
        '
        Me.ChangeBtn.Location = New System.Drawing.Point(93, 257)
        Me.ChangeBtn.Name = "ChangeBtn"
        Me.ChangeBtn.Size = New System.Drawing.Size(75, 23)
        Me.ChangeBtn.TabIndex = 8
        Me.ChangeBtn.Text = "変更(&C)"
        Me.ChangeBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(12, 257)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 7
        Me.AddBtn.Text = "追加(&A)"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnOK.Location = New System.Drawing.Point(299, 257)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 6
        Me.BtnOK.Text = "OK(&O)"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(380, 257)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "取消(&N)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.分類DataGridViewTextBoxColumn, Me.収入DataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.CategoryDataTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(441, 194)
        Me.DataGridView1.TabIndex = 11
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryDataTableBindingSource
        '
        Me.CategoryDataTableBindingSource.DataMember = "CategoryDataTable"
        Me.CategoryDataTableBindingSource.DataSource = Me.CategoryDataSet
        '
        '分類DataGridViewTextBoxColumn
        '
        Me.分類DataGridViewTextBoxColumn.DataPropertyName = "分類"
        Me.分類DataGridViewTextBoxColumn.HeaderText = "分類"
        Me.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn"
        '
        '収入DataGridViewCheckBoxColumn
        '
        Me.収入DataGridViewCheckBoxColumn.DataPropertyName = "収入"
        Me.収入DataGridViewCheckBoxColumn.HeaderText = "収入"
        Me.収入DataGridViewCheckBoxColumn.Name = "収入DataGridViewCheckBoxColumn"
        '
        'SettingFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.ChangeBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.LblCatEdit)
        Me.Controls.Add(Me.BtnReference)
        Me.Controls.Add(Me.TxtSavePath)
        Me.Controls.Add(Me.LblSavePath)
        Me.Name = "SettingFm"
        Me.Text = "設定"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSavePath As Label
    Friend WithEvents TxtSavePath As TextBox
    Friend WithEvents BtnReference As Button
    Friend WithEvents LblCatEdit As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ChangeBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents 入金DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents 分類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 収入DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CategoryDataTableBindingSource As BindingSource
    Friend WithEvents CategoryDataSet As CategoryDataSet
End Class
