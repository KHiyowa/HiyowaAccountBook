<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCategoryFm
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
        Me.LblExplan = New System.Windows.Forms.Label()
        Me.LblCategoryName = New System.Windows.Forms.Label()
        Me.TxtCategoryName = New System.Windows.Forms.TextBox()
        Me.RbnIncome = New System.Windows.Forms.RadioButton()
        Me.RbnExpense = New System.Windows.Forms.RadioButton()
        Me.LblInE = New System.Windows.Forms.Label()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblExplan
        '
        Me.LblExplan.Location = New System.Drawing.Point(13, 13)
        Me.LblExplan.Name = "LblExplan"
        Me.LblExplan.Size = New System.Drawing.Size(276, 41)
        Me.LblExplan.TabIndex = 0
        '
        'LblCategoryName
        '
        Me.LblCategoryName.AutoSize = True
        Me.LblCategoryName.Location = New System.Drawing.Point(15, 68)
        Me.LblCategoryName.Name = "LblCategoryName"
        Me.LblCategoryName.Size = New System.Drawing.Size(41, 12)
        Me.LblCategoryName.TabIndex = 1
        Me.LblCategoryName.Text = "分類名"
        '
        'TxtCategoryName
        '
        Me.TxtCategoryName.Location = New System.Drawing.Point(62, 65)
        Me.TxtCategoryName.Name = "TxtCategoryName"
        Me.TxtCategoryName.Size = New System.Drawing.Size(227, 19)
        Me.TxtCategoryName.TabIndex = 2
        '
        'RbnIncome
        '
        Me.RbnIncome.AutoSize = True
        Me.RbnIncome.Location = New System.Drawing.Point(62, 95)
        Me.RbnIncome.Name = "RbnIncome"
        Me.RbnIncome.Size = New System.Drawing.Size(47, 16)
        Me.RbnIncome.TabIndex = 3
        Me.RbnIncome.TabStop = True
        Me.RbnIncome.Text = "収入"
        Me.RbnIncome.UseVisualStyleBackColor = True
        '
        'RbnExpense
        '
        Me.RbnExpense.AutoSize = True
        Me.RbnExpense.Checked = True
        Me.RbnExpense.Location = New System.Drawing.Point(115, 95)
        Me.RbnExpense.Name = "RbnExpense"
        Me.RbnExpense.Size = New System.Drawing.Size(47, 16)
        Me.RbnExpense.TabIndex = 4
        Me.RbnExpense.TabStop = True
        Me.RbnExpense.Text = "支出"
        Me.RbnExpense.UseVisualStyleBackColor = True
        '
        'LblInE
        '
        Me.LblInE.AutoSize = True
        Me.LblInE.Location = New System.Drawing.Point(15, 97)
        Me.LblInE.Name = "LblInE"
        Me.LblInE.Size = New System.Drawing.Size(29, 12)
        Me.LblInE.TabIndex = 5
        Me.LblInE.Text = "収支"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnSubmit.Location = New System.Drawing.Point(115, 117)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(84, 23)
        Me.BtnSubmit.TabIndex = 6
        Me.BtnSubmit.Text = "登録(&S)"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(205, 117)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(84, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "登録しない(&N)"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'AddCategoryFm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LblInE)
        Me.Controls.Add(Me.RbnExpense)
        Me.Controls.Add(Me.RbnIncome)
        Me.Controls.Add(Me.TxtCategoryName)
        Me.Controls.Add(Me.LblCategoryName)
        Me.Controls.Add(Me.LblExplan)
        Me.Name = "AddCategoryFm"
        Me.Text = "新しい分類の追加"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblExplan As Label
    Friend WithEvents LblCategoryName As Label
    Friend WithEvents TxtCategoryName As TextBox
    Friend WithEvents RbnIncome As RadioButton
    Friend WithEvents RbnExpense As RadioButton
    Friend WithEvents LblInE As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnCancel As Button
End Class
