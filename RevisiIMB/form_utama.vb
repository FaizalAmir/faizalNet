Public Class Form_utama
    Public id_admin As String
    Public hakakses As String
    Public namauser As String
    Public titletextdaftar As String = "Form Pendaftaran"
    Public kdkec As String
    Sub lockmenu()
        PENDAFTARANIMBToolStripMenuItem.Enabled = False
        SURATKETERANGANIMBToolStripMenuItem.Enabled = False
        PENGATURANToolStripMenuItem.Enabled = False
        KELUARToolStripMenuItem.Enabled = False
        LOGOUTToolStripMenuItem.Enabled = False
        LOGINToolStripMenuItem.Enabled = True
    End Sub
    Sub formdataimb()
        Dim dataimb As New cari_data_skimb
        dataimb.MdiParent = Me
        dataimb.Dock = DockStyle.Fill
        dataimb.Show()
    End Sub
    Sub skimb()
        For Each frm As Form In Me.MdiChildren
            Me.Text = "Pengisian SKIMB"
            frm.Close()
        Next
        Dim formsk As New skimb
        formsk.MdiParent = Me
        formsk.Dock = DockStyle.Fill
        formsk.Show()
    End Sub
    Sub loginform()
        Dim formlogin As New login
        formlogin.MdiParent = Me
        formlogin.Dock = DockStyle.Fill
        formlogin.Show()
    End Sub
    Sub formdaftar()
        For Each frm As Form In Me.MdiChildren
            Me.Text = "Pendaftaran"
            frm.Close()
        Next
        Dim daftarform As New pendaftaran
        daftarform.MdiParent = Me
        daftarform.Dock = DockStyle.Fill
        daftarform.Show()

    End Sub
    Sub formcaridatadaftar()
        Dim caridata As New cari_data_daftar
        caridata.MdiParent = Me
        caridata.Dock = DockStyle.Fill
        caridata.Show()
    End Sub
    Sub homeberanda()
        Dim beranda1 As New beranda
        beranda1.MdiParent = Me
        beranda1.Dock = DockStyle.Fill
        beranda1.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            Me.Text = "LOGIN"
            frm.Close()
        Next
        loginform()
    End Sub
    Private Sub Form_utamain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        homeberanda()
        lockmenu()
        Dim txtvalue As String = ToolStripStatusLabel1.Text
        
    End Sub

    Private Sub PENDAFTARANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENDAFTARANToolStripMenuItem.Click
        formdaftar()
    End Sub

    Private Sub CARIDATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARIDATAToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            Me.Text = "Pencarian Data Pendaftaran"
            frm.Close()
        Next
        formcaridatadaftar()
    End Sub
    Private Sub BERANDAToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BERANDAToolStripMenuItem.Click
        For Each frm As Form In Me.MdiChildren
            Me.Text = "Beranda"
            frm.Close()
        Next
        homeberanda()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Dim pesan As String = MsgBox("Yakin ingin Logout", vbYesNo + MsgBoxStyle.Information)
        If pesan = vbYes Then
            ToolStripStatusLabel1.Text = "-"
            ToolStripStatusLabel2.Text = "-"
            statuslabel.Text = "-"
            StatusStrip1.Text = "-"
            login.pass.Text = ""
            login.user.Text = ""
            lockmenu()
            homeberanda()
            loginform()
        End If
    End Sub

    Private Sub PENDAFTARANToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENDAFTARANToolStripMenuItem1.Click
        skimb()
    End Sub

    Private Sub CARIDATAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARIDATAToolStripMenuItem1.Click
        For Each frm As Form In Me.MdiChildren
            Me.Text = "Cari Data SKIMB"
            frm.Close()
        Next
        formdataimb()
    End Sub

    Private Sub PENGATURANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENGATURANToolStripMenuItem.Click

    End Sub

    Private Sub DATAKECAMATANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAKECAMATANToolStripMenuItem.Click
        Form_Pengaturan.ShowDialog()
    End Sub

    Private Sub TAMBAHAKUNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAMBAHAKUNToolStripMenuItem.Click
        Form_tambah_akun.ShowDialog()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UBAHPASSWORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UBAHPASSWORDToolStripMenuItem.Click
        Form_Data_Akun.ShowDialog()
    End Sub
End Class