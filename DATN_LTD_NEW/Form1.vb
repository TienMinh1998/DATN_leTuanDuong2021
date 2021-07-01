Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared _instance As Form1
    ' singleton new


    Public Shared Property Instance As Form1
        Get
            If _instance Is Nothing Then _instance = New Form1
            Return _instance
        End Get

        Set(value As Form1)
            _instance = value
        End Set
    End Property

    Private Sub btn_chonvatlieu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_chonvatlieu.ItemClick
        ' Gọi FRM vật liệu ra làm việc
        OpenForm(vatlieu_View.Instance)
    End Sub

    Private Sub btn_diachat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_diachat.ItemClick
        ' Gọi FRM địa chất ra làm việc
        OpenForm(diachat_view.Instance)
    End Sub

    Private Sub btn_dulieudai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_dulieudai.ItemClick
        ' GEt FRM dữ liệu móng ra làm việc
        OpenForm(FRM_dulieudai.Instance)

    End Sub

    Private Sub btn_nhaplieucoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_nhaplieucoc.ItemClick
        ' hiện frm dữ liệu cọc ra
        OpenForm(view_dulieucoc)

    End Sub

    Private Sub btn_nhapnoiluc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_nhapnoiluc.ItemClick
        'hiện FRM nội lực ra
        panel.Controls.Clear()
        OpenForm(view_NoiLuc)
    End Sub

    Private Sub btn_botricoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_botricoc.ItemClick
        OpenForm(Botricoc_View)

    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        OpenForm(RM_Kiemtradai)
    End Sub
    Public Sub OpenForm(childForm As Form)
        'Dim activeForm As Form
        'If activeForm IsNot Nothing Then activeForm.Close()
        'activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Form1.Instance.panel.Controls.Clear()
        Form1.Instance.panel.Controls.Add(childForm)
        Form1.Instance.panel.Tag = childForm

        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_TinhThepdai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_TinhThepdai.ItemClick
        OpenForm(FRM_tinhthepdai)
    End Sub

    Private Sub btn_kiemtracoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_kiemtracoc.ItemClick
        OpenForm(FRM_KIEMTRACOC)
    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click
        _instance = Me
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
