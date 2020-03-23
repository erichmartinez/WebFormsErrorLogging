Imports System.IO

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Dim con As HttpContext = HttpContext.Current
        Dim iZero As Integer = 0
        Dim iOne As Integer = 1

        Try
            Dim iEquals As Integer = iOne / iZero
        Catch ex As Exception

            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendLine("Page:           " + con.Request.Url.ToString())
            sb.AppendLine("Error Message:  " + ex.Message + ex.StackTrace.ToString())

            Dim fileName As String = Path.Combine(Server.MapPath("~/Logs"), DateTime.Now.ToString("ddMMyyyyhhmmss") + ".txt")
            File.WriteAllText(fileName, sb.ToString())
        End Try

    End Sub
End Class