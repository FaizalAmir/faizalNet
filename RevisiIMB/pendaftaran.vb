Imports ThoughtWorks.QRCode.Codec
Imports System.Data.Odbc
Public Class pendaftaran
    Public updatedata As Boolean
    Dim pembaru As Boolean
    Dim dafbaru As Boolean
    Dim arrimage As Byte()
    Dim myms As IO.MemoryStream
    Dim objqrcode As QRCodeEncoder
    Dim imgimage As Image
    Dim objbitmap As Bitmap
    Dim noauto As String
    Dim mydate As DateTime = Now
    Dim myyear As String = mydate.Year
    Dim no As Integer
    Dim filename As String
    Dim no_bapl As String
    Dim namastaff As String
    Dim stst As String
    Dim s_noktp As String
    Dim untuk As String
    Dim kdkec As String

    Public Sub cek_kdkec()
        skoneksi()
        com = New OdbcCommand("select * from pengaturan limit 1", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            kdkec = rd.Item("kd_kec")
        End If
    End Sub

    Public Sub autonum_daftar()
        Call skoneksi()
        com = New OdbcCommand("select * from sk_pendaftaran order by no_daftar desc", con)
        rd = com.ExecuteReader
        rd.Read()

        'If Not rd.HasRows Then
        '    cekno.Text = "640/001- " + kdkec + "/" + Format(Now, "yyyy")
        'ElseIf rd.HasRows Then
        '    Dim auto_num As String
        '    Dim str_num As String
        '    Dim panjang As String
        '    Dim year_str As Date = rd.Item("tgl_daftar")
        '    If Not Format(year_str, "yyyy") = Format(Now, "yyyy") Then
        '        cekno.Text = "640/001- " + kdkec + "/" + Format(Now, "yyyy")
        '    Else
        '        str_num = Microsoft.VisualBasic.Mid(rd.Item("no_daftar"), 5, 3)
        '        auto_num = Val(str_num) + 1
        '        panjang = auto_num.Length
        '        If panjang = 1 Then
        '            cekno.Text = "640/" + Mid("00", 1, 4 - auto_num.Length) & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
        '        ElseIf panjang = 2 Then
        '            cekno.Text = "640/" + Mid("0", 1, 4 - auto_num.Length) & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
        '        ElseIf panjang = 3 Then
        '            cekno.Text = "640/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
        '            'ElseIf panjang = 4 Then
        '            '    cekno.Text = "640/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
        '        End If

        '    End If
        'End If

        If Not rd.HasRows Then
            cekno.Text = "640/01- " + kdkec + "/" + Format(Now, "yyyy")
        ElseIf rd.HasRows Then
            Dim auto_num As String
            Dim str_num As String
            Dim panjang As String
            Dim year_str As Date = rd.Item("tgl_daftar")
            If Not Format(year_str, "yyyy") = Format(Now, "yyyy") Then
                cekno.Text = "640/01- " + kdkec + "/" + Format(Now, "yyyy")
            Else
                str_num = Microsoft.VisualBasic.Mid(rd.Item("no_daftar"), 5, 2)
                auto_num = Val(str_num) + 1
                panjang = auto_num.Length
                If panjang = 1 Then
                    cekno.Text = "640/" + Mid("0", 1, 3 - auto_num.Length) & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                ElseIf panjang = 2 Then
                    cekno.Text = "640/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                    'ElseIf panjang = 3 Then
                    '    cekno.Text = "640/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                    'ElseIf panjang = 4 Then
                    '    cekno.Text = "640/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                End If

            End If
        End If
    End Sub
    Sub clean()
        cekno.Text = ""
        napem.Text = ""
        alamat_pem.Text = ""
        peruntukan.Text = ""
        jenisusaha.Text = ""
        Ket.Text = ""
        deskel.Text = ""
        lt.Text = ""
        lb.Text = ""
        alamatijin.Text = ""
        noktp.Text = ""
        PictureBox1.Image = Nothing
        noktp.Enabled = True
        cekktp.Enabled = True
        cekno.Enabled = False
        DateTimePicker1.Enabled = False
        napem.Enabled = False
        alamat_pem.Enabled = False
        peruntukan.Enabled = False
        jenisusaha.Enabled = False
        Ket.Enabled = False
        deskel.Enabled = False
        lt.Enabled = False
        lb.Enabled = False
        alamatijin.Enabled = False
    End Sub
    Sub disabletext()
        noktp.Enabled = True
        DateTimePicker1.Enabled = True
        cekktp.Enabled = True
        cekno.Enabled = False
        napem.Enabled = False
        alamat_pem.Enabled = False
        peruntukan.Enabled = False
        jenisusaha.Enabled = False
        Ket.Enabled = False
        deskel.Enabled = False
        lt.Enabled = False
        lb.Enabled = False
        alamatijin.Enabled = False
    End Sub
    Sub fordatapem_on()
        noktp.Enabled = False
        napem.Enabled = True
        alamat_pem.Enabled = True
    End Sub

    Sub fordatapem_off()
        noktp.Enabled = False
        napem.Enabled = False
        alamat_pem.Enabled = False
    End Sub

    Sub enabledtext()
        peruntukan.Enabled = True
        Ket.Enabled = True
        deskel.Enabled = True
        lt.Enabled = True
        lb.Enabled = True
        alamatijin.Enabled = True
        cekno.Enabled = False
        napem.Enabled = True
        alamat_pem.Enabled = True
    End Sub

    Sub forupdatedata()
        noktp.Enabled = False
        cekktp.Enabled = False
        peruntukan.Enabled = True
        Ket.Enabled = True
        deskel.Enabled = True
        lt.Enabled = True
        lb.Enabled = True
        alamatijin.Enabled = True
        cekno.Enabled = False
    End Sub

    Private Sub pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        login.penerbit = namastaff
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Call cek_kdkec()

        If updatedata = True Then
            skoneksi()
            com = New OdbcCommand("select sk_pendaftaran.no_daftar, sk_pendaftaran.no_ktp, sk_pendaftaran.tgl_daftar, sk_pendaftaran.jenis_ijin, sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.luas_tanah, sk_pendaftaran.luas_bangunan, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel, pemohon.nama_pemohon, pemohon.alamat_pemohon, sk_pendaftaran.qrcode_daftar, sk_pendaftaran.keterangan from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.no_daftar ='" & cekno.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                cekno.Text = rd.Item("no_daftar")
                noktp.Text = rd.Item("no_ktp")
                s_noktp = rd.Item("no_ktp")
                napem.Text = rd.Item("nama_pemohon")
                alamat_pem.Text = rd.Item("alamat_pemohon")
                peruntukan.Text = rd.Item("peruntukan")
                Ket.Text = rd.Item("keterangan")
                jenisijin.Text = rd.Item("jenis_ijin")
                jenisusaha.Text = rd.Item("jenis_usaha")
                lt.Text = rd.Item("luas_tanah")
                lb.Text = rd.Item("luas_bangunan")
                alamatijin.Text = rd.Item("alamat_ijin")
                deskel.Text = rd.Item("ds_kel")
                DateTimePicker1.Value = rd.Item("tgl_daftar")
                da = New OdbcDataAdapter("select * from sk_pendaftaran where no_daftar ='" & cekno.Text & "'", con)
                ds = New DataSet
                da.Fill(ds, "sk_pendaftaran")
                Dim lbs() As Byte = ds.Tables(0).Rows(0).Item("qrcode_daftar")
                Dim lstr As New System.IO.MemoryStream(lbs)
                PictureBox1.Image = Image.FromStream(lstr)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                lstr.Close()
                Dim messagebox As String = MsgBox("Ingin Ubah Data Juga", vbYesNo + MsgBoxStyle.Information)
                If messagebox = vbYes Then
                    forupdatedata()
                    noktp.Enabled = True
                ElseIf messagebox = vbNo Then
                    disabletext()
                    noktp.Enabled = False
                    cekktp.Enabled = False
                    DateTimePicker1.Enabled = False
                End If
            End If
        End If
        Call autonum_daftar()
    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click

        Call skoneksi()
        If cekno.Text = "" Or noktp.Text = "" Or napem.Text = "" Or Ket.Text = "" Or alamat_pem.Text = "" Or alamatijin.Text = "" Or deskel.Text = "" Or peruntukan.Text = "" Then
            MsgBox("Data pendaftaran belum lengkap !")
        ElseIf Not IsNumeric(noktp.Text) Then
            MsgBox("No.KTP harus angka")
        ElseIf Not IsNumeric(lt.Text) Then
            MsgBox("Luas Harus Angka!")
            lt.BackColor = Color.Red
        ElseIf Not IsNumeric(lb.Text) Then
            MsgBox("Luas Harus Angka!")
        ElseIf lt.Text = "0" Then
            MsgBox("Luas Bangunan dan Tanah tidak boleh kosong")
        ElseIf lb.Text = "0" Then
            MsgBox("Luas Bangunan dan Tanah tidak boleh kosong")
        ElseIf updatedata = True Then
            com = New OdbcCommand("update sk_pendaftaran set no_ktp = '" & noktp.Text & "', kd_kec = '" & kdkec & "', tgl_daftar ='" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "', jenis_ijin = '" & jenisijin.Text & "', peruntukan = '" & peruntukan.Text & "', jenis_usaha = '" & jenisusaha.Text & "', luas_tanah = '" & lt.Text & "', luas_bangunan = '" & lb.Text & "', keterangan = '" & Ket.Text & "', alamat_ijin =  '" & alamatijin.Text & "', diinputoleh ='" & Form_utama.ToolStripStatusLabel1.Text & "', ds_kel = '" & deskel.Text & "' where no_daftar = '" & cekno.Text & "'", con)
            com.ExecuteNonQuery()
            com = New OdbcCommand("update pemohon set no_ktp ='" & noktp.Text & "', nama_pemohon = '" & napem.Text & "', alamat_pemohon = '" & alamat_pem.Text & "' where no_ktp = '" & s_noktp & "'", con)
            com.ExecuteNonQuery()
            MsgBox("Data Berhasil DiPerbaharui", MsgBoxStyle.Information)
            Form_utama.formcaridatadaftar()
        ElseIf updatedata = False Then
            filename = DateTimePicker1.Value.ToString("yyyyMMddHHmmss")
            objqrcode = New QRCodeEncoder
            objqrcode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            objqrcode.QRCodeScale = 2
            objqrcode.QRCodeVersion = 5
            objqrcode.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L
            imgimage = objqrcode.Encode(cekno.Text + " user oleh " + Form_utama.ToolStripStatusLabel1.Text)
            objbitmap = New Bitmap(imgimage)
            Dim imagepath As String = Application.ExecutablePath.Replace("RevisiIMB.EXE", "")
            'objbitmap.Save("c:\test.tiff", filename & "QRDAFTAR.jpeg")
            objbitmap.Save("" & filename & "QRDAFTAR.jpeg", Imaging.ImageFormat.Jpeg)
            myms = New IO.MemoryStream
            PictureBox1.Image = Image.FromFile("" & filename & "QRDAFTAR.jpeg")
            PictureBox1.Image.Save(myms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = myms.GetBuffer()
            com = New OdbcCommand("insert into sk_pendaftaran values ('" & cekno.Text & "','" & noktp.Text & "','" & kdkec & "', '" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "', '" & jenisijin.Text & "', '" & peruntukan.Text & "', '" & jenisusaha.Text & "', '" & lt.Text & "', '" & lb.Text & "', '" & Ket.Text & "', '" & alamatijin.Text & "', '" & deskel.Text & "', ?, '" & Form_utama.ToolStripStatusLabel1.Text & "','1')", con)
            com.Parameters.AddWithValue("?", arrimage)
            com.ExecuteNonQuery()
            If pembaru = False Then
                com = New OdbcCommand("insert into pemohon values ('" & noktp.Text & "', '" & napem.Text & "','" & alamat_pem.Text & "')", con)
                com.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
                clean()
                Form_utama.formdaftar()
            ElseIf pembaru = True Then
                com = New OdbcCommand("update pemohon set no_ktp ='" & noktp.Text & "', nama_pemohon = '" & napem.Text & "', alamat_pemohon = '" & alamat_pem.Text & "' where no_ktp = '" & s_noktp & "'", con)
                com.ExecuteNonQuery()
                MsgBox("Data Berhasil DiPerbaharui", MsgBoxStyle.Information)
                clean()
                Form_utama.formdaftar()
            End If
        End If
    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        clean()
    End Sub

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX---Code Untuk Cek No.KTP---XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Sub ceknoidpem()
        If noktp.Text = "" Then
            MsgBox("Masukan nomor KTP terlebih dahulu")
        ElseIf Not IsNumeric(noktp.Text) Then
            MsgBox("No.ID Harus Angka")
        Else
            skoneksi()
            com = New OdbcCommand("select * from pemohon where no_ktp = '" & noktp.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                napem.Text = rd.Item("nama_pemohon")
                alamat_pem.Text = rd.Item("alamat_pemohon")
                Dim pesan As String = MsgBox(" Sudah Pernah Mendaftar ")
                fordatapem_on()
                enabledtext()
                pembaru = True
            ElseIf rd.HasRows = 0 Then
                pembaru = False
                fordatapem_on()
                enabledtext()
            End If
        End If
    End Sub

    Private Sub noktp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles noktp.KeyPress
        If e.KeyChar = Chr(13) Then
            ceknoidpem()
        End If
    End Sub
    Private Sub cekktp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cekktp.Click
        ceknoidpem()
    End Sub

    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX---Menampilkan Gambar Salah/Benar Pada Pengisian Teks No.ktp---XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
    Private Sub noktp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noktp.TextChanged
        If Not IsNumeric(noktp.Text) Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        ElseIf IsNumeric(noktp.Text) Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        End If
        If noktp.Text = "" Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
        End If
    End Sub
End Class
