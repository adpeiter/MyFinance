Imports System.Data.SQLite

Namespace Database

    Public Class ExpenseItem
        Inherits Base

        Private Const _colId As String = "id"
        Private Const _colDescription As String = "description"
        Private Const _colCategory As String = "expense_category"
        Private Const _colMeasureUnit As String = "measure_unit"
        Private Const _colAllowMyltiple As String = "allow_multiple"

        Sub Insert(ByRef expenseItem As Objects.ExpenseItem)

            Dim sqlInsert As String = String.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}) VALUES (:{1}, :{2}, :{3}, :{4})", _
                _tableExpenseItem, _colDescription, _colCategory, _colMeasureUnit, _colAllowMyltiple)
            Dim sqlSelectRowId As String = "SELECT last_insert_rowid() FROM " & _tableExpenseItem

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlInsert, bConnection)
                With expenseItem
                    AddCommandParameter(_colDescription, DbType.String, .description)
                    AddCommandParameter(_colCategory, DbType.UInt32, .category.id)
                    AddCommandParameter(_colMeasureUnit, DbType.UInt32, .measureUnit)
                    AddCommandParameter(_colAllowMyltiple, DbType.Byte, .allowMultiple)
                End With
                If bCommand.ExecuteNonQuery() Then
                    bCommand.CommandText = sqlSelectRowId
                    bDataReader = bCommand.ExecuteReader()
                    If bDataReader.Read Then expenseItem.id = bDataReader(0)
                    bDataReader.Close()
                End If
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Insert", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try

        End Sub

        Function Exists(ByRef description As String) As Boolean

            Dim sqlSelect As String = String.Format("SELECT 1 FROM {0} WHERE {1} = :{1}", _tableExpenseItem, _colDescription)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlSelect, bConnection)
                AddCommandParameter(_colDescription, DbType.String, description)
                bDataReader = bCommand.ExecuteReader()
                If bDataReader.Read Then Return True
                bDataReader.Close()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Exists", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try
            Return False

        End Function

        Function Search(Optional ByVal category As UInt32 = 0, Optional ByVal description As String = "") As List(Of Objects.ExpenseItem)

            Dim sqlSelectItems As String = "SELECT ei.id, ei.description, ei.measure_unit, ei.expense_category, ec.description, ei.allow_multiple" & _
                " FROM " & _tableExpenseItem & " ei JOIN " & _tableExpenseCategory & " ec" & _
                " ON ei.expense_category = ec.id"
            Dim items As New List(Of Objects.ExpenseItem)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(bConnection)
                If category > 0 Then
                    sqlSelectItems &= String.Format(" WHERE ei.{0} = :{0}", _colCategory)
                    AddCommandParameter(_colCategory, DbType.UInt32, category)
                End If
                If description <> String.Empty Then
                    sqlSelectItems &= If(sqlSelectItems.Contains("WHERE"), " AND", " WHERE")
                    sqlSelectItems &= String.Format(" ei.{0} LIKE :{0}", _colDescription)
                    AddCommandParameter(_colDescription, DbType.String, "%" & description & "%")
                End If
                bCommand.CommandText = sqlSelectItems
                bDataReader = bCommand.ExecuteReader()
                While bDataReader.Read
                    Dim item As New Objects.ExpenseItem()
                    With item
                        .id = bDataReader(0)
                        .description = bDataReader(1)
                        .measureUnit = bDataReader(2)
                        .category = New Objects.ExpenseCategory(bDataReader(3), bDataReader(4))
                        .allowMultiple = bDataReader(5)
                    End With
                    items.Add(item)
                End While
                bDataReader.Close()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Search", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try
            Return items

        End Function

        Sub Delete(ByVal id As UInt32)

            Dim sqlDeleteItem As String = String.Format("DELETE FROM {0} WHERE {1} = :{1}", _tableExpenseItem, _colId)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlDeleteItem, bConnection)
                AddCommandParameter(_colId, DbType.UInt32, id)
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Delete", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try

        End Sub

        Sub Update(ByVal expenseItem As Objects.ExpenseItem)

            Dim sqlUpdateDescription As String = String.Format("UPDATE {0} SET {1} = :{1}, {2} = :{2}, {3} = :{3}, {4} = :{4} WHERE {5} = :{5}", _
                _tableExpenseItem, _colDescription, _colCategory, _colMeasureUnit, _colAllowMyltiple, _colId)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlUpdateDescription, bConnection)
                With expenseItem
                    AddCommandParameter(_colDescription, DbType.String, .description)
                    AddCommandParameter(_colMeasureUnit, DbType.UInt32, .measureUnit)
                    AddCommandParameter(_colCategory, DbType.UInt32, .category.id)
                    AddCommandParameter(_colAllowMyltiple, DbType.Byte, .allowMultiple)
                    AddCommandParameter(_colId, DbType.UInt32, .id)
                End With
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Update", ex, Enumerators.Modules.Database)
                expenseItem.id = 0
            Finally
                ConnectionClose()
            End Try

        End Sub

    End Class

End Namespace