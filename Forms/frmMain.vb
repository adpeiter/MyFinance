Public Class frmMain

    Private _dbExpense As New Database.Expense
    Private _expenses As New List(Of Objects.Expense)
    Private _functions As New Functions

    Private Const _dgvColumnNameId As String = "id"
    Private Const _dgvColumnNameData As String = "dt"
    Private Const _dgvColumnNameCategoryDescription As String = "category"
    Private Const _dgvColumnNameCategoryId As String = "categoryid"
    Private Const _dgvColumnNameItem As String = "item"
    Private Const _dgvColumnNameItemId As String = "itemid"
    Private Const _dgvColumnNameMeasureDescription As String = "measure"
    Private Const _dgvColumnNameQuantity As String = "quantity"
    Private Const _dgvColumnNameMultiple As String = "multiple"
    Private Const _dgvColumnNameValue As String = "value"
    Private Const _dgvColumnNameTotalValue As String = "totalvalue"
    Private Const _dgvColumnNameEdit As String = "edit"
    Private Const _dgvColumnNameDelete As String = "delete"
    Private Const _dgvColumnNamePayment As String = "payment"
    Private Const _dgvColumnNamePaymentId As String = "paymentid"

    Private _currentRow As Int32 = -1

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Search()
    End Sub

    Private Sub tsbCategories_Click(sender As Object, e As EventArgs) Handles tsbCategories.Click
        ViewExpenseCategories()
    End Sub

    Private Sub tsbItems_Click(sender As Object, e As EventArgs) Handles tsbItems.Click
        ViewExpenseItems()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddExpense()
    End Sub

    Sub ViewExpenseItems()
        frmExpenseItems.ShowDialog()
    End Sub

    Sub ViewExpenseCategories()
        frmExpenseCategories.ShowDialog()
    End Sub

    Sub AddExpense()

        frmAddEditExpense._expense.id = 0
        frmAddEditExpense.ClearAllFields()
        frmAddEditExpense.ShowDialog()

    End Sub


    Sub SetGridRow(ByRef expense As Objects.Expense)

        If _currentRow = -1 Then
            dgvExpenses.Rows.Add()
            _currentRow = dgvExpenses.RowCount - 1
        End If
        With dgvExpenses.Rows(_currentRow)
            .Cells(_dgvColumnNameId).Value = expense.id
            .Cells(_dgvColumnNameCategoryId).Value = expense.item.category.id
            .Cells(_dgvColumnNameCategoryDescription).Value = expense.item.category.description
            .Cells(_dgvColumnNameData).Value = expense.date.ToString("yyyy-MM-dd")
            .Cells(_dgvColumnNameMultiple).Value = expense.multiple
            .Cells(_dgvColumnNameQuantity).Value = expense.quantity
            .Cells(_dgvColumnNameValue).Value = expense.value
            .Cells(_dgvColumnNameTotalValue).Value = If(expense.isUnitPrice = 0, expense.value, expense.value * expense.quantity)
            .Cells(_dgvColumnNameItem).Value = expense.item.description
            .Cells(_dgvColumnNameItemId).Value = expense.item.id
            .Cells(_dgvColumnNamePayment).Value = _functions.GetEnumDescription(expense.paymentMethod)
            .Cells(_dgvColumnNamePaymentId).Value = expense.paymentMethod
        End With

    End Sub

    Sub Search()

        dgvExpenses.Rows.Clear()
        _expenses.Clear()
        _expenses = _dbExpense.SearchAll()
        For Each ex In _expenses
            _currentRow = -1
            SetGridRow(ex)
        Next


    End Sub

    Sub CellClick(row As Int32, ByVal col As Int32)

        _currentRow = row

        If row >= 0 Then

            If dgvExpenses.Columns(col).Name = _dgvColumnNameDelete Then

                If MessageBox.Show("Tem certeza que deseja deletar a despesa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.Yes Then
                    _dbExpense.Delete(dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value)
                    dgvExpenses.Rows.RemoveAt(row)
                End If

            ElseIf dgvExpenses.Columns(col).Name = _dgvColumnNameEdit Then

                With frmAddEditExpense._expense
                    .date = dgvExpenses.Rows(row).Cells(_dgvColumnNameData).Value
                    .id = dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value
                    .isUnitPrice = If(dgvExpenses.Rows(row).Cells(_dgvColumnNameValue).Value = dgvExpenses.Rows(row).Cells(_dgvColumnNameTotalValue).Value, 0, 1)
                    .item = New Objects.ExpenseItem(dgvExpenses.Rows(row).Cells(_dgvColumnNameItemId).Value, dgvExpenses.Rows(row).Cells(_dgvColumnNameItem).Value)
                    .quantity = dgvExpenses.Rows(row).Cells(_dgvColumnNameMeasureDescription).Value
                    .observation = dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value
                    .paymentMethod = dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value
                    .portions = dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value
                    .multiple = dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value
                    .value = dgvExpenses.Rows(row).Cells(_dgvColumnNameId).Value
                End With

            End If


        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Search()
    End Sub

    Private Sub dgvExpenses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpenses.CellClick
        CellClick(e.RowIndex, e.ColumnIndex)
    End Sub
End Class
