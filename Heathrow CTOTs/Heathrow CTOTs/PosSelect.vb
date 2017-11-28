Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System
Imports System.Text

Public Class PosSelect
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If cmbPosSelect.Text = "EGLL_DEL" Then
            DEL.Show()
            Me.Hide()
        Else
            If cmbPosSelect.Text = "EGLL_P_GND" Then
                Planner.Show()
                Me.Close()
            Else
                If cmbPosSelect.Text = "EGLL_GND" Then GND.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class
