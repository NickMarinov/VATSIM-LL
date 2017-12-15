Imports Heathrow_CTOTs.Public_variables
Imports System.Threading


Public Class Core_class
    Public Shared Sub GetData()
        While running = True
            If My.Computer.FileSystem.FileExists(tempFolder & "\EGLL.xml") Then
                My.Computer.FileSystem.DeleteFile(tempFolder & "\EGLL.xml")
                My.Computer.Network.DownloadFile("http://api.vateud.net/online/pilots/EGLL.xml", tempFolder & "\EGLL.xml")
            Else
                My.Computer.Network.DownloadFile("http://api.vateud.net/online/pilots/EGLL.xml", tempFolder & "\EGLL.xml")
            End If
            downloads = downloads + 1
            Thread.Sleep(60000)
        End While
    End Sub

    Public Shared Sub msgBox()
        MessageBox.Show("This is a text")
    End Sub

End Class
