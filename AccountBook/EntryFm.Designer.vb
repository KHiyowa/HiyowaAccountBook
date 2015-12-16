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
        Me.MonCalendar = New System.Windows.Forms.MonthCalendar()
        Me.EntryBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GroupingCb = New System.Windows.Forms.ComboBox()
        Me.GroupingLb = New System.Windows.Forms.Label()
        Me.ArticleLb = New System.Windows.Forms.Label()
        Me.ArticleTb = New System.Windows.Forms.TextBox()
        Me.CostTb = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CostLb = New System.Windows.Forms.Label()
        Me.NoteLb = New System.Windows.Forms.Label()
        Me.NoteTb = New System.Windows.Forms.TextBox()
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
        Me.EntryBtn.Location = New System.Drawing.Point(382, 157)
        Me.EntryBtn.Name = "EntryBtn"
        Me.EntryBtn.Size = New System.Drawing.Size(75, 23)
        Me.EntryBtn.TabIndex = 5
        Me.EntryBtn.Text = "登録"
        Me.EntryBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(301, 157)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "キャンセル"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'GroupingCb
        '
        Me.GroupingCb.FormattingEnabled = True
        Me.GroupingCb.Location = New System.Drawing.Point(301, 18)
        Me.GroupingCb.Name = "GroupingCb"
        Me.GroupingCb.Size = New System.Drawing.Size(156, 20)
        Me.GroupingCb.TabIndex = 1
        '
        'GroupingLb
        '
        Me.GroupingLb.AutoSize = True
        Me.GroupingLb.Location = New System.Drawing.Point(250, 21)
        Me.GroupingLb.Name = "GroupingLb"
        Me.GroupingLb.Size = New System.Drawing.Size(29, 12)
        Me.GroupingLb.TabIndex = 4
        Me.GroupingLb.Text = "分類"
        '
        'ArticleLb
        '
        Me.ArticleLb.AutoSize = True
        Me.ArticleLb.Location = New System.Drawing.Point(250, 48)
        Me.ArticleLb.Name = "ArticleLb"
        Me.ArticleLb.Size = New System.Drawing.Size(29, 12)
        Me.ArticleLb.TabIndex = 5
        Me.ArticleLb.Text = "品名"
        '
        'ArticleTb
        '
        Me.ArticleTb.Location = New System.Drawing.Point(301, 45)
        Me.ArticleTb.Name = "ArticleTb"
        Me.ArticleTb.Size = New System.Drawing.Size(156, 19)
        Me.ArticleTb.TabIndex = 2
        '
        'CostTb
        '
        Me.CostTb.Location = New System.Drawing.Point(301, 71)
        Me.CostTb.Name = "CostTb"
        Me.CostTb.Size = New System.Drawing.Size(156, 19)
        Me.CostTb.TabIndex = 3
        '
        'CostLb
        '
        Me.CostLb.AutoSize = True
        Me.CostLb.Location = New System.Drawing.Point(250, 74)
        Me.CostLb.Name = "CostLb"
        Me.CostLb.Size = New System.Drawing.Size(29, 12)
        Me.CostLb.TabIndex = 8
        Me.CostLb.Text = "金額"
        '
        'NoteLb
        '
        Me.NoteLb.AutoSize = True
        Me.NoteLb.Location = New System.Drawing.Point(250, 100)
        Me.NoteLb.Name = "NoteLb"
        Me.NoteLb.Size = New System.Drawing.Size(29, 12)
        Me.NoteLb.TabIndex = 9
        Me.NoteLb.Text = "備考"
        '
        'NoteTb
        '
        Me.NoteTb.Location = New System.Drawing.Point(301, 97)
        Me.NoteTb.Name = "NoteTb"
        Me.NoteTb.Size = New System.Drawing.Size(156, 19)
        Me.NoteTb.TabIndex = 4
        '
        'EntryFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(469, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.NoteTb)
        Me.Controls.Add(Me.NoteLb)
        Me.Controls.Add(Me.CostLb)
        Me.Controls.Add(Me.CostTb)
        Me.Controls.Add(Me.ArticleTb)
        Me.Controls.Add(Me.ArticleLb)
        Me.Controls.Add(Me.GroupingLb)
        Me.Controls.Add(Me.GroupingCb)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EntryBtn)
        Me.Controls.Add(Me.MonCalendar)
        Me.Name = "EntryFm"
        Me.Text = "登録"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonCalendar As MonthCalendar
    Friend WithEvents EntryBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents GroupingCb As ComboBox
    Friend WithEvents GroupingLb As Label
    Friend WithEvents ArticleLb As Label
    Friend WithEvents ArticleTb As TextBox
    Friend WithEvents CostTb As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CostLb As Label
    Friend WithEvents NoteLb As Label
    Friend WithEvents NoteTb As TextBox
End Class
