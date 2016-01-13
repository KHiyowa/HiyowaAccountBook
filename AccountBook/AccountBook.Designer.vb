<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountBook
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
        Me.CommandBarMs = New System.Windows.Forms.MenuStrip()
        Me.FileTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountingTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionInfoTsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountDgv = New System.Windows.Forms.DataGridView()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ChangeBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.MoneyDataSet = New AccountBook1.MoneyDataSet()
        Me.MoneyDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.日付DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.分類DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.品名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.金額DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.備考DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataSet1 = New AccountBook1.CategoryDataSet()
        Me.CommandBarMs.SuspendLayout()
        CType(Me.AccountDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommandBarMs
        '
        Me.CommandBarMs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTsmi, Me.EditTsmi, Me.ViewTsmi, Me.HelpTsmi})
        Me.CommandBarMs.Location = New System.Drawing.Point(0, 0)
        Me.CommandBarMs.Name = "CommandBarMs"
        Me.CommandBarMs.Size = New System.Drawing.Size(498, 24)
        Me.CommandBarMs.TabIndex = 0
        Me.CommandBarMs.Text = "MenuStrip1"
        '
        'FileTsmi
        '
        Me.FileTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTsmi, Me.QuitTsmi})
        Me.FileTsmi.Name = "FileTsmi"
        Me.FileTsmi.Size = New System.Drawing.Size(70, 20)
        Me.FileTsmi.Text = "ファイル(&F)"
        '
        'SaveTsmi
        '
        Me.SaveTsmi.Name = "SaveTsmi"
        Me.SaveTsmi.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveTsmi.Size = New System.Drawing.Size(162, 22)
        Me.SaveTsmi.Text = "保存(&S)"
        '
        'QuitTsmi
        '
        Me.QuitTsmi.Name = "QuitTsmi"
        Me.QuitTsmi.Size = New System.Drawing.Size(162, 22)
        Me.QuitTsmi.Text = "終了(&Q)"
        '
        'EditTsmi
        '
        Me.EditTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTsmi, Me.ChangeTsmi, Me.DeleteTsmi})
        Me.EditTsmi.Name = "EditTsmi"
        Me.EditTsmi.Size = New System.Drawing.Size(60, 20)
        Me.EditTsmi.Text = "編集(&E)"
        '
        'AddTsmi
        '
        Me.AddTsmi.Name = "AddTsmi"
        Me.AddTsmi.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddTsmi.Size = New System.Drawing.Size(163, 22)
        Me.AddTsmi.Text = "追加(&A)"
        '
        'ChangeTsmi
        '
        Me.ChangeTsmi.Name = "ChangeTsmi"
        Me.ChangeTsmi.Size = New System.Drawing.Size(163, 22)
        Me.ChangeTsmi.Text = "変更(&C)"
        '
        'DeleteTsmi
        '
        Me.DeleteTsmi.Name = "DeleteTsmi"
        Me.DeleteTsmi.Size = New System.Drawing.Size(163, 22)
        Me.DeleteTsmi.Text = "削除(&D)"
        '
        'ViewTsmi
        '
        Me.ViewTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListTsmi, Me.CountingTsmi})
        Me.ViewTsmi.Name = "ViewTsmi"
        Me.ViewTsmi.Size = New System.Drawing.Size(61, 20)
        Me.ViewTsmi.Text = "表示(&V)"
        '
        'ListTsmi
        '
        Me.ListTsmi.Name = "ListTsmi"
        Me.ListTsmi.Size = New System.Drawing.Size(152, 22)
        Me.ListTsmi.Text = "一覧表示(&L)"
        '
        'CountingTsmi
        '
        Me.CountingTsmi.Name = "CountingTsmi"
        Me.CountingTsmi.Size = New System.Drawing.Size(152, 22)
        Me.CountingTsmi.Text = "集計表示(&C)"
        '
        'HelpTsmi
        '
        Me.HelpTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionInfoTsmi})
        Me.HelpTsmi.Name = "HelpTsmi"
        Me.HelpTsmi.Size = New System.Drawing.Size(67, 20)
        Me.HelpTsmi.Text = "ヘルプ(&H)"
        '
        'VersionInfoTsmi
        '
        Me.VersionInfoTsmi.Name = "VersionInfoTsmi"
        Me.VersionInfoTsmi.Size = New System.Drawing.Size(161, 22)
        Me.VersionInfoTsmi.Text = "バージョン情報(&V)"
        '
        'AccountDgv
        '
        Me.AccountDgv.AutoGenerateColumns = False
        Me.AccountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.日付DataGridViewTextBoxColumn, Me.分類DataGridViewTextBoxColumn, Me.品名DataGridViewTextBoxColumn, Me.金額DataGridViewTextBoxColumn, Me.備考DataGridViewTextBoxColumn})
        Me.AccountDgv.DataSource = Me.MoneyDataTableBindingSource
        Me.AccountDgv.Location = New System.Drawing.Point(12, 27)
        Me.AccountDgv.Name = "AccountDgv"
        Me.AccountDgv.RowTemplate.Height = 21
        Me.AccountDgv.Size = New System.Drawing.Size(474, 285)
        Me.AccountDgv.TabIndex = 1
        '
        'QuitBtn
        '
        Me.QuitBtn.Location = New System.Drawing.Point(411, 318)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(75, 23)
        Me.QuitBtn.TabIndex = 2
        Me.QuitBtn.Text = "終了"
        Me.QuitBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(12, 318)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 3
        Me.AddBtn.Text = "追加"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ChangeBtn
        '
        Me.ChangeBtn.Location = New System.Drawing.Point(93, 318)
        Me.ChangeBtn.Name = "ChangeBtn"
        Me.ChangeBtn.Size = New System.Drawing.Size(75, 23)
        Me.ChangeBtn.TabIndex = 4
        Me.ChangeBtn.Text = "変更"
        Me.ChangeBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(174, 318)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 5
        Me.DeleteBtn.Text = "削除"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'MoneyDataSet
        '
        Me.MoneyDataSet.DataSetName = "MoneyDataSet"
        Me.MoneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoneyDataTableBindingSource
        '
        Me.MoneyDataTableBindingSource.DataMember = "MoneyDataTable"
        Me.MoneyDataTableBindingSource.DataSource = Me.MoneyDataSet
        '
        '日付DataGridViewTextBoxColumn
        '
        Me.日付DataGridViewTextBoxColumn.DataPropertyName = "日付"
        Me.日付DataGridViewTextBoxColumn.HeaderText = "日付"
        Me.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn"
        '
        '分類DataGridViewTextBoxColumn
        '
        Me.分類DataGridViewTextBoxColumn.DataPropertyName = "分類"
        Me.分類DataGridViewTextBoxColumn.HeaderText = "分類"
        Me.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn"
        '
        '品名DataGridViewTextBoxColumn
        '
        Me.品名DataGridViewTextBoxColumn.DataPropertyName = "品名"
        Me.品名DataGridViewTextBoxColumn.HeaderText = "品名"
        Me.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn"
        '
        '金額DataGridViewTextBoxColumn
        '
        Me.金額DataGridViewTextBoxColumn.DataPropertyName = "金額"
        Me.金額DataGridViewTextBoxColumn.HeaderText = "金額"
        Me.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn"
        '
        '備考DataGridViewTextBoxColumn
        '
        Me.備考DataGridViewTextBoxColumn.DataPropertyName = "備考"
        Me.備考DataGridViewTextBoxColumn.HeaderText = "備考"
        Me.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn"
        '
        'CategoryDataSet1
        '
        Me.CategoryDataSet1.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 353)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.ChangeBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.QuitBtn)
        Me.Controls.Add(Me.AccountDgv)
        Me.Controls.Add(Me.CommandBarMs)
        Me.MainMenuStrip = Me.CommandBarMs
        Me.Name = "AccountBook"
        Me.Text = "ひよわ家計簿"
        Me.CommandBarMs.ResumeLayout(False)
        Me.CommandBarMs.PerformLayout()
        CType(Me.AccountDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoneyDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CommandBarMs As MenuStrip
    Friend WithEvents FileTsmi As ToolStripMenuItem
    Friend WithEvents SaveTsmi As ToolStripMenuItem
    Friend WithEvents QuitTsmi As ToolStripMenuItem
    Friend WithEvents EditTsmi As ToolStripMenuItem
    Friend WithEvents AddTsmi As ToolStripMenuItem
    Friend WithEvents ChangeTsmi As ToolStripMenuItem
    Friend WithEvents DeleteTsmi As ToolStripMenuItem
    Friend WithEvents AccountDgv As DataGridView
    Friend WithEvents QuitBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents ChangeBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ViewTsmi As ToolStripMenuItem
    Friend WithEvents ListTsmi As ToolStripMenuItem
    Friend WithEvents CountingTsmi As ToolStripMenuItem
    Friend WithEvents HelpTsmi As ToolStripMenuItem
    Friend WithEvents VersionInfoTsmi As ToolStripMenuItem
    Friend WithEvents 日付DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 分類DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 品名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 金額DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 備考DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataTableBindingSource As BindingSource
    Friend WithEvents MoneyDataSet As MoneyDataSet
    Friend WithEvents CategoryDataSet1 As CategoryDataSet
End Class
