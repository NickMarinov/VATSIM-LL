Imports Heathrow_CTOTs.Public_variables
Imports System.Threading


Public Class Core_class
    Public Shared Sub GetData()
        While running = True
            If My.Computer.FileSystem.FileExists(folder & "\EGLL.xml") Then
                My.Computer.FileSystem.DeleteFile(folder & "\EGLL.xml")
                My.Computer.Network.DownloadFile("http://api.vateud.net/online/pilots/EGLL.xml", folder & "\EGLL.xml")
            Else
                My.Computer.Network.DownloadFile("http://api.vateud.net/online/pilots/EGLL.xml", folder & "\EGLL.xml")
            End If
        End While

    End Sub

    Sub MainUpdateBackgroundThread()
        While running = True
            My.Computer.Network.DownloadFile("http://api.vateud.net/online/pilots/EGLL.xml", folder & "\EGLL.xml", False, True)
        End While
    End Sub
End Class
