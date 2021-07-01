Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_diachat = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_chonvatlieu = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_nhapnoiluc = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
        Me.btn_nhaplieucoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_gioithieu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_botricoc = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_TinhThepdai = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_kiemtracoc = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_dulieudai = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.BarButtonItem1, Me.btn_diachat, Me.btn_chonvatlieu, Me.btn_nhapnoiluc, Me.BarCheckItem1, Me.BarCheckItem2, Me.btn_nhaplieucoc, Me.btn_gioithieu, Me.BarButtonItem2, Me.BarButtonItem3, Me.btn_botricoc, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.btn_TinhThepdai, Me.BarButtonItem10, Me.btn_kiemtracoc, Me.BarButtonItem12, Me.BarButtonItem13, Me.btn_dulieudai, Me.BarButtonItem14})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 25
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.RibbonPage3})
        Me.ribbonControl1.Size = New System.Drawing.Size(1231, 162)
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.ribbonControl1
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btn_diachat
        '
        Me.btn_diachat.Caption = "Nhập Thông số địa chất"
        Me.btn_diachat.Id = 2
        Me.btn_diachat.ImageOptions.SvgImage = CType(resources.GetObject("btn_diachat.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_diachat.Name = "btn_diachat"
        Me.btn_diachat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_chonvatlieu
        '
        Me.btn_chonvatlieu.Caption = "Chọn Vật Liệu"
        Me.btn_chonvatlieu.Id = 3
        Me.btn_chonvatlieu.ImageOptions.Image = Global.DATN_LTD_NEW.My.Resources.Resources.icons8_steel_ore_96
        Me.btn_chonvatlieu.Name = "btn_chonvatlieu"
        Me.btn_chonvatlieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_nhapnoiluc
        '
        Me.btn_nhapnoiluc.Caption = "Nhập Nội Lực"
        Me.btn_nhapnoiluc.Id = 4
        Me.btn_nhapnoiluc.ImageOptions.Image = CType(resources.GetObject("btn_nhapnoiluc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_nhapnoiluc.Name = "btn_nhapnoiluc"
        Me.btn_nhapnoiluc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Thử Công"
        Me.BarCheckItem1.Id = 5
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarCheckItem2
        '
        Me.BarCheckItem2.Caption = "Tự Động"
        Me.BarCheckItem2.Id = 6
        Me.BarCheckItem2.Name = "BarCheckItem2"
        '
        'btn_nhaplieucoc
        '
        Me.btn_nhaplieucoc.Caption = "Nhập dữ liệu Cho Cọc"
        Me.btn_nhaplieucoc.Id = 7
        Me.btn_nhaplieucoc.ImageOptions.SvgImage = CType(resources.GetObject("btn_nhaplieucoc.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_nhaplieucoc.Name = "btn_nhaplieucoc"
        Me.btn_nhaplieucoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_gioithieu
        '
        Me.btn_gioithieu.Caption = "Giới Thiệu Phần Mềm"
        Me.btn_gioithieu.Id = 8
        Me.btn_gioithieu.ImageOptions.Image = CType(resources.GetObject("btn_gioithieu.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_gioithieu.Name = "btn_gioithieu"
        Me.btn_gioithieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Nhập Dữ liệu cho đài"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Hướng Dẫn Nhập Liệu"
        Me.BarButtonItem3.Id = 10
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_botricoc
        '
        Me.btn_botricoc.Caption = "Bố Trí Cọc và kiểm tra"
        Me.btn_botricoc.Id = 12
        Me.btn_botricoc.ImageOptions.SvgImage = CType(resources.GetObject("btn_botricoc.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_botricoc.Name = "btn_botricoc"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Thiết Kế Đài"
        Me.BarButtonItem4.Id = 13
        Me.BarButtonItem4.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Thiết Kế Cọc"
        Me.BarButtonItem5.Id = 14
        Me.BarButtonItem5.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Xuất Bản vẽ"
        Me.BarButtonItem6.Id = 15
        Me.BarButtonItem6.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Vẽ Lên Model"
        Me.BarButtonItem7.Id = 16
        Me.BarButtonItem7.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kiểm Tra"
        Me.BarButtonItem8.Id = 17
        Me.BarButtonItem8.ImageOptions.Image = CType(resources.GetObject("BarButtonItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem8.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem8.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        Me.BarButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_TinhThepdai
        '
        Me.btn_TinhThepdai.Caption = "Tính Thép"
        Me.btn_TinhThepdai.Id = 18
        Me.btn_TinhThepdai.ImageOptions.Image = CType(resources.GetObject("btn_TinhThepdai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_TinhThepdai.ImageOptions.LargeImage = CType(resources.GetObject("btn_TinhThepdai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_TinhThepdai.Name = "btn_TinhThepdai"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Vẽ Đài"
        Me.BarButtonItem10.Id = 19
        Me.BarButtonItem10.ImageOptions.Image = CType(resources.GetObject("BarButtonItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem10.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem10.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'btn_kiemtracoc
        '
        Me.btn_kiemtracoc.Caption = "Kiểm Tra Cọc"
        Me.btn_kiemtracoc.Id = 20
        Me.btn_kiemtracoc.ImageOptions.SvgImage = CType(resources.GetObject("btn_kiemtracoc.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_kiemtracoc.Name = "btn_kiemtracoc"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Vẽ Cọc"
        Me.BarButtonItem12.Id = 21
        Me.BarButtonItem12.ImageOptions.Image = CType(resources.GetObject("BarButtonItem12.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        Me.BarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Xuất Bản Vẽ"
        Me.BarButtonItem13.Id = 22
        Me.BarButtonItem13.ImageOptions.Image = CType(resources.GetObject("BarButtonItem13.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        Me.BarButtonItem13.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_dulieudai
        '
        Me.btn_dulieudai.Caption = "Dữ Liệu Đài Móng"
        Me.btn_dulieudai.Id = 23
        Me.btn_dulieudai.ImageOptions.SvgImage = CType(resources.GetObject("btn_dulieudai.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_dulieudai.Name = "btn_dulieudai"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Kiểm Tra Đài"
        Me.BarButtonItem14.Id = 24
        Me.BarButtonItem14.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem14.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.ImageOptions.SvgImage = CType(resources.GetObject("ribbonPage1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Thông Số Đầu Vào"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btn_diachat)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ImageOptions.Image = CType(resources.GetObject("RibbonPageGroup2.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_chonvatlieu)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_dulieudai)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_nhaplieucoc)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btn_nhapnoiluc)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.ImageOptions.SvgImage = CType(resources.GetObject("RibbonPage2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Thiết Kế Đài"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_botricoc)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem14)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btn_TinhThepdai)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Tính Toán "
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RibbonPage3.ImageOptions.SvgImage = CType(resources.GetObject("RibbonPage3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Thiết Kế Cọc"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btn_kiemtracoc)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panel)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1231, 557)
        Me.Panel1.TabIndex = 1
        '
        'panel
        '
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel.Controls.Add(Me.Label6)
        Me.panel.Controls.Add(Me.Label5)
        Me.panel.Controls.Add(Me.Label4)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.PictureBox2)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(1231, 557)
        Me.panel.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(677, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = " Lớp :      61TH1  "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(677, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(222, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = " Mssv :    1508861 "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(676, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(401, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sinh Viên Thực Hiện : Lê Tuấn Dương"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(676, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(519, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Giảng Viên Hướng Dẫn : TS. Dương Diệp Thúy"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1227, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1227, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ĐỒ ÁN TỐT NGHIỆP- ĐỀ TÀI TÍNH TOÁN MÓNG CỌC"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1227, 553)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1231, 557)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 719)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.MaximumSize = New System.Drawing.Size(1241, 724)
        Me.MinimumSize = New System.Drawing.Size(1241, 724)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Phần mền Tính Toán Và thiết kế móng cọc"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_diachat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_chonvatlieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_nhapnoiluc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem2 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents btn_nhaplieucoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_gioithieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_botricoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_TinhThepdai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_kiemtracoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_dulieudai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents panel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
