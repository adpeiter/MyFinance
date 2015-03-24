<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditExpense
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cbbExpenseItem = New System.Windows.Forms.ComboBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.chkIsUnitPrice = New System.Windows.Forms.CheckBox()
        Me.lblPortions = New System.Windows.Forms.Label()
        Me.nudPortions = New System.Windows.Forms.NumericUpDown()
        Me.txtObservation = New System.Windows.Forms.TextBox()
        Me.lblObservation = New System.Windows.Forms.Label()
        Me.chkDiferentValues = New System.Windows.Forms.CheckBox()
        Me.cbbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.nudQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkExternal = New System.Windows.Forms.CheckBox()
        CType(Me.nudPortions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(213, 274)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 21)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Salvar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(75, 8)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(91, 20)
        Me.dtpDate.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(39, 12)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Data:"
        '
        'cbbExpenseItem
        '
        Me.cbbExpenseItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbExpenseItem.FormattingEnabled = True
        Me.cbbExpenseItem.Location = New System.Drawing.Point(75, 61)
        Me.cbbExpenseItem.Name = "cbbExpenseItem"
        Me.cbbExpenseItem.Size = New System.Drawing.Size(213, 21)
        Me.cbbExpenseItem.TabIndex = 2
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(42, 66)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(30, 13)
        Me.lblItem.TabIndex = 6
        Me.lblItem.Text = "Item:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(0, 93)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(72, 13)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Qtde/medida:"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(38, 119)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 11
        Me.lblValue.Text = "Valor:"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(75, 115)
        Me.txtValue.MaxLength = 50
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(91, 20)
        Me.txtValue.TabIndex = 4
        '
        'chkIsUnitPrice
        '
        Me.chkIsUnitPrice.AutoSize = True
        Me.chkIsUnitPrice.Checked = True
        Me.chkIsUnitPrice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsUnitPrice.Location = New System.Drawing.Point(170, 117)
        Me.chkIsUnitPrice.Name = "chkIsUnitPrice"
        Me.chkIsUnitPrice.Size = New System.Drawing.Size(91, 17)
        Me.chkIsUnitPrice.TabIndex = 5
        Me.chkIsUnitPrice.Text = "Preço unitário"
        Me.chkIsUnitPrice.UseVisualStyleBackColor = True
        '
        'lblPortions
        '
        Me.lblPortions.AutoSize = True
        Me.lblPortions.Location = New System.Drawing.Point(21, 145)
        Me.lblPortions.Name = "lblPortions"
        Me.lblPortions.Size = New System.Drawing.Size(51, 13)
        Me.lblPortions.TabIndex = 14
        Me.lblPortions.Text = "Parcelas:"
        '
        'nudPortions
        '
        Me.nudPortions.Location = New System.Drawing.Point(75, 141)
        Me.nudPortions.Name = "nudPortions"
        Me.nudPortions.Size = New System.Drawing.Size(91, 20)
        Me.nudPortions.TabIndex = 6
        '
        'txtObservation
        '
        Me.txtObservation.Location = New System.Drawing.Point(75, 167)
        Me.txtObservation.Multiline = True
        Me.txtObservation.Name = "txtObservation"
        Me.txtObservation.Size = New System.Drawing.Size(213, 101)
        Me.txtObservation.TabIndex = 8
        '
        'lblObservation
        '
        Me.lblObservation.AutoSize = True
        Me.lblObservation.Location = New System.Drawing.Point(4, 171)
        Me.lblObservation.Name = "lblObservation"
        Me.lblObservation.Size = New System.Drawing.Size(68, 13)
        Me.lblObservation.TabIndex = 16
        Me.lblObservation.Text = "Observação:"
        '
        'chkDiferentValues
        '
        Me.chkDiferentValues.AutoSize = True
        Me.chkDiferentValues.Location = New System.Drawing.Point(170, 143)
        Me.chkDiferentValues.Name = "chkDiferentValues"
        Me.chkDiferentValues.Size = New System.Drawing.Size(110, 17)
        Me.chkDiferentValues.TabIndex = 7
        Me.chkDiferentValues.Text = "Valores diferentes"
        Me.chkDiferentValues.UseVisualStyleBackColor = True
        '
        'cbbPaymentMethod
        '
        Me.cbbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPaymentMethod.FormattingEnabled = True
        Me.cbbPaymentMethod.Location = New System.Drawing.Point(75, 34)
        Me.cbbPaymentMethod.Name = "cbbPaymentMethod"
        Me.cbbPaymentMethod.Size = New System.Drawing.Size(213, 21)
        Me.cbbPaymentMethod.TabIndex = 1
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Location = New System.Drawing.Point(8, 39)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(64, 13)
        Me.lblPaymentMethod.TabIndex = 18
        Me.lblPaymentMethod.Text = "Pagamento:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(75, 89)
        Me.txtQuantity.MaxLength = 50
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(91, 20)
        Me.txtQuantity.TabIndex = 3
        '
        'nudQuantidade
        '
        Me.nudQuantidade.Location = New System.Drawing.Point(182, 89)
        Me.nudQuantidade.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantidade.Name = "nudQuantidade"
        Me.nudQuantidade.Size = New System.Drawing.Size(38, 20)
        Me.nudQuantidade.TabIndex = 19
        Me.nudQuantidade.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "x"
        '
        'chkExternal
        '
        Me.chkExternal.AutoSize = True
        Me.chkExternal.Location = New System.Drawing.Point(75, 276)
        Me.chkExternal.Name = "chkExternal"
        Me.chkExternal.Size = New System.Drawing.Size(92, 17)
        Me.chkExternal.TabIndex = 21
        Me.chkExternal.Text = "Gasto externo"
        Me.chkExternal.UseVisualStyleBackColor = True
        '
        'frmAddEditExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 303)
        Me.Controls.Add(Me.chkExternal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudQuantidade)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cbbPaymentMethod)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.chkDiferentValues)
        Me.Controls.Add(Me.lblObservation)
        Me.Controls.Add(Me.txtObservation)
        Me.Controls.Add(Me.lblPortions)
        Me.Controls.Add(Me.nudPortions)
        Me.Controls.Add(Me.chkIsUnitPrice)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.cbbExpenseItem)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmAddEditExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Despesa"
        CType(Me.nudPortions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cbbExpenseItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents chkIsUnitPrice As System.Windows.Forms.CheckBox
    Friend WithEvents lblPortions As System.Windows.Forms.Label
    Friend WithEvents nudPortions As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtObservation As System.Windows.Forms.TextBox
    Friend WithEvents lblObservation As System.Windows.Forms.Label
    Friend WithEvents chkDiferentValues As System.Windows.Forms.CheckBox
    Friend WithEvents cbbPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents nudQuantidade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkExternal As System.Windows.Forms.CheckBox
End Class
