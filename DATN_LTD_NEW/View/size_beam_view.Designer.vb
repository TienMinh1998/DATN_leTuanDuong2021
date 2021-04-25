<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class size_beam_view
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
        Me.gr_name = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.gr_name.SuspendLayout()
        Me.SuspendLayout()
        '
        'gr_name
        '
        Me.gr_name.Controls.Add(Me.TextBox3)
        Me.gr_name.Controls.Add(Me.Label3)
        Me.gr_name.Controls.Add(Me.TextBox2)
        Me.gr_name.Controls.Add(Me.Label2)
        Me.gr_name.Controls.Add(Me.TextBox1)
        Me.gr_name.Controls.Add(Me.Label1)
        Me.gr_name.Location = New System.Drawing.Point(12, 12)
        Me.gr_name.Name = "gr_name"
        Me.gr_name.Size = New System.Drawing.Size(269, 172)
        Me.gr_name.TabIndex = 0
        Me.gr_name.TabStop = False
        Me.gr_name.Text = "Chọn KT Dầm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(31, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Dầm"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(31, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chiều rộng (b) :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(112, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(31, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chiều Cao H : "
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(112, 121)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 20)
        Me.TextBox3.TabIndex = 1
        '
        'size_beam_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 523)
        Me.Controls.Add(Me.gr_name)
        Me.Name = "size_beam_view"
        Me.Text = "size_beam_view"
        Me.gr_name.ResumeLayout(False)
        Me.gr_name.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gr_name As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
