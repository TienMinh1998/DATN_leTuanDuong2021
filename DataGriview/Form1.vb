Public Class Form1
    Public vitrisua As Integer
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        ' xóa trắng
        txt_chieudai.Text = ""
        txt_h.Text = ""
        txt_b.Text = ""
        txt_idid.Text = ""
        txt_idid.Focus() ' nhảy vào ô đầu tiên
        is_save = False ' đổi luông cho nút luuw thành luồng thêm 
    End Sub
    Public is_save As Boolean = False ' bằng sai thì đang chạy cho nút add
    ' bằng true thì sẽ chạy cho nts lưu 

    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        ' Thêm vào datagriview 
        If is_save = False Then
            ' add
            dgv.Rows.Add(txt_idid.Text, txt_chieudai.Text, txt_b.Text, txt_h.Text)
            is_save = True
        Else
            ' lưu 
            dgv.Rows(vitrisua).Cells(0).Value = txt_idid.Text
            dgv.Rows(vitrisua).Cells(1).Value = txt_chieudai.Text
            dgv.Rows(vitrisua).Cells(2).Value = txt_b.Text
            dgv.Rows(vitrisua).Cells(3).Value = txt_h.Text
            is_save = False
        End If


    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        ' vi tri xoa 
        Dim vt As Integer = dgv.CurrentRow.Index
        dgv.Rows.RemoveAt(vt)


    End Sub
    Public Sub init()
        dgv.Rows.Add(1, 3000, 45, 50)
        dgv.Rows.Add(2, 7000, 45, 50)
        dgv.Rows.Add(4, 3000, 45, 50)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        MessageBox.Show(dgv.CurrentRow.Index)
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vtsua As Integer = dgv.CurrentRow.Index
        vitrisua = vtsua
        txt_chieudai.Text = dgv.Rows(vtsua).Cells(1).Value
        txt_idid.Text = dgv.Rows(vtsua).Cells(0).Value
        txt_b.Text = dgv.Rows(vtsua).Cells(2).Value
        txt_h.Text = dgv.Rows(vtsua).Cells(3).Value
        is_save = True ' đổi luồng cho nút luuw thành luông sửa
    End Sub
End Class
