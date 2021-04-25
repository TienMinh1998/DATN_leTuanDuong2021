Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btn_chonvatlieu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_chonvatlieu.ItemClick
        ' Gọi FRM vật liệu ra làm việc
        vatlieu_View.ShowDialog()
    End Sub

    Private Sub btn_diachat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_diachat.ItemClick
        ' Gọi FRM địa chất ra làm việc

    End Sub

    Private Sub btn_nhapnoiluc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_nhapnoiluc.ItemClick
        'Gọi FRM nội lực ra làm việc

    End Sub

    Private Sub btn_nhaplieucoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_nhaplieucoc.ItemClick
        ' GỌI FORM vật liệu cọc lên để làm việc


    End Sub

    Private Sub btn_botricoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_botricoc.ItemClick


    End Sub
End Class
