<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BanVe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BanVe))
        Me.vdrVe = New AxVDProLib5.AxVDPro()
        CType(Me.vdrVe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vdrVe
        '
        Me.vdrVe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vdrVe.Enabled = True
        Me.vdrVe.Location = New System.Drawing.Point(0, 0)
        Me.vdrVe.Name = "vdrVe"
        Me.vdrVe.OcxState = CType(resources.GetObject("vdrVe.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vdrVe.Size = New System.Drawing.Size(800, 450)
        Me.vdrVe.TabIndex = 0
        '
        'Frm_BanVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.vdrVe)
        Me.Name = "Frm_BanVe"
        Me.Text = "Frm_BanVe"
        CType(Me.vdrVe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents vdrVe As AxVDProLib5.AxVDPro
End Class
