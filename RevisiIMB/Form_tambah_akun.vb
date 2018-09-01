Imports System.Data.Odbc
Public Class Form_tambah_akun
    Dim nostaff As String
    Dim akses As String
    Sub idstaff()
        Call skoneksi()
        com = New OdbcCommand("select * from staff order by id_staff desc", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            nostaff = rd.Item("id_staff")
        End If
    End Sub

    Private Sub Form_tambah_akun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        salah.Visible = False
        betul.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        idstaff()
    End Sub

    Private Sub SIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMPAN.Click
        If nip.Text = "" Then
            nip.Text = "0"
        End If
        If napeng.Text = "" Or nm_satff.Text = "" Or sandi.Text = "" Or ulang_sandi.Text = "" Or hak_akses.Text = "" Then
            MsgBox("isi yg lengkap")
        ElseIf Not sandi.Text = ulang_sandi.Text Then
            MsgBox("ulang sandi")
        Else
            Call skoneksi()
            com = New OdbcCommand("select * from user where username ='" & napeng.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("username sudah digunakan")
                napeng.Text = ""
            ElseIf Not rd.HasRows Then
                com = New OdbcCommand("insert into staff values(null,'" & nm_satff.Text & "','" & nip.Text & "')", con)
                com.ExecuteNonQuery()
                idstaff()
                If hak_akses.Text = "Administrator" Then
                    akses = "1"
                ElseIf hak_akses.Text = "Operator" Then
                    akses = "2"
                End If
                com = New OdbcCommand("insert into user values(null,'" & napeng.Text & "','" & sandi.Text & "','" & nostaff & "','" & akses & "')", con)
                com.ExecuteReader()
                MsgBox("Akun Berhasil Dibuat")
                bersih()
            End If
        End If

    End Sub

    Private Sub napeng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles napeng.TextChanged
        com = New OdbcCommand("select * from user where username ='" & napeng.Text & "'", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            salah.Visible = True
            betul.Visible = False
        ElseIf rd.HasRows = 0 Then
            betul.Visible = True
            salah.Visible = False
        End If
        If napeng.Text = "" Then
            salah.Visible = False
            betul.Visible = False
        End If
    End Sub

    Private Sub ulang_sandi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulang_sandi.TextChanged
        If ulang_sandi.Text = sandi.Text Then
            PictureBox2.Visible = True
            PictureBox1.Visible = False
        Else
            PictureBox2.Visible = False
            PictureBox1.Visible = True
        End If
        If ulang_sandi.Text = "" Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
        End If
    End Sub

    Sub bersih()
        nm_satff.Text = Nothing
        nip.Text = Nothing
        napeng.Text = Nothing
        sandi.Text = Nothing
        ulang_sandi.Text = Nothing
    End Sub

End Class