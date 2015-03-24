Public Class frmAddEditExpenseItem

    Private _dbExpenseItem As New Database.ExpenseItem
    Private _dbExpenseCategory As New Database.ExpenseCategory
    Private _functions As New Functions
    Public _expenseItem As New Objects.ExpenseItem

    Private Sub frmAddEditExpenseItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCbb()
    End Sub

    Sub FillCbb()
        _functions.FillCbbExpenseCategory(cbbExpenseCategory, _expenseItem.category.id)
        _functions.FillCbbWithEnum(cbbMeasureUnit, GetType(Enumerators.MeasureUnit), _expenseItem.measureUnit)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Sub Save()

        If txtDescription.Text.Trim.Length < 5 Then
            MessageBox.Show("A descrição é muito curta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _dbExpenseItem.Exists(txtDescription.Text.Trim) Then
            MessageBox.Show("Esta descrição já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With _expenseItem
                .description = txtDescription.Text.Trim
                .category = _dbExpenseCategory.Search(cbbExpenseCategory.SelectedValue)(0)
                .measureUnit = cbbMeasureUnit.SelectedValue
                .allowMultiple = If(chkAllowMultiple.Checked, 1, 0)
                If .id > 0 Then
                    _dbExpenseItem.Update(_expenseItem)
                Else
                    _dbExpenseItem.Insert(_expenseItem)
                End If

                If .id = 0 Then
                    MessageBox.Show("O item não foi salvo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    frmExpenseItems.SetGridRow(_expenseItem)
                    Me.Close()
                End If
            End With
        End If

    End Sub

End Class