<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_utama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_utama))
        Me.BERANDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARIDATAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENGATURANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAKECAMATANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TAMBAHAKUNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UBAHPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statuslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PENDAFTARANIMBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENDAFTARANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARIDATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SURATKETERANGANIMBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENDAFTARANToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BERANDAToolStripMenuItem
        '
        Me.BERANDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.BERANDAToolStripMenuItem.Name = "BERANDAToolStripMenuItem"
        Me.BERANDAToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.BERANDAToolStripMenuItem.Text = "BERANDA"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'CARIDATAToolStripMenuItem1
        '
        Me.CARIDATAToolStripMenuItem1.Name = "CARIDATAToolStripMenuItem1"
        Me.CARIDATAToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.CARIDATAToolStripMenuItem1.Text = "CARI DATA"
        '
        'PENGATURANToolStripMenuItem
        '
        Me.PENGATURANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAKECAMATANToolStripMenuItem, Me.TAMBAHAKUNToolStripMenuItem, Me.UBAHPASSWORDToolStripMenuItem})
        Me.PENGATURANToolStripMenuItem.Name = "PENGATURANToolStripMenuItem"
        Me.PENGATURANToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.PENGATURANToolStripMenuItem.Text = "PENGATURAN"
        '
        'DATAKECAMATANToolStripMenuItem
        '
        Me.DATAKECAMATANToolStripMenuItem.Name = "DATAKECAMATANToolStripMenuItem"
        Me.DATAKECAMATANToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.DATAKECAMATANToolStripMenuItem.Text = "PROFIL KECAMATAN"
        '
        'TAMBAHAKUNToolStripMenuItem
        '
        Me.TAMBAHAKUNToolStripMenuItem.Name = "TAMBAHAKUNToolStripMenuItem"
        Me.TAMBAHAKUNToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.TAMBAHAKUNToolStripMenuItem.Text = "TAMBAH AKUN"
        '
        'UBAHPASSWORDToolStripMenuItem
        '
        Me.UBAHPASSWORDToolStripMenuItem.Name = "UBAHPASSWORDToolStripMenuItem"
        Me.UBAHPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.UBAHPASSWORDToolStripMenuItem.Text = "UBAH PASSWORD"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.KELUARToolStripMenuItem.Text = "KELUAR"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabel, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1042, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statuslabel
        '
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(12, 17)
        Me.statuslabel.Text = "-"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel1.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel2.Text = "-"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BERANDAToolStripMenuItem, Me.PENDAFTARANIMBToolStripMenuItem, Me.SURATKETERANGANIMBToolStripMenuItem, Me.PENGATURANToolStripMenuItem, Me.KELUARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1042, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PENDAFTARANIMBToolStripMenuItem
        '
        Me.PENDAFTARANIMBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENDAFTARANToolStripMenuItem, Me.CARIDATAToolStripMenuItem})
        Me.PENDAFTARANIMBToolStripMenuItem.Name = "PENDAFTARANIMBToolStripMenuItem"
        Me.PENDAFTARANIMBToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.PENDAFTARANIMBToolStripMenuItem.Text = "PENDAFTARAN IMB"
        '
        'PENDAFTARANToolStripMenuItem
        '
        Me.PENDAFTARANToolStripMenuItem.Name = "PENDAFTARANToolStripMenuItem"
        Me.PENDAFTARANToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PENDAFTARANToolStripMenuItem.Text = "PENDAFTARAN"
        '
        'CARIDATAToolStripMenuItem
        '
        Me.CARIDATAToolStripMenuItem.Name = "CARIDATAToolStripMenuItem"
        Me.CARIDATAToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CARIDATAToolStripMenuItem.Text = "DATA PENDAFTARAN"
        '
        'SURATKETERANGANIMBToolStripMenuItem
        '
        Me.SURATKETERANGANIMBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PENDAFTARANToolStripMenuItem1, Me.CARIDATAToolStripMenuItem1})
        Me.SURATKETERANGANIMBToolStripMenuItem.Name = "SURATKETERANGANIMBToolStripMenuItem"
        Me.SURATKETERANGANIMBToolStripMenuItem.Size = New System.Drawing.Size(156, 20)
        Me.SURATKETERANGANIMBToolStripMenuItem.Text = "SURAT KETERANGAN IMB"
        '
        'PENDAFTARANToolStripMenuItem1
        '
        Me.PENDAFTARANToolStripMenuItem1.Name = "PENDAFTARANToolStripMenuItem1"
        Me.PENDAFTARANToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.PENDAFTARANToolStripMenuItem1.Text = "SK IMB"
        '
        'Form_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1042, 662)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form_utama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "created by ITA ROSITA"
        Me.TransparencyKey = System.Drawing.Color.RoyalBlue
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BERANDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CARIDATAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENGATURANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PENDAFTARANIMBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENDAFTARANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CARIDATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SURATKETERANGANIMBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENDAFTARANToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAKECAMATANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TAMBAHAKUNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UBAHPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
