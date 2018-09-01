Imports System.Data.Odbc
Public Class login
    Public penerbit As String
    Dim namastaff As String
    Public hakakses As String

    Sub openadm()
        Form_utama.PENDAFTARANIMBToolStripMenuItem.Enabled = True
        Form_utama.SURATKETERANGANIMBToolStripMenuItem.Enabled = True
        Form_utama.PENGATURANToolStripMenuItem.Enabled = True
        Form_utama.KELUARToolStripMenuItem.Enabled = True
        Form_utama.LOGOUTToolStripMenuItem.Enabled = True
        Form_utama.PENGATURANToolStripMenuItem.Enabled = True
    End Sub
    Sub openopr()
        Form_utama.PENDAFTARANIMBToolStripMenuItem.Enabled = True
        Form_utama.SURATKETERANGANIMBToolStripMenuItem.Enabled = True
        Form_utama.PENGATURANToolStripMenuItem.Enabled = True
        Form_utama.KELUARToolStripMenuItem.Enabled = True
        Form_utama.LOGOUTToolStripMenuItem.Enabled = True
        Form_utama.TAMBAHAKUNToolStripMenuItem.Enabled = False
        Form_utama.DATAKECAMATANToolStripMenuItem.Enabled = False
        Form_utama.CARIDATAToolStripMenuItem1.Enabled = True
        cari_data_daftar.Button4.Enabled = False
        cari_data_skimb.Button4.Enabled = False
    End Sub
    Sub login()
        Call skoneksi()
        pass.UseSystemPasswordChar = True
        If user.Text = "" Or pass.Text = "" Then
            MsgBox("Silahkan Masukan Username & Password Dahulu!", MsgBoxStyle.Information)
        Else
            com = New OdbcCommand("select * from user where username = '" & user.Text & "' and password = '" & pass.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Selamat Datang " & rd.Item("username") & " !")
                Form_utama.id_admin = rd.Item("id_user")
                Form_utama.hakakses = rd.Item("tipe_user")
                Form_utama.namauser = rd.Item("username")
                Form_utama.statuslabel.Text = rd.Item("tipe_user")
                hakakses = rd.Item("tipe_user")
                namastaff = rd.Item("id_staff")
                If hakakses = "1" Then
                    openadm()
                    Form_utama.ToolStripStatusLabel2.Text = "ADMIN"
                ElseIf hakakses = "2" Then
                    openopr()
                End If
                com = New OdbcCommand("select * from staff where id_staff ='" & namastaff & "'", con)
                rd = com.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Form_utama.ToolStripStatusLabel1.Text = rd.Item("nama_staff")
                End If
                Form_utama.homeberanda()
                Form_utama.LOGINToolStripMenuItem.Enabled = False
            Else
                MsgBox("Username & Password Anda Salah !!", MsgBoxStyle.Information)
                user.Text = ""
                pass.Text = ""
            End If
        End If
    End Sub
    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        login()
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        pass.UseSystemPasswordChar = True
    End Sub

    Private Sub pass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pass.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            login()
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class