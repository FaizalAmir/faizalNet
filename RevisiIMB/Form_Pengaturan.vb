Imports System.Data.Odbc
Imports System.ComponentModel
Public Class Form_Pengaturan
    Dim kdkecamatan As String
    Dim idstaff As String
    Dim arrimage As Byte()
    Dim myms As IO.MemoryStream
    Dim imgimage As Image
    Dim objbitmap As Bitmap

    Private Sub Form_Pengaturan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama_camat.Enabled = False
        kd_kecamatan.Enabled = False
        kecamatan.Enabled = False
        nip_camat.Enabled = False
        alamat.Enabled = False
        simpan.Enabled = False
        notelp.Enabled = False
        skoneksi()
        da = New OdbcDataAdapter("select * from pengaturan", con)
        ds = New DataSet
        da.Fill(ds, "pengaturan")
        kdkecamatan = ds.Tables("pengaturan").Rows(0).Item("kd_kec").ToString
        nofax.Text = ds.Tables("pengaturan").Rows(0).Item("no_fax").ToString
        kd_pos.Text = ds.Tables("pengaturan").Rows(0).Item("kode_pos").ToString
        kd_kecamatan.Text = ds.Tables("pengaturan").Rows(0).Item("kd_kec").ToString
        kecamatan.Text = ds.Tables("pengaturan").Rows(0).Item("nama_kecamatan").ToString
        notelp.Text = ds.Tables("pengaturan").Rows(0).Item("no_telp").ToString
        alamat.Text = ds.Tables("pengaturan").Rows(0).Item("alamat_kecamatan").ToString
        'Dim lbs() As Byte = ds.Tables(0).Rows(0).Item("logo")
        'myms = New IO.MemoryStream(lbs)
        'PictureBox1.Image = System.Drawing.Bitmap.FromStream(myms)
        'PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        nama_camat.Text = ds.Tables("pengaturan").Rows(0).Item("nama_camat").ToString
        nip_camat.Text = ds.Tables("pengaturan").Rows(0).Item("nip_camat").ToString
    End Sub

    Sub OpenImage()
        OpenFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.gif, *.png, *.ico)|*.jpg;*.gif;*.bmp;*.jpeg;*.png;*.ico"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            Dim img As String = OpenFileDialog1.FileName
            'PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            'PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenImage()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If kd_kecamatan.Enabled = False Then
            nama_camat.Enabled = True
            kd_kecamatan.Enabled = True
            kecamatan.Enabled = True
            alamat.Enabled = True
            nip_camat.Enabled = True
            simpan.Enabled = True
            notelp.Enabled = True
        ElseIf kd_kecamatan.Enabled = True Then
            nama_camat.Enabled = False
            kd_kecamatan.Enabled = False
            kecamatan.Enabled = False
            nip_camat.Enabled = False
            simpan.Enabled = False
            alamat.Enabled = False
            notelp.Enabled = False
        End If
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        'myms = New IO.MemoryStream(100000000)
        'PictureBox1.Image.Save(myms, System.Drawing.Imaging.ImageFormat.Png)
        'arrimage = myms.GetBuffer()
        com = New OdbcCommand("update pengaturan set nama_camat='" & nama_camat.Text & "',nip_camat='" & nip_camat.Text & "', no_fax='" & nofax.Text & "',kd_kec ='" & kd_kecamatan.Text & "', nama_kecamatan ='" & kecamatan.Text & "', alamat_kecamatan ='" & alamat.Text & "',no_telp = '" & notelp.Text & "',kode_pos='" & kd_pos.Text & "' where kd_kec ='" & kdkecamatan & "'", con)
        'com.Parameters.AddWithValue("?", arrimage)
        com.ExecuteNonQuery()
        com = New OdbcCommand("update staff set nama_staff ='" & nama_camat.Text & "', nip_staff ='" & nip_camat.Text & "' where id_staff ='" & idstaff & "'", con)
        com.ExecuteNonQuery()
        MsgBox("berhasil")
    End Sub
End Class