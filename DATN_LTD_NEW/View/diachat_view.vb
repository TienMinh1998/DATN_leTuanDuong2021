
Imports excel = Microsoft.Office.Interop.Excel
Public Class diachat_view
    Dim is_save As Integer = 3



    Private Shared _instance As diachat_view
    ' singleton new khởi tạo ra 1 cái form và dùng nó cho cả chương trình
    Public Shared ReadOnly Property Instance As diachat_view
        Get
            If _instance Is Nothing Then _instance = New diachat_view
            Return _instance
        End Get
    End Property
    ' Nút thêm
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        is_save = 0 ' tương đương is_add = true

        txtChieuDay.Text = ""
        txtDoRoi.Text = ""
        txtDungTrong.Text = ""
        txtGocMS.Text = ""
        txtHsa.Text = ""
        txtHsk.Text = ""
        txtLopDat.Text = ""
        txtmodun.Text = ""
        txtN30.Text = ""
        txtQc.Text = ""
        Dim sobanghi As String = (dgv_diachat.Rows.Count + 1).ToString
        txtLopDat.Text = sobanghi
    End Sub
    ' NÚt Sửa
    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        is_save = 1
        If dgv_diachat.RowCount <> 0 Then
            ' trường hợp có bản ghi ở trên datagriview
            txtLopDat.Text = dgv_diachat.CurrentRow.Cells(0).Value.ToString()
            cbbLoaiDat.Text = dgv_diachat.CurrentRow.Cells(1).Value.ToString()
            cbbTrangThai.Text = dgv_diachat.CurrentRow.Cells(2).Value.ToString()
            txtChieuDay.Text = dgv_diachat.CurrentRow.Cells(3).Value.ToString()
            txtDungTrong.Text = dgv_diachat.CurrentRow.Cells(4).Value.ToString()
            txtmodun.Text = dgv_diachat.CurrentRow.Cells(5).Value.ToString()
            txtGocMS.Text = dgv_diachat.CurrentRow.Cells(6).Value.ToString()
            txtDoRoi.Text = dgv_diachat.CurrentRow.Cells(7).Value.ToString()
            txtQc.Text = dgv_diachat.CurrentRow.Cells(8).Value.ToString()
            txtN30.Text = dgv_diachat.CurrentRow.Cells(9).Value.ToString()
        Else
            ' trường hợp không bằng 0 thì sẽ bay vào đây
            MessageBox.Show("Chưa chọn hàng để sửa!", "Thông báo!")
        End If
    End Sub
    ' Nút Lưu
    Private Sub btn_luu_Click(sender As Object, e As EventArgs) Handles btn_luu.Click
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Nhão" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 30
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Dẻo" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 30
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Dẻo mềm" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Nửa cứng" Then
            txtHsk.Text = 0.45
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét" And cbbTrangThai.Text = "Cứng" Then
            txtHsk.Text = 0.55
            txtHsa.Text = 40
        End If
        ' SÉT PHA
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Nhão" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Dẻo" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 40
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Dẻo mềm" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 50
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Nửa cứng" Then
            txtHsk.Text = 0.45
            txtHsa.Text = 50
        End If
        If cbbLoaiDat.Text = "Sét pha" And cbbTrangThai.Text = "Cứng" Then
            txtHsk.Text = 0.55
            txtHsa.Text = 50
        End If
        'CÁT PHA 

        If cbbLoaiDat.Text = "Cát pha" And cbbTrangThai.Text = "Chặt" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 80
        End If
        If cbbLoaiDat.Text = "Cát pha" And cbbTrangThai.Text = "Chặt vừa" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 70
        End If
        If cbbLoaiDat.Text = "Cát pha" And cbbTrangThai.Text = "Xốp" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 60
        End If
        ' CÁT
        If cbbLoaiDat.Text = "Cát" And cbbTrangThai.Text = "Chặt" Then
            txtHsk.Text = 0.4
            txtHsa.Text = 150
        End If
        If cbbLoaiDat.Text = "Cát" And cbbTrangThai.Text = "Chặt vừa" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 100
        End If
        If cbbLoaiDat.Text = "Cát" And cbbTrangThai.Text = "Xốp" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 60
        End If
        'CUỘI SỎI 
        If cbbLoaiDat.Text = "Cuội sỏi" And cbbTrangThai.Text = "Chặt" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 150
        End If
        If cbbLoaiDat.Text = "Cuội sỏi" And cbbTrangThai.Text = "Chặt vừa" Then
            txtHsk.Text = 0.5
            txtHsa.Text = 120
        End If

        '----- Them du lieu vao bang Datagridview -------
        If cbbLoaiDat.Text = "" Or cbbTrangThai.Text = "" Or txtChieuDay.Text = "" Or txtDungTrong.Text = "" Or txtmodun.Text = "" Or txtGocMS.Text = "" Or txtDoRoi.Text = "" Or txtQc.Text = "" Or txtN30.Text = "" Then
            MessageBox.Show("Vui lòng nhập đủ thông tin !")
        ElseIf IsNumeric(txtChieuDay.Text) = False Or IsNumeric(txtDungTrong.Text) = False Or IsNumeric(txtmodun.Text) = False Or IsNumeric(txtGocMS.Text) = False Or IsNumeric(txtDoRoi.Text) = False Or IsNumeric(txtQc.Text) = False Or IsNumeric(txtN30.Text) = False Then
            MessageBox.Show("Giá trị vừa nhập không hợp lệ !")
        Else
            If is_save = 0 Then ' đây là luồng cho nút thêm
                dgv_diachat.Rows.Add(dgv_diachat.RowCount, cbbLoaiDat.Text, cbbTrangThai.Text, txtChieuDay.Text, txtDungTrong.Text, txtmodun.Text, txtGocMS.Text, txtDoRoi.Text, txtQc.Text, txtN30.Text, txtHsk.Text, txtHsa.Text)
                GetDataBase_LOPDAT() ' hàm cập nhập lại danh sách mới
            ElseIf is_save = 1 Then ' đây là luồng cho nút sửa
                dgv_diachat.CurrentRow.Cells(0).Value = txtLopDat.Text
                dgv_diachat.CurrentRow.Cells(1).Value = cbbLoaiDat.Text
                dgv_diachat.CurrentRow.Cells(2).Value = cbbTrangThai.Text
                dgv_diachat.CurrentRow.Cells(3).Value = txtChieuDay.Text
                dgv_diachat.CurrentRow.Cells(4).Value = txtDungTrong.Text
                dgv_diachat.CurrentRow.Cells(5).Value = txtmodun.Text
                dgv_diachat.CurrentRow.Cells(6).Value = txtGocMS.Text
                dgv_diachat.CurrentRow.Cells(7).Value = txtDoRoi.Text
                dgv_diachat.CurrentRow.Cells(8).Value = txtQc.Text
                dgv_diachat.CurrentRow.Cells(9).Value = txtN30.Text
                dgv_diachat.CurrentRow.Cells(10).Value = txtHsk.Text
                dgv_diachat.CurrentRow.Cells(11).Value = txtHsa.Text
                GetDataBase_LOPDAT() ' đây là hàm cập nhập lại danh sách mới
            End If
        End If

    End Sub
    ' Nút Xóa
    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim sohang = dgv_diachat.RowCount
        If sohang = 0 Then
            MessageBox.Show("Chưa có dữ liệu")
        Else
            Dim index = dgv_diachat.CurrentRow.Index
            '----Xoa du lieu tu bang datagridview--------
            If index < 0 Then
                MessageBox.Show("Chưa chọn hàng cần xóa!", "Thông báo!")
            Else ' có dữ liệu và click rồi: 

                dgv_diachat.Rows.RemoveAt(index)
            End If

            '----Danh lai so thu tu lop dat sau khi xoa -----
            For i = 0 To dgv_diachat.RowCount - 1
                dgv_diachat.Rows(i).Cells(0).Value = i + 1
            Next
        End If


    End Sub
    ' Load form
    Private Sub diachat_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        is_save = 3
        _instance = Me
    End Sub
    ' Sự kiện thay đổi combobox loại đất
    Private Sub cbbLoaiDat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbLoaiDat.SelectedIndexChanged
        Select Case cbbLoaiDat.SelectedIndex
            Case 0 ' sét
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Nhão")
                cbbTrangThai.Items.Add("Dẻo")
                cbbTrangThai.Items.Add("Dẻo mềm")
                cbbTrangThai.Items.Add("Nửa cứng")
                cbbTrangThai.Items.Add("Cứng")
            Case 1
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Nhão")
                cbbTrangThai.Items.Add("Dẻo")
                cbbTrangThai.Items.Add("Dẻo mềm")
                cbbTrangThai.Items.Add("Nửa cứng")
                cbbTrangThai.Items.Add("Cứng")
            Case 2
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Chặt")
                cbbTrangThai.Items.Add("Chặt vừa")
                cbbTrangThai.Items.Add("Xốp")

            Case 3
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Chặt")
                cbbTrangThai.Items.Add("Chặt vừa")
                cbbTrangThai.Items.Add("Xốp")
            Case 4
                cbbTrangThai.Items.Clear()
                cbbTrangThai.Items.Add("Chặt")
                cbbTrangThai.Items.Add("Chặt vừa")
        End Select
    End Sub
    ' Sự kiện bấm vào nút load excel: 

    ' Sự kiện lấy dữ liệu của database lưu vào trong chương trình để tính
    Private Sub GetDataBase_LOPDAT()
        LST_DiaChat.Clear()
        '------ Them vao list dia chat------
        For i = 0 To dgv_diachat.RowCount - 1
            Dim DiaChat As New Cls_DiaChat

            DiaChat.Lop = Convert.ToInt16(dgv_diachat.Rows(i).Cells(0).Value)
            DiaChat.LoaiDat = Convert.ToString(dgv_diachat.Rows(i).Cells(1).Value)
            DiaChat.TrangThai = Convert.ToString(dgv_diachat.Rows(i).Cells(2).Value)
            DiaChat.ChieuDay = Convert.ToDouble(dgv_diachat.Rows(i).Cells(3).Value)
            DiaChat.DungTrong = Convert.ToDouble(dgv_diachat.Rows(i).Cells(4).Value)
            DiaChat.MoDun = Convert.ToDouble(dgv_diachat.Rows(i).Cells(5).Value)
            DiaChat.GocMS = Convert.ToDouble(dgv_diachat.Rows(i).Cells(6).Value)
            DiaChat.DoRoi = Convert.ToDouble(dgv_diachat.Rows(i).Cells(7).Value)
            DiaChat.Qc = Convert.ToDouble(dgv_diachat.Rows(i).Cells(8).Value)
            DiaChat.N30 = Convert.ToDouble(dgv_diachat.Rows(i).Cells(9).Value)
            DiaChat.Hsk = Convert.ToDouble(dgv_diachat.Rows(i).Cells(10).Value)
            DiaChat.Hsa = Convert.ToDouble(dgv_diachat.Rows(i).Cells(11).Value)
            LST_DiaChat.Add(DiaChat)
        Next

    End Sub
    ' Sự kiện Next sang trang tiếp theo
    Private Sub btn_tieptheo_Click(sender As Object, e As EventArgs) Handles btn_tieptheo.Click
        Form1.Instance.OpenForm(vatlieu_View.Instance)
    End Sub
    ' Nhập từ Excel
    Private Sub btn_NhapExcel_Click(sender As Object, e As EventArgs) Handles btn_NhapExcel.Click
        ' mở hộp thoại Chọn đường dẫn đến Excel
        dgv_diachat.Rows.Clear()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
        '================================================================
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(OpenFileDialog1.FileName)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            'Dem so hang
            Dim sh As Integer
            For i As Integer = 2 To 100
                If xlWorkSheet.Cells(i, 1).value <> Nothing Then
                    sh = i - 1
                Else
                    Exit For
                End If
            Next
            Me.dgv_diachat.Rows.Clear()
            For i As Integer = 2 To sh + 1
                dgv_diachat.Rows.Add(xlWorkSheet.Cells(i, 1).value, xlWorkSheet.Cells(i, 2).value, xlWorkSheet.Cells(i, 3).value, xlWorkSheet.Cells(i, 4).value, xlWorkSheet.Cells(i, 5).value, xlWorkSheet.Cells(i, 6).value, xlWorkSheet.Cells(i, 7).value, xlWorkSheet.Cells(i, 8).value, xlWorkSheet.Cells(i, 9).value, xlWorkSheet.Cells(i, 10).value, xlWorkSheet.Cells(i, 11).value, xlWorkSheet.Cells(i, 12).value)
            Next
            xlWorkBook.Close()
            xlApp.Quit()
        End If
        GetDataBase_LOPDAT()
    End Sub
End Class