Public Class view_dulieucoc
    Private Shared _instance As view_dulieucoc
    ' singleton new
    Public Shared ReadOnly Property Instance As view_dulieucoc
        Get
            If _instance Is Nothing Then _instance = New view_dulieucoc
            Return _instance
        End Get
    End Property

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If txtDc.Text = "" Or txtLc.Text = "" Or txtLngam.Text = "" Or txtSothanhthep.Text = "" Or cbbDKthep.Text = "" Then
            lb_thongbao.Visible = True
            lb_thongbao.ForeColor = Color.Red
            lb_thongbao.Text = "Vui lòng nhập đầy đủ thông tin của Cọc!"
        ElseIf IsNumeric(txtDc.Text) And IsNumeric(txtLc.Text) And IsNumeric(txtLngam.Text) And IsNumeric(txtSothanhthep.Text) And IsNumeric(cbbDKthep.Text) Then
            Coc.Dc = txtDc.Text
            Coc.Lc = txtLc.Text
            Coc.Lngam = txtLngam.Text
            Coc.Sothanhthep = txtSothanhthep.Text
            Coc.DKthep = cbbDKthep.Text

            lb_thongbao.Visible = True
            lb_thongbao.ForeColor = Color.Green
            lb_thongbao.Text = "Lưu lại dữ liệu cho cọc thành công, Chuyền FRM khác để tính toán!!"
        Else
            MessageBox.Show("Giá trị vừa nhập không hợp lệ!")
        End If
    End Sub

    Private Sub view_dulieucoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
    End Sub

    Private Sub btn_trolai_Click(sender As Object, e As EventArgs) Handles btn_trolai.Click
        ' Trở Về FORM Dữ liệu đài
        Form1.Instance.OpenForm(FRM_dulieudai.Instance)
    End Sub

    Private Sub btn_tieptheo_Click(sender As Object, e As EventArgs) Handles btn_tieptheo.Click
        ' Đi đến FORM Nội Lực
        Form1.Instance.OpenForm(view_NoiLuc.Instance)
    End Sub
End Class