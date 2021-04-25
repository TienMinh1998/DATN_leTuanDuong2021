<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class diachat_view
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(diachat_view))
        Me.dgv_diachat = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_NhapEXcel = New FontAwesome.Sharp.IconButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbTrangThai = New System.Windows.Forms.ComboBox()
        Me.cbbLoaiDat = New System.Windows.Forms.ComboBox()
        Me.txtHsa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHsk = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtN30 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDoRoi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGocMS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmodun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDungTrong = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtChieuDay = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLopDat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pn_tieuDe = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_luu = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_xuat = New FontAwesome.Sharp.IconButton()
        Me.btn_xacnhan = New FontAwesome.Sharp.IconButton()
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Pn_tieuDe.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_diachat
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgv_diachat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_diachat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_diachat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_diachat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_diachat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_diachat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_diachat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_diachat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_diachat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_diachat.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_diachat.EnableHeadersVisualStyles = False
        Me.dgv_diachat.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgv_diachat.Location = New System.Drawing.Point(294, 80)
        Me.dgv_diachat.Name = "dgv_diachat"
        Me.dgv_diachat.RowHeadersVisible = False
        Me.dgv_diachat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_diachat.Size = New System.Drawing.Size(664, 356)
        Me.dgv_diachat.TabIndex = 0
        Me.dgv_diachat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_diachat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_diachat.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_diachat.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_diachat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_diachat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_diachat.ThemeStyle.HeaderStyle.Height = 59
        Me.dgv_diachat.ThemeStyle.ReadOnly = False
        Me.dgv_diachat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_diachat.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_diachat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgv_diachat.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_diachat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.dgv_diachat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.HeaderText = "Lớp Đất"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Loại Đất"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Trạng Thái"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Chiều Dày"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Dung Trọng Riêng"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Modun Đàn Hồi"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Góc Ms Trong"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Độ Rời"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sức Kháng Xuyên"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "N"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "K"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "anpha"
        Me.Column12.Name = "Column12"
        '
        'btn_NhapEXcel
        '
        Me.btn_NhapEXcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_NhapEXcel.FlatAppearance.BorderSize = 0
        Me.btn_NhapEXcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_NhapEXcel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_NhapEXcel.IconChar = FontAwesome.Sharp.IconChar.Paperclip
        Me.btn_NhapEXcel.IconColor = System.Drawing.Color.White
        Me.btn_NhapEXcel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_NhapEXcel.IconSize = 30
        Me.btn_NhapEXcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NhapEXcel.Location = New System.Drawing.Point(355, 442)
        Me.btn_NhapEXcel.Name = "btn_NhapEXcel"
        Me.btn_NhapEXcel.Size = New System.Drawing.Size(184, 44)
        Me.btn_NhapEXcel.TabIndex = 1
        Me.btn_NhapEXcel.Text = "Nhập Từ EXCEL"
        Me.btn_NhapEXcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_NhapEXcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_NhapEXcel.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbbTrangThai)
        Me.GroupBox1.Controls.Add(Me.cbbLoaiDat)
        Me.GroupBox1.Controls.Add(Me.txtHsa)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtHsk)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtN30)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtQc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDoRoi)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtGocMS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtmodun)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDungTrong)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtChieuDay)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLopDat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 356)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Liệu"
        '
        'cbbTrangThai
        '
        Me.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTrangThai.FormattingEnabled = True
        Me.cbbTrangThai.Location = New System.Drawing.Point(118, 74)
        Me.cbbTrangThai.Name = "cbbTrangThai"
        Me.cbbTrangThai.Size = New System.Drawing.Size(66, 21)
        Me.cbbTrangThai.TabIndex = 2
        '
        'cbbLoaiDat
        '
        Me.cbbLoaiDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbLoaiDat.FormattingEnabled = True
        Me.cbbLoaiDat.Items.AddRange(New Object() {"Sét", "Sét pha", "Cát pha", "Cát", "Cuội sỏi"})
        Me.cbbLoaiDat.Location = New System.Drawing.Point(118, 49)
        Me.cbbLoaiDat.Name = "cbbLoaiDat"
        Me.cbbLoaiDat.Size = New System.Drawing.Size(66, 21)
        Me.cbbLoaiDat.TabIndex = 2
        '
        'txtHsa
        '
        Me.txtHsa.Enabled = False
        Me.txtHsa.Location = New System.Drawing.Point(117, 309)
        Me.txtHsa.Name = "txtHsa"
        Me.txtHsa.Size = New System.Drawing.Size(67, 20)
        Me.txtHsa.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Hệ số alpha"
        '
        'txtHsk
        '
        Me.txtHsk.Enabled = False
        Me.txtHsk.Location = New System.Drawing.Point(117, 283)
        Me.txtHsk.Name = "txtHsk"
        Me.txtHsk.Size = New System.Drawing.Size(67, 20)
        Me.txtHsk.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Hệ số k"
        '
        'txtN30
        '
        Me.txtN30.Location = New System.Drawing.Point(117, 257)
        Me.txtN30.Name = "txtN30"
        Me.txtN30.Size = New System.Drawing.Size(67, 20)
        Me.txtN30.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Chỉ số N"
        '
        'txtQc
        '
        Me.txtQc.Location = New System.Drawing.Point(117, 231)
        Me.txtQc.Name = "txtQc"
        Me.txtQc.Size = New System.Drawing.Size(67, 20)
        Me.txtQc.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sức kháng xuyên"
        '
        'txtDoRoi
        '
        Me.txtDoRoi.Location = New System.Drawing.Point(117, 205)
        Me.txtDoRoi.Name = "txtDoRoi"
        Me.txtDoRoi.Size = New System.Drawing.Size(67, 20)
        Me.txtDoRoi.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Độ rời"
        '
        'txtGocMS
        '
        Me.txtGocMS.Location = New System.Drawing.Point(117, 179)
        Me.txtGocMS.Name = "txtGocMS"
        Me.txtGocMS.Size = New System.Drawing.Size(67, 20)
        Me.txtGocMS.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Góc ma sát trong"
        '
        'txtmodun
        '
        Me.txtmodun.Location = New System.Drawing.Point(117, 153)
        Me.txtmodun.Name = "txtmodun"
        Me.txtmodun.Size = New System.Drawing.Size(67, 20)
        Me.txtmodun.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Modun đàn hồi"
        '
        'txtDungTrong
        '
        Me.txtDungTrong.Location = New System.Drawing.Point(117, 127)
        Me.txtDungTrong.Name = "txtDungTrong"
        Me.txtDungTrong.Size = New System.Drawing.Size(67, 20)
        Me.txtDungTrong.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dung trọng riêng"
        '
        'txtChieuDay
        '
        Me.txtChieuDay.Location = New System.Drawing.Point(117, 101)
        Me.txtChieuDay.Name = "txtChieuDay"
        Me.txtChieuDay.Size = New System.Drawing.Size(67, 20)
        Me.txtChieuDay.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(190, 234)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "kN/m2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(190, 208)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "kN/m2"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(190, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(22, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "độ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(190, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "kN/m2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(190, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "kN/m3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(190, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "m"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Chiều dày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Trạng thái đất"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Loại đất"
        '
        'txtLopDat
        '
        Me.txtLopDat.Enabled = False
        Me.txtLopDat.Location = New System.Drawing.Point(117, 23)
        Me.txtLopDat.Name = "txtLopDat"
        Me.txtLopDat.Size = New System.Drawing.Size(67, 20)
        Me.txtLopDat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lớp đất"
        '
        'Pn_tieuDe
        '
        Me.Pn_tieuDe.BackColor = System.Drawing.Color.DodgerBlue
        Me.Pn_tieuDe.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Pn_tieuDe.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_tieuDe.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Pn_tieuDe.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pn_tieuDe.Location = New System.Drawing.Point(0, 0)
        Me.Pn_tieuDe.Name = "Pn_tieuDe"
        Me.Pn_tieuDe.ShadowDecoration.Parent = Me.Pn_tieuDe
        Me.Pn_tieuDe.Size = New System.Drawing.Size(970, 74)
        Me.Pn_tieuDe.TabIndex = 11
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(270, 24)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(468, 27)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "NHẬP LIỆU CÁC THÔNG SỐ CỦA ĐỊA CHẤT"
        '
        'btn_them
        '
        Me.btn_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_them.Image = CType(resources.GetObject("btn_them.Image"), System.Drawing.Image)
        Me.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_them.Location = New System.Drawing.Point(10, 442)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 44)
        Me.btn_them.TabIndex = 9
        Me.btn_them.Text = "Thêm"
        Me.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_sua.Image = CType(resources.GetObject("btn_sua.Image"), System.Drawing.Image)
        Me.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sua.Location = New System.Drawing.Point(91, 442)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 44)
        Me.btn_sua.TabIndex = 8
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_luu
        '
        Me.btn_luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_luu.Image = CType(resources.GetObject("btn_luu.Image"), System.Drawing.Image)
        Me.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_luu.Location = New System.Drawing.Point(172, 442)
        Me.btn_luu.Name = "btn_luu"
        Me.btn_luu.Size = New System.Drawing.Size(75, 44)
        Me.btn_luu.TabIndex = 7
        Me.btn_luu.Text = "Lưu"
        Me.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_luu.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btn_xoa.Image = CType(resources.GetObject("btn_xoa.Image"), System.Drawing.Image)
        Me.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xoa.Location = New System.Drawing.Point(253, 442)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 44)
        Me.btn_xoa.TabIndex = 6
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_xuat
        '
        Me.btn_xuat.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_xuat.FlatAppearance.BorderSize = 0
        Me.btn_xuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_xuat.IconChar = FontAwesome.Sharp.IconChar.Paste
        Me.btn_xuat.IconColor = System.Drawing.Color.White
        Me.btn_xuat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_xuat.IconSize = 30
        Me.btn_xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xuat.Location = New System.Drawing.Point(545, 442)
        Me.btn_xuat.Name = "btn_xuat"
        Me.btn_xuat.Size = New System.Drawing.Size(204, 44)
        Me.btn_xuat.TabIndex = 1
        Me.btn_xuat.Text = "Xuất Dữ liệu đã thêm"
        Me.btn_xuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_xuat.UseVisualStyleBackColor = False
        '
        'btn_xacnhan
        '
        Me.btn_xacnhan.BackColor = System.Drawing.Color.Gray
        Me.btn_xacnhan.FlatAppearance.BorderSize = 0
        Me.btn_xacnhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xacnhan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_xacnhan.IconChar = FontAwesome.Sharp.IconChar.Paste
        Me.btn_xacnhan.IconColor = System.Drawing.Color.White
        Me.btn_xacnhan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_xacnhan.IconSize = 30
        Me.btn_xacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xacnhan.Location = New System.Drawing.Point(754, 443)
        Me.btn_xacnhan.Name = "btn_xacnhan"
        Me.btn_xacnhan.Size = New System.Drawing.Size(204, 44)
        Me.btn_xacnhan.TabIndex = 1
        Me.btn_xacnhan.Text = "Xác nhận để tính toán"
        Me.btn_xacnhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_xacnhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_xacnhan.UseVisualStyleBackColor = False
        '
        'diachat_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 490)
        Me.Controls.Add(Me.Pn_tieuDe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_luu)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_them)
        Me.Controls.Add(Me.btn_xacnhan)
        Me.Controls.Add(Me.btn_xuat)
        Me.Controls.Add(Me.btn_NhapEXcel)
        Me.Controls.Add(Me.dgv_diachat)
        Me.Name = "diachat_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập thông số của địa chất"
        CType(Me.dgv_diachat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Pn_tieuDe.ResumeLayout(False)
        Me.Pn_tieuDe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_diachat As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents btn_NhapEXcel As FontAwesome.Sharp.IconButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbbTrangThai As ComboBox
    Friend WithEvents cbbLoaiDat As ComboBox
    Friend WithEvents txtHsa As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHsk As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtN30 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQc As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDoRoi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGocMS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmodun As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDungTrong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtChieuDay As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLopDat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Pn_tieuDe As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_them As Button
    Friend WithEvents btn_sua As Button
    Friend WithEvents btn_luu As Button
    Friend WithEvents btn_xoa As Button
    Friend WithEvents btn_xuat As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_xacnhan As FontAwesome.Sharp.IconButton
End Class
