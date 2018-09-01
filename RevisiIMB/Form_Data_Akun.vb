Imports System.Data.Odbc
Public Class Form_Data_Akun

    Private Sub Form_Data_Akun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form_utama.hakakses = "1" Then
            superuser()
        ElseIf Form_utama.hakakses = "2" Then
            adminoper()
        End If
    End Sub

    Private Sub username_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.SelectedIndexChanged
        If Form_utama.namauser.ToString = username.Text Then
            hapus.Enabled = False
        ElseIf Not Form_utama.namauser.ToString = username.Text Then
            hapus.Enabled = True
        End If
        skoneksi()
        com = New OdbcCommand("select * from user where username ='" & username.Text & "'", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            passskrg.Enabled = False
            passskrg.Text = rd.Item("password")
        End If
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        Dim tanya As String = MsgBox("Apakah anda yakin ingin menghapus Akun " & username.Text & " ?", MsgBoxStyle.YesNo)
        If tanya = vbYes Then
            skoneksi()
            com = New OdbcCommand("delete from user where username ='" & username.Text & "'", con)
            com.ExecuteNonQuery()
            superuser()
            MsgBox("Akun Berhasil Dihapus")
        End If
    End Sub

    Sub superuser()
        Label5.Visible = True
        Label6.Visible = True
        Label2.Visible = False
        Label1.Visible = False
        username.Enabled = True
        skoneksi()
        da = New OdbcDataAdapter("select * from user", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, ("user"))
        username.DataSource = ds.Tables("user")
        username.DisplayMember = "username"
        username.ValueMember = "id_user"
        If Form_utama.namauser.ToString = username.Text Then
            hapus.Enabled = False
        ElseIf Not Form_utama.namauser.ToString = username.Text Then
            hapus.Enabled = True
        End If
    End Sub

    Sub adminoper()
        Label5.Visible = False
        Label6.Visible = False
        Label2.Visible = True
        Label1.Visible = True
        username.Enabled = False
        skoneksi()
        com = New OdbcCommand("select * from user where id_user ='" & Form_utama.id_admin & "'", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            username.Text = rd.Item("username")
        End If
    End Sub

    Private Sub apdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles apdet.Click
            skoneksi()
            com = New OdbcCommand("select * from user where username='" & username.Text & "' and password ='" & passskrg.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
            com = New OdbcCommand("update user set password ='" & ulangpass.Text & "' where username ='" & username.Text & "'", con)
                com.ExecuteReader()
            MsgBox("Password berhasil diubah")
            If Form_utama.hakakses = "1" Then
                superuser()
            ElseIf Form_utama.hakakses = "2" Then
                adminoper()
            End If
            passbaru.Text = Nothing
            ulangpass.Text = Nothing
            ElseIf Not rd.HasRows Then
                MsgBox("Password yg Dimasukan Tidak Cocok")
        End If
    End Sub
End Class