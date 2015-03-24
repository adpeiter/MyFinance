<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditExpenseItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbbExpenseCategory = New System.Windows.Forms.ComboBox()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cbbMeasureUnit = New System.Windows.Forms.ComboBox()
        Me.lblMeasure = New System.Windows.Forms.Label()
        Me.chkAllowMultiple = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cbbExpenseCategory
        '
        Me.cbbExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbExpenseCategory.FormattingEnabled = True
        Me.cbbExpenseCategory.Location = New System.Drawing.Point(69, 9)
        Me.cbbExpenseCategory.Name = "cbbExpenseCategory"
        Me.cbbExpenseCategory.Size = New System.Drawing.Size(213, 21)
        Me.cbbExpenseCategory.TabIndex = 0
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Location = New System.Drawing.Point(14, 14)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(52, 13)
        Me.lblPaymentMethod.TabIndex = 20
        Me.lblPaymentMethod.Text = "Category:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(207, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 21)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(3, 40)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 22
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(69, 36)
        Me.txtDescription.MaxLength = 50
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(213, 20)
        Me.txtDescription.TabIndex = 1
        '
        'cbbMeasureUnit
        '
        Me.cbbMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMeasureUnit.FormattingEnabled = True
        Me.cbbMeasureUnit.Location = New System.Drawing.Point(69, 62)
        Me.cbbMeasureUnit.Name = "cbbMeasureUnit"
        Me.cbbMeasureUnit.Size = New System.Drawing.Size(213, 21)
        Me.cbbMeasureUnit.TabIndex = 2
        '
        'lblMeasure
        '
        Me.lblMeasure.AutoSize = True
        Me.lblMeasure.Location = New System.Drawing.Point(15, 67)
        Me.lblMeasure.Name = "lblMeasure"
        Me.lblMeasure.Size = New System.Drawing.Size(51, 13)
        Me.lblMeasure.TabIndex = 25
        Me.lblMeasure.Text = "Measure:"
        '
        'chkAllowMultiple
        '
        Me.chkAllowMultiple.AutoSize = True
        Me.chkAllowMultiple.Location = New System.Drawing.Point(69, 90)
        Me.chkAllowMultiple.Name = "chkAllowMultiple"
        Me.chkAllowMultiple.Size = New System.Drawing.Size(122, 17)
        Me.chkAllowMultiple.TabIndex = 26
        Me.chkAllowMultiple.Text = "Permite multiplicador"
        Me.chkAllowMultiple.UseVisualStyleBackColor = True
        '
        'frmAddEditExpenseItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 120)
        Me.Controls.Add(Me.chkAllowMultiple)
        Me.Controls.Add(Me.cbbMeasureUnit)
        Me.Controls.Add(Me.lblMeasure)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cbbExpenseCategory)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddEditExpenseItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbExpenseCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cbbMeasureUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblMeasure As System.Windows.Forms.Label
    Friend WithEvents chkAllowMultiple As System.Windows.Forms.CheckBox
End Class
