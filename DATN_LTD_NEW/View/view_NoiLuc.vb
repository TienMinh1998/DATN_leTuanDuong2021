Public Class view_NoiLuc
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If txtN.Text = "" Or txtMx.Text = "" Or txtMy.Text = "" Or txtQx.Text = "" Or txtQy.Text = "" Or txtQy.Text = "" Or txtHSantoan.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ nội lực!")
        ElseIf IsNumeric(txtN.Text) And IsNumeric(txtMx.Text) And IsNumeric(txtMy.Text) And IsNumeric(txtQx.Text) And IsNumeric(txtQy.Text) And IsNumeric(txtHSantoan.Text) Then
            MyDataBase.Ntt = Val(txtN.Text)
            MyDataBase.Mxtt = Val(txtMx.Text)
            MyDataBase.Mytt = Val(txtMy.Text)
            MyDataBase.Qxtt = Val(txtQx.Text)
            MyDataBase.Qytt = Val(txtQy.Text)
            MyDataBase.HS_antoan = Val(txtHSantoan.Text)

            Me.Close()
        Else
            MessageBox.Show("Giá trị bạn nhập không hợp lệ!")
        End If
    End Sub
End Class