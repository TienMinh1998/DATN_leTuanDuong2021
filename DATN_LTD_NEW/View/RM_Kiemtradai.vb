Public Class RM_Kiemtradai
    Private Sub btn_kiemtra_Click(sender As Object, e As EventArgs) Handles btn_kiemtra.Click
        If LST_Coc.Count = 0 Then
            MessageBox.Show("Bạn chưa bố trí cọc cho móng!", "Thông báo !")
        ElseIf DaiMong.Rbt = 0 Then
            MessageBox.Show("Bạn chưa chọn vật liệu đài!", "Thông báo !")
        ElseIf Ntt = 0 Then
            MessageBox.Show("Bạn chưa nhập nội lực!")
        ElseIf Tinh.DamThung(2) = 0 Then
            MessageBox.Show("Bạn chưa xác định tải tác động lên cọc!", "Thông báo !")
        Else

            txtPcdt.Text = Tinh.DamThung(1)
            txtPdt.Text = Tinh.DamThung(2)
            txtPcct.Text = Tinh.ChocThung(1)
            txtPct.Text = Tinh.ChocThung(2)

            txtkiemtradamthung.Visible = True
            txtkiemtrachocthung.Visible = True

            If Tinh.DamThung(2) <= Tinh.DamThung(1) Then
                txtkiemtradamthung.ForeColor = Color.Blue
                txtkiemtradamthung.Text = "Đảm bảo điều kiện" & vbCrLf & "Đài không bị đâm thủng"
            Else
                txtkiemtradamthung.ForeColor = Color.Red
                txtkiemtradamthung.Text = "Không đảm bảo"
            End If

            If Tinh.ChocThung(2) <= Tinh.ChocThung(1) Then
                txtkiemtrachocthung.ForeColor = Color.Blue
                txtkiemtrachocthung.Text = "Đảm bảo điều kiện" & vbCrLf & "Đài không bị chọc thủng"
            Else
                txtkiemtrachocthung.ForeColor = Color.Red
                txtkiemtrachocthung.Text = "Không đảm bảo"
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btn_tieptuc_Click(sender As Object, e As EventArgs) Handles btn_tieptuc.Click
        Form1.Instance.OpenForm(FRM_KIEMTRACOC)
    End Sub
End Class