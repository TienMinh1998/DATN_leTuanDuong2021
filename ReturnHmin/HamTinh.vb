Public Class HamTinh
    ''' <summary>
    ''' Hàm Trả ra giá trị thong báo
    ''' </summary>
    ''' <param name="a">Giá Trị Hm</param>
    ''' <param name="b">Giá Trị Hmin</param>
    ''' <returns></returns>
    Public Shared Function isHmin(a As Double, b As Double) As String
        Dim thongbao As String
        If a < b Then
            thongbao = "Giá trị Hm chọn không thỏa mãn, phải chọn lại"
        Else
            thongbao = "Giá Trị Hm chọn Thỏa mãn, không cần chọn lại"
        End If
        Return thongbao
    End Function
End Class
