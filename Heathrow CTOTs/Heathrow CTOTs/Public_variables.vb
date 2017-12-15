Imports System.IO
Imports System.Threading
Imports System.Xml
Imports System


Public Class Public_variables
    Public Shared ReadOnly tempFolder As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) & "\AppData\Local\Temp\Heathrow"

    Public Shared loadingError As String = "Error Loading Files!"

    Public Shared downloads As Integer = 0
    Public Shared i As Integer = 1
    Public Shared running As Boolean = False
    Public Shared position As String

    ' XML Stuff
    Public Shared vatsimData As XmlDocument = New XmlDocument



    ' Threads
    Public Shared DownloadingThread As Thread
    ' Delegates

End Class
