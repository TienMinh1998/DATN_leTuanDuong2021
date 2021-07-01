Public Class view_NoiLuc

    Private Shared _instance As view_NoiLuc
    ' singleton new
    Public Shared ReadOnly Property Instance As view_NoiLuc
        Get
            If _instance Is Nothing Then _instance = New view_NoiLuc
            Return _instance
        End Get
    End Property
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If txtN.Text = "" Or txtMx.Text = "" Or txtMy.Text = "" Or txtQx.Text = "" Or txtQy.Text = "" Or txtQy.Text = "" Or txtHSantoan.Text = "" Then
            lb_thongbao.Visible = True
            lb_thongbao.ForeColor = Color.Red
            lb_thongbao.Text = "Vui lòng nhập đầy đủ nội lực!"

        ElseIf IsNumeric(txtN.Text) And IsNumeric(txtMx.Text) And IsNumeric(txtMy.Text) And IsNumeric(txtQx.Text) And IsNumeric(txtQy.Text) And IsNumeric(txtHSantoan.Text) Then
            DATA.Ntt = txtN.Text
            DATA.Mxtt = txtMx.Text
            DATA.Mytt = txtMy.Text
            DATA.Qxtt = txtQx.Text
            DATA.Qytt = txtQy.Text
            DATA.HSantoan = txtHSantoan.Text

            lb_thongbao.Visible = True
            lb_thongbao.ForeColor = Color.Green
            lb_thongbao.Text = "Lưu dữ liệu thành công, Chuyển FRM khác để tính toán"
        Else
            lb_thongbao.Visible = True
            lb_thongbao.ForeColor = Color.Red
            lb_thongbao.Text = "Dữ liệu nhập vào không hợp lệ"
        End If
        Form1.Instance.OpenForm(FRM_NHAPLIEUXONG)
    End Sub

    Private Sub view_NoiLuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
    End Sub
End Class