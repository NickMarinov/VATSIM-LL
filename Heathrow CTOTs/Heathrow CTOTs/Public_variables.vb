Imports System.IO

Public Class Public_variables
    Public Shared folder As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) & "\AppData\Local\Temp\Heathrow"

    Public Shared i As Integer = 1
    Public Shared running As Boolean = False

    ' Threads
    Public Shared DownloadingThread As System.Threading.Thread()
    ' Delegates
    Public Delegate Sub DelSub()

End Class
