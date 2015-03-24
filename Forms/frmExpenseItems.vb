Public Class frmExpenseItems

    Private _dbExpenseItem As New Database.ExpenseItem
    Private _dbExpense As New Database.Expense
    Private _expenseItens As New List(Of Objects.ExpenseItem)
    Private _functions As New Functions

    Private Const _dgvColumnNameId As String = "id"
    Private Const _dgvColumnNameDescription As String = "description"
    Private Const _dgvColumnNameCategoryDescription As String = "category"
    Private Const _dgvColumnNameCategoryId As String = "idcategory"
    Private Const _dgvColumnNameMeasureDescription As String = "measure"
    Private Const _dgvColumnNameMeasureId As String = "measureid"
    Private Const _dgvColumnNameEdit As String = "edit"
    Private Const _dgvColumnNameDelete As String = "delete"

    Public _currentRow As Int32 = -1

    Private Sub frmExpenseItens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _functions.FillCbbExpenseCategory(cbbExpenseCategory, 0, "All")
        Search()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search(cbbExpenseCategory.SelectedValue, txtDescription.Text.Trim)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddExpenseItem()
    End Sub

    Private Sub dgvExpenseCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpenseItens.CellClick
        CellClick(e.RowIndex, e.ColumnIndex)
    End Sub

    Sub Search(Optional ByVal category As UInt32 = 0, Optional ByVal description As String = "")

        dgvExpenseItens.Rows.Clear()
        _expenseItens.Clear()
        _expenseItens = _dbExpenseItem.Search(cbbExpenseCategory.SelectedValue, description)
        For Each ei In _expenseItens
            _currentRow = -1
            SetGridRow(ei)
        Next

    End Sub

    Sub SetGridRow(ByRef expenseItem As Objects.ExpenseItem)

        If _currentRow = -1 Then
            dgvExpenseItens.Rows.Add()
            _currentRow = dgvExpenseItens.RowCount - 1
        End If
        With Me.dgvExpenseItens.Rows(_currentRow)
            .Cells(_dgvColumnNameId).Value = expenseItem.id
            .Cells(_dgvColumnNameCategoryId).Value = expenseItem.category.id
            .Cells(_dgvColumnNameMeasureId).Value = expenseItem.measureUnit
            .Cells(_dgvColumnNameDescription).Value = expenseItem.description
            .Cells(_dgvColumnNameCategoryDescription).Value = expenseItem.category.description
            .Cells(_dgvColumnNameMeasureDescription).Value = _functions.GetEnumDescription(expenseItem.measureUnit)
        End With

    End Sub

    Sub AddExpenseItem()
        _currentRow = -1
        frmAddEditExpenseItem._expenseItem.id = 0
        frmAddEditExpenseItem._expenseItem.category.id = 0
        frmAddEditExpenseItem._expenseItem.measureUnit = 0
        frmAddEditExpenseItem.txtDescription.Text = String.Empty
        frmAddEditExpenseItem.ShowDialog()
    End Sub

    Sub CellClick(row As Int32, ByVal col As Int32)

        If row >= 0 Then

            If dgvExpenseItens.Columns(col).Name = _dgvColumnNameEdit Then

                _currentRow = row
                frmAddEditExpenseItem._expenseItem.id = dgvExpenseItens.Rows(row).Cells(_dgvColumnNameId).Value
                frmAddEditExpenseItem._expenseItem.category.id = dgvExpenseItens.Rows(row).Cells(_dgvColumnNameCategoryId).Value
                frmAddEditExpenseItem._expenseItem.measureUnit = dgvExpenseItens.Rows(row).Cells(_dgvColumnNameMeasureId).Value
                frmAddEditExpenseItem.txtDescription.Text = dgvExpenseItens.Rows(row).Cells(_dgvColumnNameDescription).Value
                frmAddEditExpenseItem.ShowDialog()

            ElseIf dgvExpenseItens.Columns(col).Name = _dgvColumnNameDelete Then

                If MessageBox.Show("Ao deletar um item, todas as despesas do mesmo também serão deletadas. Tem certeza que deseja deletar este item?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                    = Windows.Forms.DialogResult.Yes Then
                    _dbExpense.DeleteAllOfItem(dgvExpenseItens.Rows(row).Cells(_dgvColumnNameId).Value)
                    _dbExpenseItem.Delete(dgvExpenseItens.Rows(row).Cells(_dgvColumnNameId).Value)
                    dgvExpenseItens.Rows.RemoveAt(row)
                End If

            End If


        End If

    End Sub

End Class