Imports System.IO
Imports System.Web.Optimization

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Fires when the application is started
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub

    Sub Application_Error(sender As Object, e As EventArgs)

        'Dim con As HttpContext = HttpContext.Current
        'Dim v = Server.GetLastError()

        'Dim HttpEx = TryCast(v, HttpException)
        'If HttpEx IsNot Nothing AndAlso HttpEx.GetHttpCode() = 404 Then
        '    'Invalid URL
        'Else
        '    Dim sb As StringBuilder = New StringBuilder()
        '    sb.AppendLine("Page:           " + con.Request.Url.ToString())
        '    sb.AppendLine("Error Message:  " + v.Message)
        '    sb.AppendLine("Inner Message:  " + v.InnerException.ToString())

        '    Dim fileName As String = Path.Combine(Server.MapPath("~/Logs"), DateTime.Now.ToString("ddMMyyyyhhmmss") + ".txt")
        '    File.WriteAllText(fileName, sb.ToString())
        '    'Server.Transfer("ErrorPage.aspx")
        'End If

    End Sub

End Class