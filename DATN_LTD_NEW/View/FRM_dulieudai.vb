Public Class FRM_dulieudai
    Private Shared _instance As FRM_dulieudai
    Public Shared ReadOnly Property Instance As FRM_dulieudai
        Get
            If _instance Is Nothing Then _instance = New FRM_dulieudai
            Return _instance
        End Get
    End Property

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If txtHd.Text = "" Or txtHm.Text = "" Or txtKcCocdenDai.Text = "" Or txtBetonglot.Text = "" Then
            lb_thongbao.Visible = True
            lb_thongbao.Text = "Vui lòng nhập đủ thông tin!!!"
            lb_thongbao.ForeColor = Color.Red

        ElseIf txtHcot.Text = "" Or txtBcot.Text = "" Then
            lb_thongbao.Visible = True
            lb_thongbao.Text = "Vui lòng nhập đủ kích thước cột!!"
            lb_thongbao.ForeColor = Color.Red
        ElseIf IsNumeric(txtHd.Text) And IsNumeric(txtHm.Text) And IsNumeric(txtKcCocdenDai.Text) And IsNumeric(txtBetonglot.Text) And IsNumeric(txtHcot.Text) And IsNumeric(txtBcot.Text) Then
            DaiMong.Hd = txtHd.Text
            DaiMong.Hm = txtHm.Text
            DaiMong.KcCocdenDai = txtKcCocdenDai.Text
            DaiMong.Betonglot = txtBetonglot.Text

            DaiMong.Hcot = txtHcot.Text
            DaiMong.Bcot = txtBcot.Text

            lb_thongbao.Visible = True
            lb_thongbao.Text = "Lưu lại Dữ Liệu Đài Thành Công!!, chuyển FRM khác để tính toán"
            lb_thongbao.ForeColor = Color.Green

        Else
            lb_thongbao.Visible = True
            lb_thongbao.Text = "Giá Trị Nhập không hợp lệ!!"
            lb_thongbao.ForeColor = Color.Red
        End If
        ' reload lai Frm botricoc
        Botricoc_View.Instance.reloadCHieuSauChonMong()

    End Sub

    Private Sub view_chonchieusauhm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
    End Sub

    Private Sub btn_tieptheo_Click(sender As Object, e As EventArgs) Handles btn_tieptheo.Click
        ' Tiến Đến FORM dữ liệu CỌc
        Form1.Instance.OpenForm(view_dulieucoc.Instance)
    End Sub

    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        ' Trở Về FORM vật liệu
        Form1.Instance.OpenForm(vatlieu_View.Instance)
    End Sub
End Class