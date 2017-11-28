Imports System.IO
Imports System.Threading
Imports System.Xml


Public Class Public_variables
    Public Shared ReadOnly folder As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) & "\AppData\Local\Temp\Heathrow"

    Public Shared downloads As Integer = 0
    Public Shared i As Integer = 1
    Public Shared running As Boolean = False

    'Public Shared ReadOnly VatsimData As XDocument = XDocument.Load(folder & "\EGLL.xml")

    ' Threads
    Public Shared DownloadingThread As Thread
    ' Delegates

End Class
