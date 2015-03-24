<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenseItems
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
        Me.dgvExpenseItens = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.measureid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.measure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbbExpenseCategory = New System.Windows.Forms.ComboBox()
        Me.lblPaymentMethod = New System.Windows.Forms.Label()
        CType(Me.dgvExpenseItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExpenseItens
        '
        Me.dgvExpenseItens.AllowUserToAddRows = False
        Me.dgvExpenseItens.AllowUserToDeleteRows = False
        Me.dgvExpenseItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpenseItens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.idcategory, Me.measureid, Me.description, Me.category, Me.measure, Me.edit, Me.delete})
        Me.dgvExpenseItens.Location = New System.Drawing.Point(12, 36)
        Me.dgvExpenseItens.Name = "dgvExpenseItens"
        Me.dgvExpenseItens.ReadOnly = True
        Me.dgvExpenseItens.RowHeadersVisible = False
        Me.dgvExpenseItens.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvExpenseItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpenseItens.Size = New System.Drawing.Size(643, 281)
        Me.dgvExpenseItens.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "Item Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 80
        '
        'idcategory
        '
        Me.idcategory.HeaderText = "Category Id"
        Me.idcategory.Name = "idcategory"
        Me.idcategory.ReadOnly = True
        Me.idcategory.Visible = False
        '
        'measureid
        '
        Me.measureid.HeaderText = "Measure Id"
        Me.measureid.Name = "measureid"
        Me.measureid.ReadOnly = True
        Me.measureid.Visible = False
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 200
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Width = 200
        '
        'measure
        '
        Me.measure.HeaderText = "Measure"
        Me.measure.Name = "measure"
        Me.measure.ReadOnly = True
        '
        'edit
        '
        Me.edit.HeaderText = "Edit"
        Me.edit.Image = Global.MyFinance.My.Resources.Resources.edit
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.edit.Width = 60
        '
        'delete
        '
        Me.delete.HeaderText = "Delete"
        Me.delete.Image = Global.MyFinance.My.Resources.Resources.delete
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.delete.Width = 80
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(581, 323)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 13)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(79, 9)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(195, 20)
        Me.txtDescription.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(551, 7)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbbExpenseCategory
        '
        Me.cbbExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbExpenseCategory.FormattingEnabled = True
        Me.cbbExpenseCategory.Location = New System.Drawing.Point(332, 8)
        Me.cbbExpenseCategory.Name = "cbbExpenseCategory"
        Me.cbbExpenseCategory.Size = New System.Drawing.Size(213, 21)
        Me.cbbExpenseCategory.TabIndex = 21
        '
        'lblPaymentMethod
        '
        Me.lblPaymentMethod.AutoSize = True
        Me.lblPaymentMethod.Location = New System.Drawing.Point(277, 13)
        Me.lblPaymentMethod.Name = "lblPaymentMethod"
        Me.lblPaymentMethod.Size = New System.Drawing.Size(52, 13)
        Me.lblPaymentMethod.TabIndex = 22
        Me.lblPaymentMethod.Text = "Category:"
        '
        'frmExpenseItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 355)
        Me.Controls.Add(Me.cbbExpenseCategory)
        Me.Controls.Add(Me.lblPaymentMethod)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.dgvExpenseItens)
        Me.Name = "frmExpenseItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense itens"
        CType(Me.dgvExpenseItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvExpenseItens As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idcategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents measureid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents measure As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents cbbExpenseCategory As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentMethod As System.Windows.Forms.Label
End Class
