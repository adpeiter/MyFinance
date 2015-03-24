Namespace Utilities

    Public Class Log

        Private _pathErrors As String = IO.Path.Combine(IO.Directory.GetCurrentDirectory(), "errors")
        Private _thisDay As String = Now.ToString("yyyyMMdd")
        Private _functions As New Functions
        Private _sw As IO.StreamWriter

        Sub Record(ByRef msg As String)

        End Sub

        Sub Record(ByRef msg As String, ByRef ex As Exception, ByVal [module] As Enumerators.Modules)

            If Not IO.Directory.Exists(_pathErrors) Then IO.Directory.CreateDirectory(_pathErrors)
            _sw = New IO.StreamWriter(IO.Path.Combine(_pathErrors, _thisDay & ".txt"), True)
            _sw.WriteLine("Exception in: " & _functions.GetEnumDescription([module]))
            _sw.WriteLine(msg)
            _sw.WriteLine(ex.ToString)
            _sw.Close()
            _sw.Dispose()

        End Sub

    End Class

End Namespace