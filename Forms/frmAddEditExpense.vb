Public Class frmAddEditExpense

    Public _expense As New Objects.Expense

    Private _dbExpense As New Database.Expense
    Private _functions As New Functions
    Private _selectedValue As String

    Private Sub frmAddEditExpense_Load(sender As Object, e As EventArgs) Handles Me.Load
        _functions.FillCbbExpenseItem(cbbExpenseItem, If(IsNothing(_expense.item), 0, _expense.item.id), "Selecione")
        _functions.FillCbbWithEnum(cbbPaymentMethod, GetType(Enumerators.PaymentMethod), _expense.paymentMethod)
    End Sub

    Private Sub cbbExpenseItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbExpenseItem.SelectedIndexChanged
        EnableMultiple()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Sub EnableMultiple()
        _selectedValue = cbbExpenseItem.SelectedValue.ToString
        If _selectedValue.Chars(_selectedValue.Length - 1) <> "0" Then
            chkIsUnitPrice.Checked = True
            chkIsUnitPrice.Enabled = True
            nudQuantidade.Value = "1"
            nudQuantidade.Enabled = True
        Else
            chkIsUnitPrice.Checked = False
            chkIsUnitPrice.Enabled = False
            nudQuantidade.Value = "1"
            nudQuantidade.Enabled = False
        End If

    End Sub

    Private Sub Save()

        If cbbExpenseItem.SelectedIndex = 0 Then
            MessageBox.Show("É necessário selecionar um item!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not IsNumeric(txtQuantity.Text) Then
            MessageBox.Show("A quantidade deve ser um valor numérico!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Not IsNumeric(txtValue.Text) Then
            MessageBox.Show("O valor deve ser um valor numérico!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With _expense

                .date = dtpDate.Value
                .isUnitPrice = chkIsUnitPrice.Checked
                _selectedValue = cbbExpenseItem.SelectedValue.ToString
                .item.id = _selectedValue.Substring(0, _selectedValue.Length - 1)
                .observation = txtObservation.Text.Trim
                .paymentMethod = cbbPaymentMethod.SelectedValue
                .portions = nudPortions.Value
                .quantity = txtQuantity.Text
                .multiple = nudQuantidade.Value
                .value = txtValue.Text
                .external = chkExternal.Checked
                If .id = 0 Then
                    _dbExpense.Insert(_expense)
                Else
                    _dbExpense.Update(_expense)
                End If

                If .id = 0 Then
                    MessageBox.Show("A despesa não foi salva!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If MessageBox.Show("Despesa salva! Deseja adicionar outra?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                        ClearAllFields()
                        .id = 0
                    Else
                        Close()
                    End If
                End If

            End With

        End If

    End Sub


    Public Sub ClearAllFields()

        'dtpDate.Value = Now
        txtQuantity.Clear()
        nudQuantidade.Value = 1
        txtValue.Clear()
        nudPortions.Value = 0
        chkDiferentValues.Checked = False
        txtObservation.Clear()

    End Sub

End Class