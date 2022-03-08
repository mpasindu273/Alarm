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
        Me.tim = New System.Windows.Forms.Timer(Me.components)
        Me.lh = New System.Windows.Forms.Label()
        Me.lm = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ls = New System.Windows.Forms.Label()
        Me.th = New System.Windows.Forms.TextBox()
        Me.tm = New System.Windows.Forms.TextBox()
        Me.ts = New System.Windows.Forms.TextBox()
        Me.setalm = New System.Windows.Forms.Button()
        Me.clr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tim
        '
        Me.tim.Enabled = True
        Me.tim.Interval = 1000
        '
        'lh
        '
        Me.lh.AutoSize = True
        Me.lh.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lh.ForeColor = System.Drawing.Color.White
        Me.lh.Location = New System.Drawing.Point(23, 28)
        Me.lh.Name = "lh"
        Me.lh.Size = New System.Drawing.Size(106, 73)
        Me.lh.TabIndex = 3
        Me.lh.Text = "00"
        '
        'lm
        '
        Me.lm.AutoSize = True
        Me.lm.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lm.ForeColor = System.Drawing.Color.White
        Me.lm.Location = New System.Drawing.Point(133, 28)
        Me.lm.Name = "lm"
        Me.lm.Size = New System.Drawing.Size(106, 73)
        Me.lm.TabIndex = 6
        Me.lm.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(107, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 73)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(223, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'ls
        '
        Me.ls.AutoSize = True
        Me.ls.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ls.ForeColor = System.Drawing.Color.White
        Me.ls.Location = New System.Drawing.Point(241, 60)
        Me.ls.Name = "ls"
        Me.ls.Size = New System.Drawing.Size(49, 33)
        Me.ls.TabIndex = 9
        Me.ls.Text = "00"
        '
        'th
        '
        Me.th.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.th.Location = New System.Drawing.Point(29, 155)
        Me.th.MaxLength = 2
        Me.th.Name = "th"
        Me.th.Size = New System.Drawing.Size(56, 38)
        Me.th.TabIndex = 10
        Me.th.Text = "00"
        Me.th.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tm
        '
        Me.tm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm.Location = New System.Drawing.Point(120, 155)
        Me.tm.MaxLength = 2
        Me.tm.Name = "tm"
        Me.tm.Size = New System.Drawing.Size(56, 38)
        Me.tm.TabIndex = 12
        Me.tm.Text = "00"
        Me.tm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ts
        '
        Me.ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts.Location = New System.Drawing.Point(213, 155)
        Me.ts.MaxLength = 2
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(56, 38)
        Me.ts.TabIndex = 14
        Me.ts.Text = "00"
        Me.ts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'setalm
        '
        Me.setalm.BackColor = System.Drawing.Color.MidnightBlue
        Me.setalm.Font = New System.Drawing.Font("Arial Black", 8.3!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setalm.ForeColor = System.Drawing.Color.White
        Me.setalm.Location = New System.Drawing.Point(43, 230)
        Me.setalm.Name = "setalm"
        Me.setalm.Size = New System.Drawing.Size(86, 34)
        Me.setalm.TabIndex = 13
        Me.setalm.Text = "Set Alarm"
        Me.setalm.UseVisualStyleBackColor = False
        '
        'clr
        '
        Me.clr.BackColor = System.Drawing.Color.MidnightBlue
        Me.clr.Font = New System.Drawing.Font("Arial Black", 8.3!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr.ForeColor = System.Drawing.Color.White
        Me.clr.Location = New System.Drawing.Point(167, 230)
        Me.clr.MaximumSize = New System.Drawing.Size(79, 34)
        Me.clr.MinimumSize = New System.Drawing.Size(79, 34)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(79, 34)
        Me.clr.TabIndex = 14
        Me.clr.Text = "Clear"
        Me.clr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(182, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "hour"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(131, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "min"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(224, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "sec"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(43, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Set Alarm"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = ":"
        '
        'stn
        '
        Me.stn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.stn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stn.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.stn.Image = CType(resources.GetObject("stn.Image"), System.Drawing.Image)
        Me.stn.Location = New System.Drawing.Point(3, 3)
        Me.stn.Name = "stn"
        Me.stn.Size = New System.Drawing.Size(33, 31)
        Me.stn.TabIndex = 17
        Me.stn.Text = " "
        Me.stn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(300, 285)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clr)
        Me.Controls.Add(Me.setalm)
        Me.Controls.Add(Me.ts)
        Me.Controls.Add(Me.tm)
        Me.Controls.Add(Me.th)
        Me.Controls.Add(Me.ls)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lh)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(316, 324)
        Me.MinimumSize = New System.Drawing.Size(316, 324)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tim As System.Windows.Forms.Timer
    Friend WithEvents lh As System.Windows.Forms.Label
    Friend WithEvents lm As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ls As System.Windows.Forms.Label
    Friend WithEvents th As System.Windows.Forms.TextBox
    Friend WithEvents tm As System.Windows.Forms.TextBox
    Friend WithEvents ts As System.Windows.Forms.TextBox
    Friend WithEvents setalm As System.Windows.Forms.Button
    Friend WithEvents clr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents stn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
