<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryFm
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
        Me.MonCalendar = New System.Windows.Forms.MonthCalendar()
        Me.EntryBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.CategoryDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataSet = New AccountBook1.CategoryDataSet()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.LblItem = New System.Windows.Forms.Label()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.MTxtMoney = New System.Windows.Forms.TextBox()
        Me.LblMoney = New System.Windows.Forms.Label()
        Me.LblRemarks = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonCalendar
        '
        Me.MonCalendar.Location = New System.Drawing.Point(18, 18)
        Me.MonCalendar.Name = "MonCalendar"
        Me.MonCalendar.TabIndex = 0
        '
        'EntryBtn
        '
        Me.EntryBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.EntryBtn.Location = New System.Drawing.Point(301, 157)
        Me.EntryBtn.Name = "EntryBtn"
        Me.EntryBtn.Size = New System.Drawing.Size(75, 23)
        Me.EntryBtn.TabIndex = 5
        Me.EntryBtn.Text = "登録"
        Me.EntryBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(382, 157)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "キャンセル"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'CmbCategory
        '
        Me.CmbCategory.DataSource = Me.CategoryDataTableBindingSource
        Me.CmbCategory.DisplayMember = "分類"
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(301, 18)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(156, 20)
        Me.CmbCategory.TabIndex = 1
        '
        'CategoryDataTableBindingSource
        '
        Me.CategoryDataTableBindingSource.DataMember = "CategoryDataTable"
        Me.CategoryDataTableBindingSource.DataSource = Me.CategoryDataSet
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(250, 21)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(29, 12)
        Me.LblCategory.TabIndex = 4
        Me.LblCategory.Text = "分類"
        '
        'LblItem
        '
        Me.LblItem.AutoSize = True
        Me.LblItem.Location = New System.Drawing.Point(250, 48)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(29, 12)
        Me.LblItem.TabIndex = 5
        Me.LblItem.Text = "品名"
        '
        'TxtItem
        '
        Me.TxtItem.Location = New System.Drawing.Point(301, 45)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(156, 19)
        Me.TxtItem.TabIndex = 2
        '
        'MTxtMoney
        '
        Me.MTxtMoney.Location = New System.Drawing.Point(301, 71)
        Me.MTxtMoney.Name = "MTxtMoney"
        Me.MTxtMoney.Size = New System.Drawing.Size(156, 19)
        Me.MTxtMoney.TabIndex = 3
        '
        'LblMoney
        '
        Me.LblMoney.AutoSize = True
        Me.LblMoney.Location = New System.Drawing.Point(250, 74)
        Me.LblMoney.Name = "LblMoney"
        Me.LblMoney.Size = New System.Drawing.Size(29, 12)
        Me.LblMoney.TabIndex = 8
        Me.LblMoney.Text = "金額"
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(250, 100)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(29, 12)
        Me.LblRemarks.TabIndex = 9
        Me.LblRemarks.Text = "備考"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(301, 97)
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(156, 19)
        Me.TxtRemarks.TabIndex = 4
        '
        'EntryFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(469, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtRemarks)
        Me.Controls.Add(Me.LblRemarks)
        Me.Controls.Add(Me.LblMoney)
        Me.Controls.Add(Me.MTxtMoney)
        Me.Controls.Add(Me.TxtItem)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.CmbCategory)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EntryBtn)
        Me.Controls.Add(Me.MonCalendar)
        Me.Name = "EntryFm"
        Me.Text = "登録"
        CType(Me.CategoryDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonCalendar As MonthCalendar
    Friend WithEvents EntryBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents CmbCategory As ComboBox
    Friend WithEvents LblCategory As Label
    Friend WithEvents LblItem As Label
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents MTxtMoney As TextBox
    Friend WithEvents LblMoney As Label
    Friend WithEvents LblRemarks As Label
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents CategoryDataTableBindingSource As BindingSource
    Friend WithEvents CategoryDataSet As CategoryDataSet
End Class
