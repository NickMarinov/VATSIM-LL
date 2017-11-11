Imports System.IO
Imports System.Threading


Public Class Public_variables
    Public Shared folder As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) & "\AppData\Local\Temp\Heathrow"

    Public Shared downloads As Integer = 0
    Public Shared i As Integer = 1
    Public Shared running As Boolean = False

    ' Threads
    Public Shared DownloadingThread As Thread
    ' Delegates

End Class
