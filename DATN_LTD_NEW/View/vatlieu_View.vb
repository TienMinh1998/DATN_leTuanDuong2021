
Public Class vatlieu_View

    ' Tạo Instance đối tượng vatlieu_view

    Private Shared _instance As vatlieu_View
    Public Shared ReadOnly Property Instance As vatlieu_View
        Get
            If _instance Is Nothing Then _instance = New vatlieu_View()
            Return _instance
        End Get
    End Property
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property Code_1 As Byte
        Get
            Return _code_1
        End Get
        Set(value As Byte)
            _code_1 = value
        End Set
    End Property
    Public Property Code_2 As Byte
        Get
            Return _code_2
        End Get
        Set(value As Byte)
            _code_2 = value
        End Set
    End Property
    Public Property Is_coc As Boolean
        Get
            Return _is_coc
        End Get
        Set(value As Boolean)
            _is_coc = value
        End Set
    End Property

    Private _is_coc As Boolean
    Private _code_1 As Byte
    Private _code_2 As Byte
    Private Sub cbb_betong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_betong.SelectedIndexChanged
        Code_1 = Convert.ToByte(cbb_betong.SelectedIndex)
        Dim vlbt As New Material(Code_1)
        ' Hiện Bê tông lên
        txtRb.Text = vlbt.Rb.ToString
        txtRbt.Text = vlbt.Rbt.ToString
        txtEb.Text = vlbt.Eb.ToString
    End Sub
    Private Sub cbb_thep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_thep.SelectedIndexChanged
        Code_2 = Convert.ToByte(cbb_thep.SelectedIndex)
        Dim vlt As New Material(Code_2, True)
        ' HIện các chỉ số của thép lên
        txtRs.Text = vlt.Rs.ToString
        txtRsc.Text = vlt.Rsc.ToString
        txtEs.Text = vlt.Es.ToString
    End Sub


    Private Sub vatlieu_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
    End Sub

    Private Sub btn_Xacnhan_Click(sender As Object, e As EventArgs) Handles btn_Xacnhan.Click

        ' Chọn vật liệu cho cọc
        If Rb_coc.Checked = True Then
            MyDataBase.vatlieu_coc = New Material(Code_1, Code_2)
            lb_betong_coc.Text = vatlieu_coc.Tenbetong
            lb_thep_coc.Text = vatlieu_coc.Tenthep
            Coc.Betong = MyDataBase.vatlieu_coc.Tenbetong
            Coc.Rb = MyDataBase.vatlieu_coc.Rb
            Coc.Rbt = MyDataBase.vatlieu_coc.Rbt
            Coc.Eb = MyDataBase.vatlieu_coc.Eb
            Coc.Thep = MyDataBase.vatlieu_coc.Tenthep
            Coc.Rs = MyDataBase.vatlieu_coc.Rs
            Coc.Rsc = MyDataBase.vatlieu_coc.Rsc
            Coc.Es = MyDataBase.vatlieu_coc.Es

        End If
        ' Chọn vật liệu bê tông cho đài
        If Rb_dai.Checked = True Then
            MyDataBase.vatlieu_dai = New Material(Code_1, Code_2)
            lb_betong_dai.Text = vatlieu_dai.Tenbetong
            lb_thep_dai.Text = vatlieu_dai.Tenthep

            DaiMong.Betong = MyDataBase.vatlieu_dai.Tenbetong
            DaiMong.Rb = MyDataBase.vatlieu_dai.Rb
            DaiMong.Rbt = MyDataBase.vatlieu_dai.Rbt
            DaiMong.Eb = MyDataBase.vatlieu_dai.Eb
            DaiMong.Thep = MyDataBase.vatlieu_dai.Tenthep
            DaiMong.Rs = MyDataBase.vatlieu_dai.Rs
            DaiMong.Rsc = MyDataBase.vatlieu_dai.Rsc
            DaiMong.Es = MyDataBase.vatlieu_dai.Es
        End If
        ' Chọn cho cả 2 :
        If Rb_both.Checked = True Then
            MyDataBase.vatlieu_coc = New Material(Code_1, Code_2)
            MyDataBase.vatlieu_dai = New Material(Code_1, Code_2)
            lb_betong_coc.Text = vatlieu_coc.Tenbetong
            lb_thep_coc.Text = vatlieu_coc.Tenthep

            lb_betong_dai.Text = vatlieu_dai.Tenbetong
            lb_thep_dai.Text = vatlieu_dai.Tenthep

            Coc.Betong = MyDataBase.vatlieu_coc.Tenbetong
            Coc.Rb = MyDataBase.vatlieu_coc.Rb
            Coc.Rbt = MyDataBase.vatlieu_coc.Rbt
            Coc.Eb = MyDataBase.vatlieu_coc.Eb
            Coc.Thep = MyDataBase.vatlieu_coc.Tenthep
            Coc.Rs = MyDataBase.vatlieu_coc.Rs
            Coc.Rsc = MyDataBase.vatlieu_coc.Rsc
            Coc.Es = MyDataBase.vatlieu_coc.Es

            DaiMong.Betong = MyDataBase.vatlieu_coc.Tenbetong
            DaiMong.Rb = MyDataBase.vatlieu_coc.Rb
            DaiMong.Rbt = MyDataBase.vatlieu_coc.Rbt
            DaiMong.Eb = MyDataBase.vatlieu_coc.Eb
            DaiMong.Thep = MyDataBase.vatlieu_coc.Tenthep
            DaiMong.Rs = MyDataBase.vatlieu_coc.Rs
            DaiMong.Rsc = MyDataBase.vatlieu_coc.Rsc
            DaiMong.Es = MyDataBase.vatlieu_coc.Es

        End If
        If lb_betong_coc.Text <> "NULL" And lb_betong_dai.Text <> "NULL" Then
            Dim a As DialogResult = MessageBox.Show("Chọn Vật Liệu Thành Công, Bạn có muốn chọn lại không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = DialogResult.Yes Then
            Else

            End If


        End If
    End Sub

    Private Sub btn_dong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_trovediachat_Click(sender As Object, e As EventArgs) Handles btn_trovediachat.Click
        Form1.Instance.OpenForm(diachat_view.Instance)
    End Sub

    Private Sub btn_tieptheo_Click(sender As Object, e As EventArgs) Handles btn_tieptheo.Click
        Form1.Instance.OpenForm(FRM_dulieudai.Instance)
    End Sub
End Class