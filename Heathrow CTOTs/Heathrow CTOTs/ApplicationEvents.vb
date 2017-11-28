Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports Heathrow_CTOTs.Core_class
Imports Heathrow_CTOTs.Public_variables
Imports System.Threading



Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ' Set the running status of the program to true
            running = True
            ' CreateObject folder  in Local/Tem
            Directory.CreateDirectory(folder)
            If Directory.Exists(folder) Then
            Else
                Directory.CreateDirectory(folder)
            End If

            'Starts the data download thread
            DownloadingThread = New Thread(AddressOf GetData) With {
                .IsBackground = True
            }
            DownloadingThread.Start()

        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ' Delete temp folder and all it's contents once the program is closed, deletes it permanenty.
            Directory.Delete(folder, True)
            ' Set the running status of the program to false
            running = False
        End Sub
    End Class
End Namespace
