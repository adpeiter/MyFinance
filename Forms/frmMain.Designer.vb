<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tsMainMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbCategories = New System.Windows.Forms.ToolStripButton()
        Me.tsbItems = New System.Windows.Forms.ToolStripButton()
        Me.tsbExpenseCategories = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvExpenses = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paymentid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.multiple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalvalue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tsMainMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMainMenu
        '
        Me.tsMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCategories, Me.tsbItems})
        Me.tsMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMainMenu.Name = "tsMainMenu"
        Me.tsMainMenu.Size = New System.Drawing.Size(1045, 71)
        Me.tsMainMenu.TabIndex = 0
        '
        'tsbCategories
        '
        Me.tsbCategories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCategories.Image = CType(resources.GetObject("tsbCategories.Image"), System.Drawing.Image)
        Me.tsbCategories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbCategories.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCategories.Name = "tsbCategories"
        Me.tsbCategories.Size = New System.Drawing.Size(68, 68)
        Me.tsbCategories.ToolTipText = "Categories"
        '
        'tsbItems
        '
        Me.tsbItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbItems.Image = Global.MyFinance.My.Resources.Resources.items
        Me.tsbItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbItems.Name = "tsbItems"
        Me.tsbItems.Size = New System.Drawing.Size(68, 68)
        Me.tsbItems.ToolTipText = "Items"
        '
        'tsbExpenseCategories
        '
        Me.tsbExpenseCategories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExpenseCategories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbExpenseCategories.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExpenseCategories.Name = "tsbExpenseCategories"
        Me.tsbExpenseCategories.Size = New System.Drawing.Size(23, 68)
        Me.tsbExpenseCategories.ToolTipText = "Expense categories"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExpenseCategories, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(434, 71)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 68)
        Me.ToolStripButton1.ToolTipText = "Expense items"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(745, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'dgvExpenses
        '
        Me.dgvExpenses.AllowUserToAddRows = False
        Me.dgvExpenses.AllowUserToDeleteRows = False
        Me.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpenses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.paymentid, Me.dt, Me.item, Me.itemid, Me.category, Me.categoryid, Me.value, Me.quantity, Me.multiple, Me.payment, Me.totalvalue, Me.edit, Me.delete})
        Me.dgvExpenses.Location = New System.Drawing.Point(12, 89)
        Me.dgvExpenses.Name = "dgvExpenses"
        Me.dgvExpenses.ReadOnly = True
        Me.dgvExpenses.RowHeadersVisible = False
        Me.dgvExpenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpenses.Size = New System.Drawing.Size(968, 408)
        Me.dgvExpenses.TabIndex = 2
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'paymentid
        '
        Me.paymentid.HeaderText = "idpagamento"
        Me.paymentid.Name = "paymentid"
        Me.paymentid.ReadOnly = True
        Me.paymentid.Visible = False
        '
        'dt
        '
        Me.dt.HeaderText = "Data"
        Me.dt.Name = "dt"
        Me.dt.ReadOnly = True
        '
        'item
        '
        Me.item.HeaderText = "Item"
        Me.item.Name = "item"
        Me.item.ReadOnly = True
        '
        'itemid
        '
        Me.itemid.HeaderText = "iditem"
        Me.itemid.Name = "itemid"
        Me.itemid.ReadOnly = True
        Me.itemid.Visible = False
        '
        'category
        '
        Me.category.HeaderText = "Categoria"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'categoryid
        '
        Me.categoryid.HeaderText = "idcategory"
        Me.categoryid.Name = "categoryid"
        Me.categoryid.ReadOnly = True
        Me.categoryid.Visible = False
        '
        'value
        '
        Me.value.HeaderText = "Valor"
        Me.value.Name = "value"
        Me.value.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantidade"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'multiple
        '
        Me.multiple.HeaderText = "Múltiplo"
        Me.multiple.Name = "multiple"
        Me.multiple.ReadOnly = True
        '
        'payment
        '
        Me.payment.HeaderText = "Pagamento"
        Me.payment.Name = "payment"
        Me.payment.ReadOnly = True
        '
        'totalvalue
        '
        Me.totalvalue.HeaderText = "Total"
        Me.totalvalue.Name = "totalvalue"
        Me.totalvalue.ReadOnly = True
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
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(664, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 509)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.dgvExpenses)
        Me.Controls.Add(Me.tsMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyFinance"
        Me.tsMainMenu.ResumeLayout(False)
        Me.tsMainMenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMainMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbExpenseCategories As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbCategories As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbItems As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dgvExpenses As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paymentid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents categoryid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents multiple As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalvalue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnBuscar As System.Windows.Forms.Button

End Class
