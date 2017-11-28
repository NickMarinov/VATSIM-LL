<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPosSelect = New System.Windows.Forms.ComboBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please select the lowest position that you are covering."
        '
        'cmbPosSelect
        '
        Me.cmbPosSelect.FormattingEnabled = True
        Me.cmbPosSelect.Items.AddRange(New Object() {"OBS", "EGLL_DEL", "EGLL_P_GND", "EGLL_GND (GMC 1/2/3)"})
        Me.cmbPosSelect.Location = New System.Drawing.Point(12, 56)
        Me.cmbPosSelect.Name = "cmbPosSelect"
        Me.cmbPosSelect.Size = New System.Drawing.Size(263, 21)
        Me.cmbPosSelect.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(108, 83)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'PosSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(293, 118)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cmbPosSelect)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PosSelect"
        Me.Text = "Position Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPosSelect As ComboBox
    Friend WithEvents btnSelect As Button
End Class
