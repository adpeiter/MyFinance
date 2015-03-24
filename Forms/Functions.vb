Imports __expenseCategory = MyFinance.Objects.ExpenseCategory
Imports __expenseItem = MyFinance.Objects.ExpenseItem
Imports System.Reflection
Imports System.ComponentModel

Public Class Functions

    Sub FillCbbExpenseCategory(ByRef cbb As ComboBox, ByVal selected As UInt32, Optional ByVal textDefault As String = "")

        Dim dbExpenseCategory As New Database.ExpenseCategory
        Dim categories As New List(Of __expenseCategory)

        categories = dbExpenseCategory.Search()

        categories.Sort(Function(ec1 As __expenseCategory, ec2 As __expenseCategory)
                            Return ec1.description.CompareTo(ec2.description)
                        End Function)

        If textDefault <> "" Then categories.Insert(0, New __expenseCategory(0, textDefault))

        cbb.ValueMember = "id"
        cbb.DisplayMember = "description"
        cbb.DataSource = categories

        If selected > 0 Then
            cbb.SelectedValue = selected
        Else
            cbb.SelectedIndex = 0
        End If

    End Sub

    Sub FillCbbExpenseItem(ByRef cbb As ComboBox, ByVal selected As UInt32, Optional ByVal textDefault As String = "")

        Dim dbExpenseItem As New Database.ExpenseItem
        Dim items As New List(Of __expenseItem)

        items = dbExpenseItem.Search()

        items.Sort(Function(ei1 As __expenseItem, ei2 As __expenseItem)
                       Return ei1.description.CompareTo(ei2.description)
                   End Function)

        If textDefault <> "" Then items.Insert(0, New __expenseItem(0, textDefault))

        cbb.ValueMember = "idAndAllowMultiple"
        cbb.DisplayMember = "descriptionAndMeasure"
        cbb.DataSource = items

        If selected > 0 Then
            cbb.SelectedValue = selected & "1"
            If IsNothing(cbb.SelectedValue) Then cbb.SelectedValue = selected & "0"
        Else
            cbb.SelectedIndex = 0
        End If

    End Sub

    Sub FillCbbWithEnum(ByRef cbb As ComboBox, ByRef type As System.Type, ByVal selected As UInt32)

        Dim items As New List(Of ItemCbb)
        Dim values() As UInt32
        Dim et As [Enum]

        values = CType([Enum].GetValues(type), UInt32())
        For Each v In values
            et = [Enum].Parse(type, v)
            items.Add(New ItemCbb(v, GetEnumDescription(et)))
        Next

        items.Sort(Function(e1 As ItemCbb, e2 As ItemCbb)
                       Return e1.description.CompareTo(e2.description)
                   End Function)

        cbb.ValueMember = "value"
        cbb.DisplayMember = "description"
        cbb.DataSource = items

        If selected > 0 Then
            cbb.SelectedValue = selected.ToString
        Else
            cbb.SelectedValue = CInt(Enumerators.PaymentMethod.Cash).ToString
        End If
    End Sub

    Function GetEnumDescription(ByVal e As [Enum]) As String

        Dim fi As FieldInfo = e.GetType().GetField(e.ToString())
        Dim attr() As DescriptionAttribute

        If IsNothing(fi) Then Return ""

        attr = DirectCast(fi.GetCustomAttributes(GetType(DescriptionAttribute), False), DescriptionAttribute())

        If attr.Length > 0 Then
            Return attr(0).Description
        Else
            Return e.ToString()
        End If

    End Function

    Friend Class ItemCbb

        Property value As String
        Property description As String

        Sub New(ByVal value As String, ByVal description As String)
            Me.value = value
            Me.description = description
        End Sub

    End Class

End Class
