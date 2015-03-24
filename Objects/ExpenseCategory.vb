Namespace Objects

    Public Class ExpenseCategory

        Property id As UInt32
        Property description As String

        Sub New()
        End Sub

        Sub New(ByVal id As UInt32, ByVal description As String)
            Me.id = id
            Me.description = description
        End Sub

    End Class

End Namespace
