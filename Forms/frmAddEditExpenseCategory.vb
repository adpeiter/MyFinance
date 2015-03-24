Public Class frmAddEditExpenseCategory

    Private _dbExpenseCategory As New Database.ExpenseCategory
    Public _idExpenseCategory As Int32

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Sub Save()
        If Me.txtDescription.Text.Trim.Length < 5 Then
            MessageBox.Show("A descrição é muito curta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _dbExpenseCategory.Exists(Me.txtDescription.Text.Trim) Then
            MessageBox.Show("Essa descrição já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If _idExpenseCategory = 0 Then
                _idExpenseCategory = _dbExpenseCategory.Insert(Me.txtDescription.Text.Trim)
            Else
                If Not _dbExpenseCategory.Update(New Objects.ExpenseCategory(_idExpenseCategory, txtDescription.Text.Trim)) Then _idExpenseCategory = 0
            End If

            If _idExpenseCategory = 0 Then
                MessageBox.Show("A categoria não foi salva!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmExpenseCategories.SetGridRow(New Objects.ExpenseCategory(_idExpenseCategory, Me.txtDescription.Text.Trim))
                Me.Close()
            End If
        End If
    End Sub

End Class