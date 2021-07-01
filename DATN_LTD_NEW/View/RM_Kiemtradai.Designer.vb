<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RM_Kiemtradai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RM_Kiemtradai))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtkiemtrachocthung = New System.Windows.Forms.Label()
        Me.txtPct = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPcct = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtkiemtradamthung = New System.Windows.Forms.Label()
        Me.txtPdt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPcdt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_tieptuc = New System.Windows.Forms.Button()
        Me.btn_kiemtra = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtkiemtrachocthung)
        Me.GroupBox2.Controls.Add(Me.txtPct)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPcct)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(598, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 257)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kiểm Tra Cọc Chọc Thủng"
        '
        'txtkiemtrachocthung
        '
        Me.txtkiemtrachocthung.AutoSize = True
        Me.txtkiemtrachocthung.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtkiemtrachocthung.ForeColor = System.Drawing.Color.Blue
        Me.txtkiemtrachocthung.Location = New System.Drawing.Point(209, 172)
        Me.txtkiemtrachocthung.Name = "txtkiemtrachocthung"
        Me.txtkiemtrachocthung.Size = New System.Drawing.Size(55, 14)
        Me.txtkiemtrachocthung.TabIndex = 2
        Me.txtkiemtrachocthung.Text = "Label11"
        Me.txtkiemtrachocthung.Visible = False
        '
        'txtPct
        '
        Me.txtPct.Enabled = False
        Me.txtPct.Location = New System.Drawing.Point(260, 100)
        Me.txtPct.Name = "txtPct"
        Me.txtPct.Size = New System.Drawing.Size(139, 29)
        Me.txtPct.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Lực chọc thủng:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Kết quả kiểm tra:"
        '
        'txtPcct
        '
        Me.txtPcct.Enabled = False
        Me.txtPcct.Location = New System.Drawing.Point(260, 58)
        Me.txtPcct.Name = "txtPcct"
        Me.txtPcct.Size = New System.Drawing.Size(139, 29)
        Me.txtPcct.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(434, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "kN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(423, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "kN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Lực chống chọc thủng:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtkiemtradamthung)
        Me.GroupBox1.Controls.Add(Me.txtPdt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPcdt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(101, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 257)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kiểm Tra Cột Đâm Thủng"
        '
        'txtkiemtradamthung
        '
        Me.txtkiemtradamthung.AutoSize = True
        Me.txtkiemtradamthung.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtkiemtradamthung.ForeColor = System.Drawing.Color.Blue
        Me.txtkiemtradamthung.Location = New System.Drawing.Point(179, 179)
        Me.txtkiemtradamthung.Name = "txtkiemtradamthung"
        Me.txtkiemtradamthung.Size = New System.Drawing.Size(55, 14)
        Me.txtkiemtradamthung.TabIndex = 2
        Me.txtkiemtradamthung.Text = "Label11"
        Me.txtkiemtradamthung.Visible = False
        '
        'txtPdt
        '
        Me.txtPdt.Enabled = False
        Me.txtPdt.Location = New System.Drawing.Point(236, 103)
        Me.txtPdt.Name = "txtPdt"
        Me.txtPdt.Size = New System.Drawing.Size(142, 29)
        Me.txtPdt.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Kết quả kiểm tra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lực đâm thủng:"
        '
        'txtPcdt
        '
        Me.txtPcdt.Enabled = False
        Me.txtPcdt.Location = New System.Drawing.Point(236, 58)
        Me.txtPcdt.Name = "txtPcdt"
        Me.txtPcdt.Size = New System.Drawing.Size(142, 29)
        Me.txtPcdt.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "kN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(422, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "kN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Lực chống đâm thủng:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(29, 24)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(454, 27)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "KIỂM TRA CƯỜNG ĐỘ TRÊN TD NGHIÊNG"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Panel1.Controls.Add(Me.btn_tieptuc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1215, 74)
        Me.Panel1.TabIndex = 14
        '
        'btn_tieptuc
        '
        Me.btn_tieptuc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_tieptuc.Image = Global.DATN_LTD_NEW.My.Resources.Resources.Actions_go_next_icon
        Me.btn_tieptuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_tieptuc.Location = New System.Drawing.Point(1049, 12)
        Me.btn_tieptuc.Name = "btn_tieptuc"
        Me.btn_tieptuc.Size = New System.Drawing.Size(154, 50)
        Me.btn_tieptuc.TabIndex = 7
        Me.btn_tieptuc.Text = "Kiểm tra cọc"
        Me.btn_tieptuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_tieptuc.UseVisualStyleBackColor = True
        '
        'btn_kiemtra
        '
        Me.btn_kiemtra.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_kiemtra.Image = CType(resources.GetObject("btn_kiemtra.Image"), System.Drawing.Image)
        Me.btn_kiemtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_kiemtra.Location = New System.Drawing.Point(553, 422)
        Me.btn_kiemtra.Name = "btn_kiemtra"
        Me.btn_kiemtra.Size = New System.Drawing.Size(96, 38)
        Me.btn_kiemtra.TabIndex = 8
        Me.btn_kiemtra.Text = "Kiểm Tra"
        Me.btn_kiemtra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_kiemtra.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.DATN_LTD_NEW.My.Resources.Resources.image_asset1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1215, 518)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'RM_Kiemtradai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_kiemtra)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RM_Kiemtradai"
        Me.Text = "Form2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_tieptuc As Button
    Friend WithEvents btn_kiemtra As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtkiemtrachocthung As Label
    Friend WithEvents txtPct As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPcct As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtkiemtradamthung As Label
    Friend WithEvents txtPdt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPcdt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Panel1 As Panel
End Class
