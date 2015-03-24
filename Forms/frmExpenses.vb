Public Class frmExpenses

    Private _dbExpenseCategory As New Database.ExpenseCategory
    Private _expenseCategories As New List(Of Objects.ExpenseCategory)
    Private Const _dgvColumnNameId As String = "id"
    Private Const _dgvColumnNameDescription As String = "description"
    Private Const _dgvColumnNameEdit As String = "edit"
    Private Const _dgvColumnNameDelete As String = "delete"
    Public _currentRow As Int32 = -1

    Private Sub frmExpenseCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Search()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search(txtDescription.Text.Trim)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddExpenseCategory()
    End Sub

    Private Sub dgvExpenseCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpenseCategories.CellClick
        CellClick(e.RowIndex, e.ColumnIndex)
    End Sub

    Sub Search(Optional ByVal description As String = "")

        dgvExpenseCategories.Rows.Clear()
        _expenseCategories.Clear()
        _expenseCategories = _dbExpenseCategory.Search(description)
        For Each ec In _expenseCategories
            _currentRow = -1
            SetGridRow(ec)
        Next

    End Sub

    Sub SetGridRow(ByRef expenseCategory As Objects.ExpenseCategory)

        If _currentRow = -1 Then
            dgvExpenseCategories.Rows.Add()
            _currentRow = dgvExpenseCategories.RowCount - 1
        End If
        With Me.dgvExpenseCategories.Rows(_currentRow)
            .Cells(_dgvColumnNameId).Value = expenseCategory.id
            .Cells(_dgvColumnNameDescription).Value = expenseCategory.description
        End With

    End Sub

    Sub AddExpenseCategory()
        _currentRow = -1
        frmAddEditExpenseCategory._idExpenseCategory = 0
        frmAddEditExpenseCategory.txtDescription.Text = String.Empty
        frmAddEditExpenseCategory.ShowDialog()
    End Sub

    Sub CellClick(row As Int32, ByVal col As Int32)

        If row >= 0 Then

            If dgvExpenseCategories.Columns(col).Name = _dgvColumnNameEdit Then

                _currentRow = row
                frmAddEditExpenseCategory._idExpenseCategory = dgvExpenseCategories.Rows(row).Cells(_dgvColumnNameId).Value
                frmAddEditExpenseCategory.txtDescription.Text = dgvExpenseCategories.Rows(row).Cells(_dgvColumnNameDescription).Value
                frmAddEditExpenseCategory.ShowDialog()

            ElseIf dgvExpenseCategories.Columns(col).Name = _dgvColumnNameDelete Then

                If MessageBox.Show("All items in this category will be without category! Are you sure?", "Confirm", MessageBoxButtons.YesNo) _
                    = Windows.Forms.DialogResult.Yes Then
                    _dbExpenseCategory.Delete(dgvExpenseCategories.Rows(row).Cells(_dgvColumnNameId).Value)
                    dgvExpenseCategories.Rows.RemoveAt(row)
                End If

            End If


        End If

    End Sub

End Class