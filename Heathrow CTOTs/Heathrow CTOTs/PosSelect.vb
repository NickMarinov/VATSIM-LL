Imports Heathrow_CTOTs.Public_variables

Public Class PosSelect
    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If cmbPosSelect.Text = "EGLL_DEL" Then
            position = "del"
            DEL.Show()
            Me.Hide()
        Else
            If cmbPosSelect.Text = "EGLL_P_GND" Then
                position = "planner"
                Planner.Show()
                Me.Close()
            Else
                If cmbPosSelect.Text = "EGLL_GND" Then
                    position = "gnd"
                    GND.Show()
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class
