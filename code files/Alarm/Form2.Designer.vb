<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.almtone = New System.Windows.Forms.Button()
        Me.qit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'almtone
        '
        Me.almtone.BackColor = System.Drawing.Color.Black
        Me.almtone.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.almtone.ForeColor = System.Drawing.Color.White
        Me.almtone.Location = New System.Drawing.Point(-4, 97)
        Me.almtone.Name = "almtone"
        Me.almtone.Size = New System.Drawing.Size(306, 39)
        Me.almtone.TabIndex = 0
        Me.almtone.Text = "Change Alarm Tone"
        Me.almtone.UseVisualStyleBackColor = False
        '
        'qit
        '
        Me.qit.BackColor = System.Drawing.Color.Black
        Me.qit.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qit.ForeColor = System.Drawing.Color.White
        Me.qit.Location = New System.Drawing.Point(-4, 160)
        Me.qit.Name = "qit"
        Me.qit.Size = New System.Drawing.Size(306, 39)
        Me.qit.TabIndex = 1
        Me.qit.Text = " Exit App"
        Me.qit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(87, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Settings"
        '
        'bk
        '
        Me.bk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bk.Image = Global.Alarm.My.Resources.Resources.bk
        Me.bk.Location = New System.Drawing.Point(12, 242)
        Me.bk.Name = "bk"
        Me.bk.Size = New System.Drawing.Size(49, 31)
        Me.bk.TabIndex = 3
        Me.bk.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(300, 285)
        Me.Controls.Add(Me.bk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.qit)
        Me.Controls.Add(Me.almtone)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(316, 324)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(316, 324)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents almtone As System.Windows.Forms.Button
    Friend WithEvents qit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bk As System.Windows.Forms.Button
End Class
