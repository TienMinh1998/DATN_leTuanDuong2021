Public Class FRM_tinhthepdai
    Private Shared _instance As FRM_tinhthepdai
    ' singleton new
    Public Shared ReadOnly Property Instance As FRM_tinhthepdai
        Get
            If _instance Is Nothing Then _instance = New FRM_tinhthepdai
            Return _instance
        End Get
    End Property

    Private Sub FRM_tinhthepdai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _instance = Me
        If LST_Coc.Count = 2 Or LST_Coc.Count = 3 Then
            txtAs2.Text = "cấu tạo"
            txtAs1.Text = Tinh.ThepDai(1).ToString
        Else
            txtAs1.Text = Tinh.ThepDai(1).ToString
            txtAs2.Text = Tinh.ThepDai(2).ToString
        End If
    End Sub

    Private Sub txtslx_TextChanged(sender As Object, e As EventArgs) Handles txtslx.TextChanged
        Dim kc As Double
        kc = Val(txtslx.Text) - 1
        txtkcx.Text = Math.Round(DaiMong.Bd * 1000 / kc).ToString
    End Sub

    Private Sub txtsly_TextChanged(sender As Object, e As EventArgs) Handles txtsly.TextChanged
        Dim kc As Double
        kc = Val(txtsly.Text) - 1
        txtkcy.Text = Math.Round(DaiMong.Ld * 1000 / kc).ToString
    End Sub

    Private Sub cbbdkthepx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbdkthepx.SelectedIndexChanged
        lbAschonx.Text = "As chọn: " & Math.Round(Val(txtslx.Text) * Val(cbbdkthepx.Text) ^ 2 * Math.PI / 400, 2) & " cm2"
    End Sub

    Private Sub cbbdkthepy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbdkthepy.SelectedIndexChanged
        lbAschony.Text = "As chọn: " & Math.Round(Val(txtsly.Text) * Val(cbbdkthepy.Text) ^ 2 * Math.PI / 400, 2) & " cm2"
    End Sub
End Class