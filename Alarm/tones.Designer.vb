<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tones
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.setmusic = New System.Windows.Forms.Button()
        Me.bk2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(100, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tones"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Black
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Bookman Old Style", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(-11, 74)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(315, 30)
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "Ring"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Black
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Bookman Old Style", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(-11, 110)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(315, 28)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "Better"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Black
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Bookman Old Style", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(-11, 144)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(315, 30)
        Me.btn3.TabIndex = 6
        Me.btn3.Text = "Nightwish"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Black
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Bookman Old Style", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(-11, 180)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(315, 30)
        Me.btn4.TabIndex = 9
        Me.btn4.Text = "Jonas Blues"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'setmusic
        '
        Me.setmusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.setmusic.Image = Global.Alarm.My.Resources.Resources.rightsign
        Me.setmusic.Location = New System.Drawing.Point(239, 242)
        Me.setmusic.Name = "setmusic"
        Me.setmusic.Size = New System.Drawing.Size(49, 31)
        Me.setmusic.TabIndex = 10
        Me.setmusic.UseVisualStyleBackColor = True
        '
        'bk2
        '
        Me.bk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bk2.Image = Global.Alarm.My.Resources.Resources.bk
        Me.bk2.Location = New System.Drawing.Point(12, 242)
        Me.bk2.Name = "bk2"
        Me.bk2.Size = New System.Drawing.Size(49, 31)
        Me.bk2.TabIndex = 8
        Me.bk2.UseVisualStyleBackColor = True
        '
        'tones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(300, 285)
        Me.Controls.Add(Me.setmusic)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.bk2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(316, 324)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(316, 324)
        Me.Name = "tones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents bk2 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents setmusic As System.Windows.Forms.Button
End Class
