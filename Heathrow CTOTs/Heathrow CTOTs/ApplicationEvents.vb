Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System
Imports System.Text



Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ' Create Temp Folder
            Dim folder As String = Path.Combine(Path.GetTempPath, Path.GetRandomFileName)
            Do While Directory.Exists(folder) Or File.Exists(folder)
                folder = Path.Combine(Path.GetTempPath, Path.GetRandomFileName)
            Loop

            ' Create a file in the Temp Folder
            'create or override the file
            Dim fs As FileStream = File.Create(path:=folder)

            ' add text to the file
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is some text in the file.")
            fs.Write(info, 0, info.Length)
            fs.Close()
        End Sub

    End Class
End Namespace
