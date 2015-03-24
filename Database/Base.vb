Imports System.Data.SQLite

Namespace Database

    Public Class Base

        Protected Const _colon As String = ":"
        Protected Const _tableExpenseCategory As String = "expense_category"
        Protected Const _tableExpenseItem As String = "expense_item"
        Protected Const _tableExpense As String = "expense"

        Protected bConnection As New SQLiteConnection(String.Format("Data Source={0}\db.sqlite;Version=3;New=True;Compress=True;", IO.Directory.GetCurrentDirectory))

        Protected Sub ConnectionClose()
            If Not Me.bConnection.State = ConnectionState.Closed Then bConnection.Close()
        End Sub

        Protected bCommand As SQLiteCommand
        Protected bTransaction As SQLiteTransaction
        Protected bDataReader As SQLiteDataReader
        Protected bLog As New Utilities.Log

        Protected Sub AddCommandParameter(ByVal name As String, ByVal type As System.Data.DbType, ByVal value As Object)
            bCommand.Parameters.Add(":" & name, type).Value = value
        End Sub

    End Class

End Namespace