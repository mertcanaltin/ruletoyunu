<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Sans1Button = New System.Windows.Forms.Button()
        Me.ımageListSans = New System.Windows.Forms.ImageList(Me.components)
        Me.Sans2Button = New System.Windows.Forms.Button()
        Me.Sans3Button = New System.Windows.Forms.Button()
        Me.OynaButton = New System.Windows.Forms.Button()
        Me.StatusStripSans = New System.Windows.Forms.StatusStrip()
        Me.PuanLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HakProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStripSans.SuspendLayout()
        Me.SuspendLayout()
        '
        'Sans1Button
        '
        Me.Sans1Button.ImageIndex = 0
        Me.Sans1Button.ImageList = Me.ımageListSans
        Me.Sans1Button.Location = New System.Drawing.Point(34, 12)
        Me.Sans1Button.Name = "Sans1Button"
        Me.Sans1Button.Size = New System.Drawing.Size(75, 75)
        Me.Sans1Button.TabIndex = 0
        Me.Sans1Button.UseVisualStyleBackColor = True
        '
        'ımageListSans
        '
        Me.ımageListSans.ImageStream = CType(resources.GetObject("ımageListSans.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageListSans.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageListSans.Images.SetKeyName(0, "kiraz.png")
        Me.ımageListSans.Images.SetKeyName(1, "limon.png")
        Me.ımageListSans.Images.SetKeyName(2, "muz.png")
        '
        'Sans2Button
        '
        Me.Sans2Button.ImageIndex = 1
        Me.Sans2Button.ImageList = Me.ımageListSans
        Me.Sans2Button.Location = New System.Drawing.Point(150, 12)
        Me.Sans2Button.Name = "Sans2Button"
        Me.Sans2Button.Size = New System.Drawing.Size(75, 75)
        Me.Sans2Button.TabIndex = 1
        Me.Sans2Button.UseVisualStyleBackColor = True
        '
        'Sans3Button
        '
        Me.Sans3Button.ImageIndex = 2
        Me.Sans3Button.ImageList = Me.ımageListSans
        Me.Sans3Button.Location = New System.Drawing.Point(266, 12)
        Me.Sans3Button.Name = "Sans3Button"
        Me.Sans3Button.Size = New System.Drawing.Size(75, 75)
        Me.Sans3Button.TabIndex = 2
        Me.Sans3Button.UseVisualStyleBackColor = True
        '
        'OynaButton
        '
        Me.OynaButton.Location = New System.Drawing.Point(34, 114)
        Me.OynaButton.Name = "OynaButton"
        Me.OynaButton.Size = New System.Drawing.Size(307, 23)
        Me.OynaButton.TabIndex = 3
        Me.OynaButton.Text = "Oyna"
        Me.OynaButton.UseVisualStyleBackColor = True
        '
        'StatusStripSans
        '
        Me.StatusStripSans.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuanLabel, Me.HakProgressBar})
        Me.StatusStripSans.Location = New System.Drawing.Point(0, 317)
        Me.StatusStripSans.Name = "StatusStripSans"
        Me.StatusStripSans.Size = New System.Drawing.Size(372, 22)
        Me.StatusStripSans.TabIndex = 4
        Me.StatusStripSans.Text = "StatusStrip1"
        '
        'PuanLabel
        '
        Me.PuanLabel.Name = "PuanLabel"
        Me.PuanLabel.Size = New System.Drawing.Size(49, 17)
        Me.PuanLabel.Text = "Puan : 0"
        '
        'HakProgressBar
        '
        Me.HakProgressBar.Maximum = 5
        Me.HakProgressBar.Name = "HakProgressBar"
        Me.HakProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.HakProgressBar.Step = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 339)
        Me.Controls.Add(Me.StatusStripSans)
        Me.Controls.Add(Me.OynaButton)
        Me.Controls.Add(Me.Sans3Button)
        Me.Controls.Add(Me.Sans2Button)
        Me.Controls.Add(Me.Sans1Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStripSans.ResumeLayout(False)
        Me.StatusStripSans.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sans1Button As System.Windows.Forms.Button
    Friend WithEvents ımageListSans As System.Windows.Forms.ImageList
    Friend WithEvents Sans2Button As System.Windows.Forms.Button
    Friend WithEvents Sans3Button As System.Windows.Forms.Button
    Friend WithEvents OynaButton As System.Windows.Forms.Button
    Friend WithEvents StatusStripSans As System.Windows.Forms.StatusStrip
    Friend WithEvents PuanLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HakProgressBar As System.Windows.Forms.ToolStripProgressBar

End Class
