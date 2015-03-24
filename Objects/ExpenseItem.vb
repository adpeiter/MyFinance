Namespace Objects

    Public Class ExpenseItem

        Property id As UInt32
        Property description As String
        Property category As Objects.ExpenseCategory
        Property measureUnit As Enumerators.MeasureUnit
        Property allowMultiple As Byte

        Property functions As New Functions

        ReadOnly Property descriptionAndMeasure As String
            Get
                Return description & If(measureUnit > 0, " (" & functions.GetEnumDescription(measureUnit) & ")", "")
            End Get
        End Property

        ReadOnly Property idAndAllowMultiple As String
            Get
                Return id & allowMultiple
            End Get
        End Property

        Sub New()
            description = ""
            category = New Objects.ExpenseCategory
            category.description = ""
        End Sub

        Sub New(ByVal id As UInt32, ByVal description As String)
            Me.id = id
            Me.description = description
        End Sub

        Sub New(ByVal id As UInt32, ByVal description As String, ByVal category As Objects.ExpenseCategory, measureUnit As Enumerators.MeasureUnit)
            Me.id = id
            Me.description = description
            Me.category = category
            Me.measureUnit = measureUnit
        End Sub

    End Class

End Namespace