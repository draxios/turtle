Imports System.IO
Imports System.Reflection

Public Class MrLogger

    Public Shared Sub log(ByVal message As String)

        'who cares if the log fails for some reason, go on
        On Error Resume Next

        If UseLog = False Then Exit Sub

        Dim strAssemblyPath As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
        Dim logPath As String = Path.Combine(strAssemblyPath, "Log")
        If Not Directory.Exists(logPath) Then
            Directory.CreateDirectory(logPath)
        End If
        Dim logFilePath As String = Path.Combine(logPath, _
        String.Format("Log_{0}_{1}_{2}.log", DateTime.Now.Year.ToString, DateTime.Now.Month.ToString, DateTime.Now.Day.ToString))
        Using sw As New StreamWriter(logFilePath, True)
            sw.Write("[" + DateTime.Now + "] ")
            sw.WriteLine(message)
            sw.Close()
        End Using
    End Sub

End Class
