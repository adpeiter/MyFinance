Imports System.Data.SQLite

Namespace Database

    Public Class Expense
        Inherits Base

        Private Const _colId As String = "id"
        Private Const _colPaymentMethod As String = "payment_method"
        Private Const _colItem As String = "item"
        Private Const _colQuantity As String = "quantity"
        Private Const _colMultiple As String = "multiple"
        Private Const _colValue As String = "value"
        Private Const _colIsUnitPrice As String = "is_unit_price"
        Private Const _colPortions As String = "portions"
        Private Const _colObservation As String = "observation"
        Private Const _colDate As String = "date"
        Private Const _colExtern As String = "extern"

        Sub Insert(ByRef expense As Objects.Expense)

            Dim sqlInsert As String = String.Format( _
                "INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}) VALUES (:{1}, :{2}, :{3}, :{4}, :{5}, :{6}, :{7}, :{8}, :{9}, :{10})", _
                _tableExpense, _colPaymentMethod, _colItem, _colQuantity, _colMultiple, _colValue, _colIsUnitPrice, _colPortions, _colObservation, _colDate, _colExtern)
            Dim sqlSelectRowId As String = "SELECT last_insert_rowid() FROM " & _tableExpense

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlInsert, bConnection)
                With expense
                    AddCommandParameter(_colPaymentMethod, DbType.UInt32, .paymentMethod)
                    AddCommandParameter(_colItem, DbType.UInt32, .item.id)
                    AddCommandParameter(_colQuantity, DbType.Decimal, .quantity)
                    AddCommandParameter(_colMultiple, DbType.UInt32, .multiple)
                    AddCommandParameter(_colValue, DbType.Decimal, .value)
                    AddCommandParameter(_colIsUnitPrice, DbType.Byte, .isUnitPrice)
                    AddCommandParameter(_colPortions, DbType.Byte, .portions)
                    AddCommandParameter(_colObservation, DbType.String, .observation)
                    AddCommandParameter(_colDate, DbType.String, .[date].ToString("yyyy-MM-dd"))
                    AddCommandParameter(_colExtern, DbType.Byte, .external)
                End With
                If bCommand.ExecuteNonQuery() Then
                    bCommand.CommandText = sqlSelectRowId
                    bDataReader = bCommand.ExecuteReader()
                    If bDataReader.Read Then expense.id = bDataReader(0)
                    bDataReader.Close()
                End If
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("Expense.Insert", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try

        End Sub

        Function Search(ByVal d1 As Date, ByVal d2 As Date, Optional ByVal payment As Enumerators.PaymentMethod = 0, Optional ByVal item As UInt32 = 0, _
            Optional ByVal category As UInt32 = 0) _
        As List(Of Objects.Expense)

            Dim sqlSelectExpense As String = "SELECT e.id id, e.date date, e.is_unit_price is_unit_price, e.item itemid, ei.description itemdescription," & _
                " ei.expense_category expense_category, ec.description categorydescription, e.quantity quantity, e.multiple multiple, e.observation observation," & _
                " e.payment_method payment_method, e.value value, e.portions portions, ei.measure_unit measure_unit, ei.allow_multiple allow_multiple," & _
                " e.extern extern FROM expense e JOIN expense_item ei JOIN expense_category ec" & _
                " ON e.item = ei.id AND ei.expense_category = ec.id"
            Dim expenses As New List(Of Objects.Expense)
            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(bConnection)
                If payment > 0 Then
                    sqlSelectExpense &= String.Format(" AND e.{0} = :{0}", _colPaymentMethod)
                    AddCommandParameter(_colPaymentMethod, DbType.UInt32, category)
                End If
                If item > 0 Then
                    sqlSelectExpense &= String.Format(" AND e.{0} = :{0}", _colItem)
                    AddCommandParameter(_colItem, DbType.UInt32, item)
                End If
                If category > 0 Then
                    sqlSelectExpense &= " AND ec.id = :category"
                    AddCommandParameter("category", DbType.UInt32, category)
                End If
                If d1 <> Utilities.Consts.noDate AndAlso d2 <> Utilities.Consts.noDate Then
                    sqlSelectExpense &= " AND strftime('%s', e.date) BETWEEN strftime('%s', :d1) AND strftime('%s', :d2)"
                    AddCommandParameter("d1", DbType.Date, d1)
                    AddCommandParameter("d2", DbType.Date, d2)
                End If
                sqlSelectExpense &= "ORDER BY e.date, ei.description"
                bCommand.CommandText = sqlSelectExpense
                bDataReader = bCommand.ExecuteReader()
                While bDataReader.Read
                    Dim exp As New Objects.Expense()
                    With exp
                        .date = bDataReader("date")
                        .id = bDataReader("id")
                        .isUnitPrice = bDataReader("is_unit_price")
                        .item = New Objects.ExpenseItem(bDataReader("itemid"), bDataReader("itemdescription"))
                        .item.category = New Objects.ExpenseCategory(bDataReader("expense_category"), bDataReader("categorydescription"))
                        .item.measureUnit = bDataReader("measure_unit")
                        .item.allowMultiple = bDataReader("allow_multiple")
                        .quantity = bDataReader("quantity")
                        .external = bDataReader("extern")
                        .observation = ""
                        .paymentMethod = bDataReader("payment_method")
                        .portions = bDataReader("portions")
                        .multiple = bDataReader("multiple")
                        .value = bDataReader("value")
                    End With
                    expenses.Add(exp)
                End While
                bDataReader.Close()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("Expense.Search2", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try
            Return expenses

        End Function

        Sub Delete(ByVal id As UInt32)

            Dim sqlDeleteExpense As String = String.Format("DELETE FROM {0} WHERE {1} = :{1}", _tableExpense, _colId)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlDeleteExpense, bConnection)
                AddCommandParameter(_colId, DbType.UInt32, id)
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("Expense.Delete", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try

        End Sub

        Sub DeleteAllOfItem(ByVal item As UInt32)

            Dim sqlDeleteExpense As String = String.Format("DELETE FROM {0} WHERE {1} = :{1}", _tableExpense, _colItem)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlDeleteExpense, bConnection)
                AddCommandParameter(_colItem, DbType.UInt32, item)
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("Expense.DeleteAllOfItem", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try

        End Sub

        Sub Update(ByVal expense As Objects.Expense)

            Dim sqlUpdateExpense As String = String.Format( _
                "UPDATE {0} SET {1} = :{1}, {2} = :{2}, {3} = :{3}, {4} = :{4}, {5} = :{5}, {6} = :{6}, {7} = :{7}, {8} = :{8}, {9} = :{9}" & _
                " WHERE {10} = :{10}", _tableExpenseItem, _colPaymentMethod, _colItem, _colQuantity, _colMultiple, _colValue, _colIsUnitPrice, _
                _colPortions, _colObservation, _colExtern, _colId)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlUpdateExpense, bConnection)
                With expense
                    AddCommandParameter(_colPaymentMethod, DbType.UInt32, .paymentMethod)
                    AddCommandParameter(_colItem, DbType.UInt32, .item.id)
                    AddCommandParameter(_colValue, DbType.UInt32, .multiple)
                    AddCommandParameter(_colQuantity, DbType.Decimal, .quantity)
                    AddCommandParameter(_colValue, DbType.Decimal, .value)
                    AddCommandParameter(_colIsUnitPrice, DbType.Byte, .isUnitPrice)
                    AddCommandParameter(_colQuantity, DbType.Byte, .portions)
                    AddCommandParameter(_colQuantity, DbType.String, .observation)
                    AddCommandParameter(_colExtern, DbType.Byte, .external)
                    AddCommandParameter(_colId, DbType.UInt32, .id)
                End With
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("Expense.Update", ex, Enumerators.Modules.Database)
                expense.id = 0
            Finally
                ConnectionClose()
            End Try

        End Sub

    End Class

End Namespace