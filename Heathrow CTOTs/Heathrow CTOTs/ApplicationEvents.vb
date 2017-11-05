Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System
Imports System.Text
Imports Heathrow_CTOTs.Public_variables




Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ' Create Folder in Local/Tem

            My.Computer.FileSystem.CreateDirectory(folder)
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ' Delete temp folder and all it's contents once the program is closed, deletes it permanenty.
            My.Computer.FileSystem.DeleteDirectory(folder, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently)
        End Sub
    End Class
End Namespace
