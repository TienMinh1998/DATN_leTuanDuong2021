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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_idid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_chieudai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_h = New System.Windows.Forms.TextBox()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowCustomTheming = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.dgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dgv.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv.CurrentTheme.Name = Nothing
        Me.dgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.dgv.HeaderBgColor = System.Drawing.Color.Empty
        Me.dgv.HeaderForeColor = System.Drawing.Color.White
        Me.dgv.Location = New System.Drawing.Point(236, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 40
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(561, 297)
        Me.dgv.TabIndex = 0
        Me.dgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Chiều Dài"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "B"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "H"
        Me.Column4.Name = "Column4"
        '
        'grbox
        '
        Me.grbox.Controls.Add(Me.btn_xoa)
        Me.grbox.Controls.Add(Me.btn_sua)
        Me.grbox.Controls.Add(Me.btn_luu)
        Me.grbox.Controls.Add(Me.btn_them)
        Me.grbox.Controls.Add(Me.txt_h)
        Me.grbox.Controls.Add(Me.Label4)
        Me.grbox.Controls.Add(Me.txt_b)
        Me.grbox.Controls.Add(Me.Label3)
        Me.grbox.Controls.Add(Me.txt_chieudai)
        Me.grbox.Controls.Add(Me.Label2)
        Me.grbox.Controls.Add(Me.txt_idid)
        Me.grbox.Controls.Add(Me.Label1)
        Me.grbox.Location = New System.Drawing.Point(8, 16)
        Me.grbox.Name = "grbox"
        Me.grbox.Size = New System.Drawing.Size(222, 293)
        Me.grbox.TabIndex = 1
        Me.grbox.TabStop = False
        Me.grbox.Text = "Nhập Liệu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID : "
        '
        'txt_idid
        '
        Me.txt_idid.Location = New System.Drawing.Point(101, 44)
        Me.txt_idid.Name = "txt_idid"
        Me.txt_idid.Size = New System.Drawing.Size(100, 20)
        Me.txt_idid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "chieu dai"
        '
        'txt_chieudai
        '
        Me.txt_chieudai.Location = New System.Drawing.Point(101, 70)
        Me.txt_chieudai.Name = "txt_chieudai"
        Me.txt_chieudai.Size = New System.Drawing.Size(100, 20)
        Me.txt_chieudai.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "b"
        '
        'txt_b
        '
        Me.txt_b.Location = New System.Drawing.Point(101, 96)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.Size = New System.Drawing.Size(100, 20)
        Me.txt_b.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "H"
        '
        'txt_h
        '
        Me.txt_h.Location = New System.Drawing.Point(101, 122)
        Me.txt_h.Name = "txt_h"
        Me.txt_h.Size = New System.Drawing.Size(100, 20)
        Me.txt_h.TabIndex = 1
        '
        'btn_them
        '
        Me.btn_them.Location = New System.Drawing.Point(14, 159)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(88, 32)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Location = New System.Drawing.Point(113, 159)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(88, 32)
        Me.btn_sua.TabIndex = 2
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Location = New System.Drawing.Point(14, 197)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(88, 32)
        Me.btn_xoa.TabIndex = 2
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_luu
        '
        Me.btn_luu.Location = New System.Drawing.Point(113, 197)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(88, 32)
        Me.btn_luu.TabIndex = 2
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 78)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nguyễn Minh Tiến", "Lê TUấn Dương"})
        Me.ComboBox1.Location = New System.Drawing.Point(35, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grbox)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbox.ResumeLayout(False)
        Me.grbox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents grbox As GroupBox
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_luu As Button
    Friend WithEvents btn_them As Button
    Friend WithEvents txt_h As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_b As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_chieudai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
