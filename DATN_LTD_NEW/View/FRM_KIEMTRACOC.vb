Public Class FRM_KIEMTRACOC

    Private Shared _instance As FRM_KIEMTRACOC
    ' singleton new
    Public Shared ReadOnly Property Instance As FRM_KIEMTRACOC
        Get
            If _instance Is Nothing Then _instance = New FRM_KIEMTRACOC
            Return _instance
        End Get
    End Property
    Private Sub txtL_TextChanged(sender As Object, e As EventArgs) Handles txtL.TextChanged
        If Coc.Dc = 0 Then
            MessageBox.Show("Bạn chưa nhập kích thước cọc!", "Thông báo")
        ElseIf Coc.Thep = "" Then
            MessageBox.Show("Bạn chưa nhập vật liệu cọc!", "Thông báo")
        Else

            lbQ.Visible = True
            lbM1.Visible = True
            lbM2.Visible = True
            lbAsyc.Visible = True
            lbAschon.Visible = True

            Dim Q As Double
            Q = 25 * 1.5 * Coc.Dc * Coc.Dc
            lbQ.Text = Q

            Dim L As Double
            L = Val(txtL.Text)
            lbM1.Text = Tinh.KiemTraCoc(1, L)
            lbM2.Text = Tinh.KiemTraCoc(2, L)

            Dim M As Double
            Dim Asyc As Double
            Dim Aschon As Double
            M = Math.Max(Tinh.KiemTraCoc(1, L), Tinh.KiemTraCoc(2, L))
            Asyc = Math.Round(Tinh.ThepCoc(M), 2)
            Aschon = Math.Round(Coc.Sothanhthep * Coc.DKthep ^ 2 * Math.PI / (2 * 400), 2)

            lbAsyc.Text = Asyc
            lbAschon.Text = Aschon

            If Asyc <= Aschon Then
                lbkiemtra.ForeColor = Color.Blue
                lbkiemtra.Text = "Cọc đảm bảo điều kiện thi công!"
            Else
                lbkiemtra.ForeColor = Color.Red
                lbkiemtra.Text = "Cọc không đảm bảo điều kiện thi công!" & vbCrLf & vbCrLf & "Hãy chọn lại thép hoặc kích thước cọc."
            End If
        End If

    End Sub

    Private Sub FRM_KIEMTRACOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
    End Sub

    Private Sub btn_tieptuc_Click(sender As Object, e As EventArgs) Handles btn_tieptuc.Click
        Form1.Instance.OpenForm(FRM_tinhthepdai)
    End Sub
End Class