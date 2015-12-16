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
        Me.CommandBarMs = New System.Windows.Forms.MenuStrip()
        Me.AccountDgv = New System.Windows.Forms.DataGridView()
        Me.QuitBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ChangeBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
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
        Me.CommandBarMs.SuspendLayout()
        CType(Me.AccountDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommandBarMs
        '
        Me.CommandBarMs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTsmi, Me.EditTsmi, Me.ViewTsmi, Me.HelpTsmi})
        Me.CommandBarMs.Location = New System.Drawing.Point(0, 0)
        Me.CommandBarMs.Name = "CommandBarMs"
        Me.CommandBarMs.Size = New System.Drawing.Size(498, 26)
        Me.CommandBarMs.TabIndex = 0
        Me.CommandBarMs.Text = "MenuStrip1"
        '
        'AccountDgv
        '
        Me.AccountDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountDgv.Location = New System.Drawing.Point(12, 27)
        Me.AccountDgv.Name = "AccountDgv"
        Me.AccountDgv.RowTemplate.Height = 21
        Me.AccountDgv.Size = New System.Drawing.Size(474, 285)
        Me.AccountDgv.TabIndex = 1
        '
        'QuitBtn
        '
        Me.QuitBtn.Location = New System.Drawing.Point(12, 318)
        Me.QuitBtn.Name = "QuitBtn"
        Me.QuitBtn.Size = New System.Drawing.Size(75, 23)
        Me.QuitBtn.TabIndex = 2
        Me.QuitBtn.Text = "終了"
        Me.QuitBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(249, 318)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 3
        Me.AddBtn.Text = "追加"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ChangeBtn
        '
        Me.ChangeBtn.Location = New System.Drawing.Point(330, 318)
        Me.ChangeBtn.Name = "ChangeBtn"
        Me.ChangeBtn.Size = New System.Drawing.Size(75, 23)
        Me.ChangeBtn.TabIndex = 4
        Me.ChangeBtn.Text = "変更"
        Me.ChangeBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(411, 318)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 5
        Me.DeleteBtn.Text = "削除"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'FileTsmi
        '
        Me.FileTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTsmi, Me.QuitTsmi})
        Me.FileTsmi.Name = "FileTsmi"
        Me.FileTsmi.Size = New System.Drawing.Size(85, 22)
        Me.FileTsmi.Text = "ファイル(&F)"
        '
        'SaveTsmi
        '
        Me.SaveTsmi.Name = "SaveTsmi"
        Me.SaveTsmi.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveTsmi.Size = New System.Drawing.Size(165, 22)
        Me.SaveTsmi.Text = "保存(&S)"
        '
        'QuitTsmi
        '
        Me.QuitTsmi.Name = "QuitTsmi"
        Me.QuitTsmi.Size = New System.Drawing.Size(165, 22)
        Me.QuitTsmi.Text = "終了(&Q)"
        '
        'EditTsmi
        '
        Me.EditTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTsmi, Me.ChangeTsmi, Me.DeleteTsmi})
        Me.EditTsmi.Name = "EditTsmi"
        Me.EditTsmi.Size = New System.Drawing.Size(61, 22)
        Me.EditTsmi.Text = "編集(&E)"
        '
        'AddTsmi
        '
        Me.AddTsmi.Name = "AddTsmi"
        Me.AddTsmi.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddTsmi.Size = New System.Drawing.Size(166, 22)
        Me.AddTsmi.Text = "追加(&A)"
        '
        'ChangeTsmi
        '
        Me.ChangeTsmi.Name = "ChangeTsmi"
        Me.ChangeTsmi.Size = New System.Drawing.Size(166, 22)
        Me.ChangeTsmi.Text = "変更(&C)"
        '
        'DeleteTsmi
        '
        Me.DeleteTsmi.Name = "DeleteTsmi"
        Me.DeleteTsmi.Size = New System.Drawing.Size(166, 22)
        Me.DeleteTsmi.Text = "削除(&D)"
        '
        'ViewTsmi
        '
        Me.ViewTsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListTsmi, Me.CountingTsmi})
        Me.ViewTsmi.Name = "ViewTsmi"
        Me.ViewTsmi.Size = New System.Drawing.Size(62, 22)
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
        Me.HelpTsmi.Size = New System.Drawing.Size(75, 22)
        Me.HelpTsmi.Text = "ヘルプ(&H)"
        '
        'VersionInfoTsmi
        '
        Me.VersionInfoTsmi.Name = "VersionInfoTsmi"
        Me.VersionInfoTsmi.Size = New System.Drawing.Size(178, 22)
        Me.VersionInfoTsmi.Text = "バージョン情報(&V)"
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
End Class
