Imports System.Data.SQLite

Namespace Database

    Public Class ExpenseCategory
        Inherits Base

        Private Const _colId As String = "id"
        Private Const _colDescription As String = "description"

        Function Insert(ByRef description As String) As UInt32

            Dim sqlInsert As String = String.Format("INSERT INTO {0} ({1}) VALUES (:{1})", _tableExpenseCategory, _colDescription)
            Dim sqlSelectRowId As String = "SELECT last_insert_rowid() FROM " & _tableExpenseCategory
            Dim insertedId As UInt32

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlInsert, bConnection)
                AddCommandParameter(_colDescription, DbType.String, description)
                If bCommand.ExecuteNonQuery() Then
                    bCommand.CommandText = sqlSelectRowId
                    bDataReader = bCommand.ExecuteReader()
                    If bDataReader.Read Then insertedId = bDataReader(0)
                    bDataReader.Close()
                End If
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Insert", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try
            Return insertedId

        End Function

        Function Exists(ByRef description As String) As Boolean

            Dim sqlSelect As String = String.Format("SELECT 1 FROM {0} WHERE {1} = :{1}", _tableExpenseCategory, _colDescription)

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

        Function Search(Optional ByVal id As UInt32 = 0, Optional ByVal description As String = "") As List(Of Objects.ExpenseCategory)

            Dim sqlSelectCategories As String = "SELECT * FROM " & _tableExpenseCategory
            Dim categories As New List(Of Objects.ExpenseCategory)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(bConnection)
                If id > 0 Then
                    sqlSelectCategories &= String.Format(" WHERE {0} LIKE :{0}", _colId)
                    AddCommandParameter(_colId, DbType.UInt32, id)
                ElseIf description <> String.Empty Then
                    sqlSelectCategories &= String.Format(" WHERE {0} LIKE :{0}", _colDescription)
                    AddCommandParameter(_colDescription, DbType.String, "%" & description & "%")
                End If
                bCommand.CommandText = sqlSelectCategories
                bDataReader = bCommand.ExecuteReader()
                While bDataReader.Read
                    Dim category As New Objects.ExpenseCategory(bDataReader(_colId), bDataReader(_colDescription))
                    categories.Add(category)
                End While
                bDataReader.Close()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Search", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try
            Return categories

        End Function

        Sub Delete(ByVal id As UInt32)

            Dim sqlDeleteCategory As String = String.Format("DELETE FROM {0} WHERE {1} = :{1}", _tableExpenseCategory, _colId)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlDeleteCategory, bConnection)
                AddCommandParameter(_colId, DbType.UInt32, id)
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseCategory.Delete", ex, Enumerators.Modules.Database)
            Finally
                ConnectionClose()
            End Try

        End Sub

        Function Update(ByVal category As Objects.ExpenseCategory) As Boolean

            Dim sqlUpdateDescription As String = String.Format("UPDATE {0} SET {1} = :{1} WHERE {2} = :{2}", _tableExpenseCategory, _colDescription, _colId)

            Try
                bConnection.Open()
                bCommand = New SQLiteCommand(sqlUpdateDescription, bConnection)
                AddCommandParameter(_colDescription, DbType.String, category.description)
                AddCommandParameter(_colId, DbType.UInt32, category.id)
                bCommand.ExecuteNonQuery()
                bConnection.Close()
            Catch ex As Exception
                bLog.Record("ExpenseItem.Update", ex, Enumerators.Modules.Database)
                Return False
            Finally
                ConnectionClose()
            End Try
            Return True

        End Function

    End Class

End Namespace