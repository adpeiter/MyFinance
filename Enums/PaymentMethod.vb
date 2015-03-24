Imports System.ComponentModel

Namespace Enumerators

    Public Enum PaymentMethod

        <Description("Dinheiro")> Cash = 1
        <Description("Cartão (crédito)")> CreditCard = 2
        <Description("Cartão (débito)")> DebitCard = 3
        <Description("Débito em conta")> DebitAccount = 4
        <Description("Boleto")> Billet = 5
        <Description("Transferência")> Transfer = 6
        <Description("Cheque")> Check = 7

    End Enum

End Namespace