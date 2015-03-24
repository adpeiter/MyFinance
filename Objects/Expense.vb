Namespace Objects

    Public Class Expense

        Property id As UInt32
        Property [date] As Date
        Property paymentMethod As Enumerators.PaymentMethod
        Property item As New Objects.ExpenseItem
        Property multiple As Integer
        Property quantity As Decimal
        Property value As Decimal
        Property isUnitPrice As Byte
        Property portions As Byte
        Property observation As String
        Property external As Byte

    End Class

End Namespace