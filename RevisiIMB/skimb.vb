Imports System.Data.Odbc
Imports ThoughtWorks.QRCode.Codec
Public Class skimb
    Public updateimb As Boolean
    Dim imblama As String
    Dim siteplant As String
    Dim gambar As String
    Dim almtbangun As String
    Dim almtpem As String
    Dim pembaru As Boolean
    Dim dafbaru As Boolean
    Dim kdkec As String
    Dim arrimage As Byte()
    Dim myms As IO.MemoryStream
    Dim objqrcode As QRCodeEncoder
    Dim imgimage As Image
    Dim objbitmap As Bitmap
    Dim mydate As DateTime = Now
    Dim myyear As String = mydate.Year
    Dim no As Integer
    Public tidak_ada_noimblama As Boolean
    Dim codedaftar As String = "640/"
    Dim kec As String = "- Kec. Pgd/"
    Dim codepaper As String = "648/"
    Dim numbapl As Integer
    Dim namafile As String
    Dim nopendaftaran As String

    Public Sub cek_kdkec()
        skoneksi()
        com = New OdbcCommand("select * from pengaturan limit 1", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            kdkec = rd.Item("kd_kec")
        End If
    End Sub

    Sub autonum()
        Call skoneksi()
        com = New OdbcCommand("select * from sk_imb where peruntukan ='" & peruntukan.Text & "' order by nosurat desc", con)
        rd = com.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            If peruntukan.Text = "Ruko" Then
                nosk.Text = "644/01- " + kdkec + "/" + Format(Now, "yyyy")
            Else
                nosk.Text = "648/01- " + kdkec + "/" + Format(Now, "yyyy")
            End If
        ElseIf rd.HasRows Then
            Dim panjang As String
            Dim auto_num As String
            Dim str_num As String
            Dim year_str As Date = rd.Item("tglterbit")
            If Not Format(year_str, "yyyy") = Format(Now, "yyyy") Then
                If peruntukan.Text = "Ruko" Then
                    nosk.Text = "644/01- " + kdkec + "/" + Format(Now, "yyyy")
                Else
                    nosk.Text = "648/01- " + kdkec + "/" + Format(Now, "yyyy")
                End If
            Else
                If peruntukan.Text = "Ruko" Then
                    str_num = Microsoft.VisualBasic.Mid(rd.Item("nosurat"), 5, 2)
                    auto_num = Val(str_num) + 1
                    panjang = auto_num.Length
                    If panjang = 1 Then
                        nosk.Text = "644/" + Mid("0", 1, 3 - auto_num.Length) & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                    ElseIf panjang = 2 Then
                        nosk.Text = "644/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                        'ElseIf panjang = 3 Then
                        '    nosk.Text = "644/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                        'ElseIf panjang = 2 Then
                        '    nosk.Text = "644/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                    End If
                Else
                    str_num = Microsoft.VisualBasic.Mid(rd.Item("nosurat"), 5, 2)
                    auto_num = Val(str_num) + 1
                    panjang = auto_num.Length
                    If panjang = 1 Then
                        nosk.Text = "648/" + Mid("0", 1, 3 - auto_num.Length) & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                    ElseIf panjang = 2 Then
                        nosk.Text = "648/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                        'ElseIf panjang = 3 Then
                        '    nosk.Text = "648/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                        'ElseIf panjang = 4 Then
                        '    nosk.Text = "648/" & auto_num + "- " + kdkec + "/" + Format(Now, "yyyy")
                    End If
                End If
            End If
        End If
    End Sub

    Sub cek_ket()
        If rd.Item("keterangan") = "Baru" Then
            texbox_baru()
        Else
            textbox_penambahan()
        End If
    End Sub

    Sub cekno()
        Call skoneksi()
        com = New OdbcCommand("select sk_pendaftaran.no_daftar, sk_pendaftaran.peruntukan, sk_pendaftaran.keterangan, sk_pendaftaran.tgl_daftar, pemohon.alamat_pemohon, pemohon.nama_pemohon from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.no_daftar = '" & nodaftar.Text & "'", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            asdasd.Text = rd.Item("nama_pemohon")
            DateTimePicker1.Value = rd.Item("tgl_daftar")
            qweqwe.Text = rd.Item("alamat_pemohon")
            test12.Text = rd.Item("keterangan")
            ketper.Text = rd.Item("peruntukan")
            tglterbit.Enabled = True
        End If
    End Sub
    Sub bersih()
        nobapl.Text = ""
        tglbapl.Text = ""
        notanah.Text = ""
        tanahjenis.Text = ""
        namatanah.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        nobayar.Text = ""
        nodaftar.Text = ""
        noimblama.Text = ""
        nosk.Text = ""
        qweqwe.Text = qweqwe.Text
        asdasd.Text = asdasd.Text
        test12.Text = test12.Text
        ketper.Text = ""
        alamatpem.Text = Nothing
        labnapem.Text = Nothing
        peruntukan.Text = Nothing
    End Sub
    Sub disabletext()
        ketper.Enabled = False
        nosk.Enabled = False
        tglterbit.Enabled = False
        notanah.Enabled = False
        tanahjenis.Enabled = False
        namatanah.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        simpan.Enabled = False
    End Sub
    Sub enabletext()
        nobapl.Enabled = True
        tglbapl.Enabled = True
        notanah.Enabled = True
        tanahjenis.Enabled = True
        namatanah.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        simpan.Enabled = True
    End Sub

    Sub nourut()
        Call skoneksi()
        com = New OdbcCommand("select * from sk_imb where no_daftar ='" & nodaftar.Text & "'", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("SKIMB sudah dibuat")
            nodaftar.Text = ""
        ElseIf Not rd.HasRows Then
            Call skoneksi()
            com = New OdbcCommand("select * from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.no_daftar = '" & nodaftar.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                almtbangun = rd.Item("alamat_ijin")
                labnapem.Text = rd.Item("nama_pemohon")
                DateTimePicker1.Value = rd.Item("tgl_daftar")
                alamatpem.Text = rd.Item("alamat_pemohon")
                peruntukan.Text = rd.Item("keterangan")
                ketper.Text = rd.Item("peruntukan")
                fordatask_on()
                com = New OdbcCommand("select count(nosurat) from sk_imb where year(tglterbit) = '" & myyear & "'", con)
                rd = com.ExecuteReader()
                rd.Read()
                If Not rd.HasRows Then
                    no = 1
                    nosk.Text = codepaper + no.ToString("00") + kec + myyear
                Else
                    no = rd.Item(0) + 1
                    nosk.Text = codepaper + no.ToString("00") + kec + myyear
                    For index As Integer = 1 To 9
                        com = New OdbcCommand("select * from sk_imb where nosurat = '" & nosk.Text & "'", con)
                        rd = com.ExecuteReader()
                        rd.Read()
                        If Not rd.HasRows Then
                            Exit For
                        Else
                            no = no + 1
                            nosk.Text = codepaper + no.ToString("00") + kec + myyear
                        End If
                    Next
                End If
                com = New OdbcCommand("select count(nobapl) from sk_imb where year(tglbapl) ='" & myyear & "'", con)
                rd = com.ExecuteReader
                rd.Read()
                If Not rd.HasRows Then
                    numbapl = 1
                    nobapl.Text = numbapl.ToString("00")
                Else
                    numbapl = rd.Item(0) + 1
                    nobapl.Text = numbapl.ToString("00")
                    For Index As Integer = 1 To 9
                        com = New OdbcCommand("select * from sk_imb where nobapl ='" & nobapl.Text & "'", con)
                        rd = com.ExecuteReader
                        rd.Read()
                        If Not rd.HasRows Then
                            Exit For
                        Else
                            numbapl = numbapl + 1
                            nobapl.Text = numbapl.ToString("00")
                        End If
                    Next
                End If
            ElseIf Not rd.HasRows Then
                MsgBox("No Pendaftaran Tidak Ditemukan")
                nodaftar.text = ""
            End If
        End If
    End Sub

    Private Sub skimb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cek_kdkec()
        If updateimb = True Then
            skoneksi()
            com = New OdbcCommand("select * from sk_pendaftaran inner join sk_imb on sk_pendaftaran.no_daftar = sk_imb.no_daftar inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where nosurat ='" & nosk.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                Dim no_imblama As String
                da = New OdbcDataAdapter("select * from sk_imb where nosurat ='" & nosk.Text & "'", con)
                ds = New DataSet
                da.Fill(ds, "sk_imb")
                Dim lbs() As Byte = ds.Tables(0).Rows(0).Item("qrskimb")
                Dim lstr As New System.IO.MemoryStream(lbs)
                PictureBox1.Image = Image.FromStream(lstr)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                lstr.Close()
                'TextBox1.Text = rd.Item("lt1")
                'TextBox2.Text = rd.Item("lt2")
                'TextBox3.Text = rd.Item("teras")
                'TextBox4.Text = rd.Item("carport")
                'TextBox5.Text = rd.Item("balkon")
                'TextBox6.Text = rd.Item("pagar")
                'TextBox7.Text = rd.Item("septic")
                tglterbit.Value = rd.Item("tglterbit")
                nobapl.Text = rd.Item("nobapl")
                tglbapl.Value = rd.Item("tglbapl")
                tanahjenis.Text = rd.Item("jenistananh")
                notanah.Text = rd.Item("notanah")
                namatanah.Text = rd.Item("namatanah")
                nodaftar.Text = rd.Item("no_daftar")
                tglbayar.Text = rd.Item("tglpembayaran")
                nobayar.Text = rd.Item("nopembayaran")
                alamatpem.Text = rd.Item("alamat_pemohon")
                labnapem.Text = rd.Item("nama_pemohon")
                peruntukan.Text = rd.Item("peruntukan")
                ketper.Text = rd.Item("keterangan")
                Label_imb.Text = "Masukan IMB Baru"
                label_penambahan.Text = "Masukan Penambahan"
                If rd.Item("imblama") = "Terlampir" Then
                    CheckBox1.Checked = True
                    noimblama.Text = rd.Item("noimblama")
                    tglimblama.Value = rd.Item("tglimblama")
                    teksubh1.Enabled = True
                    teksubh2.Enabled = True
                    teksubh3.Enabled = True
                    teksubh4.Enabled = True
                    teksubh5.Enabled = True
                    teksubh6.Enabled = True
                    teksubh7.Enabled = True
                    teksubh8.Enabled = True
                    teksubh9.Enabled = True
                Else
                    teksubh1.Enabled = False
                    teksubh2.Enabled = False
                    teksubh3.Enabled = False
                    teksubh4.Enabled = False
                    teksubh5.Enabled = False
                    teksubh6.Enabled = False
                    teksubh7.Enabled = False
                    teksubh8.Enabled = False
                    teksubh9.Enabled = False
                    CheckBox1.Checked = False
                End If
                If rd.Item("status") = "Balik Nama" Then
                    blk_nama.Checked = True
                Else
                    blk_nama.Checked = False
                End If
                If rd.Item("siteplant") = "Terlampir" Then
                    CheckBox2.Checked = True
                Else
                    CheckBox2.Checked = False
                End If
                If rd.Item("gambar") = "Terlampir" Then
                    CheckBox3.Checked = True
                Else
                    CheckBox3.Checked = False
                End If
                'Dim pesan As String = MsgBox("Ingin Ubah Data Juga?", vbYesNo + MsgBoxStyle.Information)
                'If pesan = vbYes Then
                '    fordatask_on()
                '    updateimb = True
                'ElseIf pesan = vbNo Then
                '    fordatask_off()
                '    updateimb = False
                '    'Form_utama.formdataimb()
                'End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox1.Checked = True Then
            GroupBox6.Enabled = True
        Else
            GroupBox6.Enabled = False
        End If
    End Sub

    Private Sub apdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        skoneksi()
        com = New OdbcCommand("update sk_imb set tgldaftar ='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', tglterbit ='" & tglterbit.Value.ToString("yyyy-MM-dd") & "', lt1 ='" & TextBox1.Text & "', lt2 ='" & TextBox2.Text & "', teras ='" & TextBox3.Text & "', carport ='" & TextBox4.Text & "', balkon ='" & TextBox5.Text & "', septic ='" & TextBox7.Text & "', pagar ='" & TextBox6.Text & "', jenistananh ='" & tanahjenis.Text & "', notanah ='" & notanah.Text & "', namatanah ='" & namatanah.Text & "',tglimblama ='" & tglimblama.Value.ToString("yyyy-MM-dd") & "' tglpembayaran ='" & tglbayar.Value.ToString("yyyy-MM-dd") & "', noimblama ='" & noimblama.Text & "',tglbapl ='" & tglbapl.Value.ToString("yyyy-MM-dd") & "', siteplant ='" & siteplant & "', gambar ='" & gambar & "'", con)
        com.ExecuteNonQuery()
    End Sub

    Private Sub nosk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nosk.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            skoneksi()
            com = New OdbcCommand("select * from sk_imb where nosuratdaftar ='" & nosk.Text & "'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows() Then
                MsgBox("No " & rd.Item("nosuratdaftar") & " sudah terdaftar")
            Else
                enabletext()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        If updateimb = True Then
            Form_utama.formdataimb()
        ElseIf updateimb = False Then
            bersih()
        End If
    End Sub

    Sub fordatask_off()
        labnapem.Enabled = False
        alamatpem.Enabled = False
        DateTimePicker1.Enabled = False
        peruntukan.Enabled = False
        ketper.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox7.Enabled = False
        TextBox4.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        tanahjenis.Enabled = False
        notanah.Enabled = False
        namatanah.Enabled = False
        noimblama.Enabled = False
        tglimblama.Enabled = False
        nobayar.Enabled = False
        tglbayar.Enabled = False
        tglbapl.Enabled = False
        nosk.Enabled = False
        tglterbit.Enabled = False
        nodaftar.Enabled = True
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        nobapl.Enabled = False
        simpan.Enabled = False
        GroupBox6.Enabled = False
    End Sub

    Sub fordatask_on()
        ceknosk.Enabled = False
        labnapem.Enabled = False
        alamatpem.Enabled = False
        DateTimePicker1.Enabled = False
        peruntukan.Enabled = False
        ketper.Enabled = False
        
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox7.Enabled = True
        TextBox4.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        tanahjenis.Enabled = True
        notanah.Enabled = True
        namatanah.Enabled = True
        noimblama.Enabled = True
        tglimblama.Enabled = True
        nobayar.Enabled = True
        tglbayar.Enabled = True
        tglbapl.Enabled = True
        nosk.Enabled = False
        tglterbit.Enabled = True
        nodaftar.Enabled = False
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        nobapl.Enabled = False
        simpan.Enabled = True
    End Sub

    Private Sub ceknosk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceknosk.Click
        cari()
    End Sub
    Sub rincianbangunancarapintar()
        Dim query As String
        query = "insert rinci_bangunan values "
        For i As Integer = 1 To 7
            Dim testString As String = "TextBox" + i.ToString
            Dim teststring1 As String = "Label" + i.ToString
            Dim teststring2 As String = "teksubh" + i.ToString
            Dim TB As TextBox = Nothing
            Dim TB1 As Label = Nothing
            Dim TB2 As TextBox = Nothing
            Dim Ctr As Control = Controls(testString)
            Dim Ctr1 As Control = Controls(teststring1)
            Dim Ctr2 As Control = Controls(teststring2)
            If TypeOf Ctr Is TextBox Then
                TB = DirectCast(Ctr, TextBox)
            End If
            If TypeOf Ctr1 Is Label Then
                TB1 = DirectCast(Ctr1, Label)
            End If
            If TypeOf Ctr2 Is TextBox Then
                TB2 = DirectCast(Ctr2, TextBox)
            End If
            If TB IsNot Nothing Then
                If ketper.Text = "Baru" Then
                    If Not Ctr.Text = Nothing Then

                    End If
                ElseIf ketper.Text = "Penambahan/Balik Nama" Then

                End If

            End If
        Next
    End Sub

    Sub rincianbangunan()
        Dim str As String = noimblama.Text
        If ketper.Text = "Baru" Then
            Dim calc As Integer = 9
            For value As Integer = 1 To calc
                Dim testString As String = "TextBox" + value.ToString
                Dim teststring1 As String = "Label" + value.ToString
                Dim teststring2 As String = "teksubh" + value.ToString
                Dim TB As TextBox = Nothing
                Dim TB1 As Label = Nothing
                Dim TB2 As TextBox = Nothing
                Dim Ctr As Control = Controls(testString)
                Dim Ctr1 As Control = Controls(teststring1)
                Dim Ctr2 As Control = Controls(teststring2)
                If TypeOf Ctr Is TextBox Then
                    TB = DirectCast(Ctr, TextBox)
                End If
                If TypeOf Ctr1 Is Label Then
                    TB1 = DirectCast(Ctr1, Label)
                End If
                If TypeOf Ctr2 Is TextBox Then
                    TB2 = DirectCast(Ctr2, TextBox)
                End If
                If TB IsNot Nothing Then
                    If Not Ctr.Text = Nothing Then

                        Call skoneksi()
                        If updateimb = False Then
                            If Ctr.Text <> "0" Then
                                com = New OdbcCommand("insert into rinci_bangunan value('" & nosk.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "',NULL)", con)
                                com.ExecuteNonQuery()
                                com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "',NULL,'" & Ctr1.Text & "','" & Ctr.Text & "')", con)
                                com.ExecuteNonQuery()
                            End If
                        Else
                            'com = New OdbcCommand("UPDATE `dbase_imb`.`rinci_bangunan` SET `nama_rincian`='" & Ctr1.Text & "', `ukuran`='" & Ctr.Text & "' WHERE (`nosurat`='" & nosk.Text & "')", con)
                            
                            If Ctr.Text = "0" Then
                                com = New OdbcCommand("select * from rinci_bangunan where nosurat ='" & nosk.Text & "' and nama_rincian ='" & Ctr1.Text & "'", con)
                                rd = com.ExecuteReader
                                rd.Read()
                                If rd.HasRows Then
                                    com = New OdbcCommand("DELETE FROM `rinci_bangunan` WHERE (`nosurat`='" & nosk.Text & "') AND (`nama_rincian`='" & Ctr1.Text & "')", con)
                                    com.ExecuteNonQuery()
                                    com = New OdbcCommand("DELETE FROM `log_skimb` WHERE (`log_nosurat`='" & nosk.Text & "') AND (`log_nama_rincian`='" & Ctr1.Text & "')", con)
                                    com.ExecuteNonQuery()
                                End If
                            Else
                                com = New OdbcCommand("insert into rinci_bangunan value('" & nosk.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "',NULL) ON DUPLICATE KEY UPDATE `nama_rincian`='" & Ctr1.Text & "', `ukuran`='" & Ctr.Text & "'", con)
                                com.ExecuteNonQuery()
                                'com = New OdbcCommand("UPDATE `dbase_imb`.`log_skimb` SET `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "' WHERE (`log_nosurat`='" & nosk.Text & "' )", con)
                                com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "',NULL,'" & Ctr1.Text & "','" & Ctr.Text & "') ON DUPLICATE KEY UPDATE `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "'", con)
                                com.ExecuteNonQuery()
                            End If
                        End If


                    End If
                End If
            Next
        ElseIf ketper.Text = "Penambahan/Balik Nama" And tidak_ada_noimblama = True Then

            If updateimb = True Then
                com = New OdbcCommand("DELETE FROM `rinci_bangunan` WHERE (`nosurat`='" & nosk.Text & "')", con)
                com.ExecuteNonQuery()
                com = New OdbcCommand("DELETE FROM `rinci_bangunan` WHERE (`nosurat`='" & noimblama.Text & "')", con)
                com.ExecuteNonQuery()
                com = New OdbcCommand("DELETE FROM `log_skimb` WHERE (`log_nosurat`='" & nosk.Text & "')", con)
                com.ExecuteNonQuery()
                com = New OdbcCommand("DELETE FROM `log_skimb` WHERE (`log_nosurat`='" & noimblama.Text & "')", con)
                com.ExecuteNonQuery()
            End If



            Dim calc As Integer = 9
            For value As Integer = 1 To calc
                Dim testString As String = "TextBox" + value.ToString
                Dim teststring1 As String = "Label" + value.ToString
                Dim Ctr As Control = Controls(testString)
                Dim Ctr1 As Control = Controls(teststring1)


                If Not Ctr.Text = Nothing Then
                    If Ctr.Text <> "0" Then
                        Call skoneksi()
                        com = New OdbcCommand("insert into rinci_bangunan value('" & noimblama.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "',NULL)", con)
                        com.ExecuteNonQuery()
                        com = New OdbcCommand("insert into log_skimb value('" & noimblama.Text & "',NULL,'" & Ctr1.Text & "','" & Ctr.Text & "')", con)
                        com.ExecuteNonQuery()
                    End If
                End If
            Next

            Dim calc1 As Integer = 9
            For value1 As Integer = 1 To calc1
                Dim testString As String = "teksubh" + value1.ToString
                Dim teststring1 As String = "Label" + value1.ToString
                Dim Ctr As Control = Controls(testString)
                Dim Ctr1 As Control = Controls(teststring1)
                If Not Ctr.Text = Nothing Then
                    If Ctr.Text <> "0" Then
                        Call skoneksi()
                        com = New OdbcCommand("Insert into rinci_bangunan value('" & nosk.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "','" & noimblama.Text & "')", con)
                        com.ExecuteNonQuery()
                    End If
                End If
            Next
            '----------------------------------------------
            For value1 As Integer = 1 To calc1
                Dim testString As String = "teksubh" + value1.ToString
                Dim teststring1 As String = "Label" + value1.ToString
                Dim testString2 As String = "TextBox" + value1.ToString
                Dim teststring3 As String = "Label" + value1.ToString
                Dim Ctr As Control = Controls(testString)
                Dim Ctr1 As Control = Controls(teststring1)
                Dim Ctr2 As Control = Controls(testString2)
                Dim Ctr3 As Control = Controls(teststring3)

                If Ctr.Text <> "0" Then
                    If Ctr.Text <> Ctr2.Text Then

                        If Not Ctr.Text = Nothing Then
                            Call skoneksi()
                            com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "')", con)
                            com.ExecuteNonQuery()
                        End If

                    Else
                        Call skoneksi()
                        com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr3.Text & "','" & Ctr2.Text & "')", con)
                        com.ExecuteNonQuery()
                    End If
                Else
                    If Ctr2.Text <> "0" Then
                        Call skoneksi()
                        com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr3.Text & "','" & Ctr2.Text & "')", con)
                        com.ExecuteNonQuery()
                    End If
                End If

            Next
            '----------------------------------------------



        ElseIf ketper.Text = "Penambahan/Balik Nama" And tidak_ada_noimblama = False Then
            Dim calc1 As Integer = 9

            For value1 As Integer = 1 To calc1
                Dim testString As String = "teksubh" + value1.ToString
                Dim teststring1 As String = "Label" + value1.ToString
                Dim testString2 As String = "TextBox" + value1.ToString
                Dim teststring3 As String = "Label" + value1.ToString
                Dim TB As TextBox = Nothing
                Dim TB1 As Label = Nothing
                Dim Ctr As Control = Controls(testString)
                Dim Ctr1 As Control = Controls(teststring1)
                Dim Ctr2 As Control = Controls(testString2)
                Dim Ctr3 As Control = Controls(teststring3)

                If TypeOf Ctr Is TextBox Then
                    TB = DirectCast(Ctr, TextBox)
                End If
                If TypeOf Ctr1 Is Label Then
                    TB1 = DirectCast(Ctr1, Label)
                End If
                If updateimb = False Then
                    If Ctr.Text <> "0" Then
                        If Ctr.Text <> Ctr2.Text Then
                            If TB IsNot Nothing Then
                                If Not Ctr.Text = Nothing Then
                                    Call skoneksi()
                                    com = New OdbcCommand("insert into rinci_bangunan value('" & nosk.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "','" & noimblama.Text & "')", con)
                                    com.ExecuteNonQuery()
                                    com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "')", con)
                                    com.ExecuteNonQuery()
                                End If
                            End If
                        Else
                            Call skoneksi()
                            com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr3.Text & "','" & Ctr2.Text & "')", con)
                            com.ExecuteNonQuery()
                        End If
                    Else
                        Call skoneksi()
                        com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr3.Text & "','" & Ctr2.Text & "')", con)
                        com.ExecuteNonQuery()
                    End If

                Else

                    If Ctr.Text <> "0" Then
                        If Ctr.Text <> Ctr2.Text Then
                            If TB IsNot Nothing Then
                                If Not Ctr.Text = Nothing Then
                                    Call skoneksi()
                                    com = New OdbcCommand("insert into rinci_bangunan value('" & nosk.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "','" & noimblama.Text & "') ON DUPLICATE KEY UPDATE `nama_rincian`='" & Ctr1.Text & "', `ukuran`='" & Ctr.Text & "', `nomor_surat_lama`='" & noimblama.Text & "'", con)
                                    'com = New OdbcCommand("UPDATE `dbase_imb`.`rinci_bangunan` SET `nama_rincian`='" & Ctr1.Text & "', `ukuran`='" & Ctr.Text & "', `nomor_surat_lama`='" & noimblama.Text & "' WHERE (`nosurat`='" & nosk.Text & "')", con)
                                    com.ExecuteNonQuery()
                                    com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "') ON DUPLICATE KEY UPDATE `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "', `log_nosurat_lama`='" & noimblama.Text & "'", con)
                                    'com = New OdbcCommand("UPDATE `dbase_imb`.`log_skimb` SET `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "', `log_nosurat_lama`='" & noimblama.Text & "' WHERE (`log_nosurat`='" & nosk.Text & "')", con)
                                    com.ExecuteNonQuery()
                                End If
                            End If
                        Else
                            Call skoneksi()
                            com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "') ON DUPLICATE KEY UPDATE `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "', `log_nosurat_lama`='" & noimblama.Text & "'", con)
                            'com = New OdbcCommand("UPDATE `dbase_imb`.`log_skimb` SET `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "', `log_nosurat_lama`='" & noimblama.Text & "' WHERE (`log_nosurat`='" & nosk.Text & "')", con)
                            'com = New OdbcCommand("insert into log_skimb value(NULL,'" & nosk.Text & "','" & noimblama.Text & "','" & Ctr3.Text & "','" & Ctr2.Text & "')", con)
                            com.ExecuteNonQuery()
                        End If
                    Else
                        'coba rubah
                        com = New OdbcCommand("select * from rinci_bangunan where nosurat ='" & nosk.Text & "' and nama_rincian ='" & Ctr1.Text & "'", con)
                        rd = com.ExecuteReader
                        rd.Read()
                        If rd.HasRows Then
                            com = New OdbcCommand("DELETE FROM `rinci_bangunan` WHERE (`nosurat`='" & nosk.Text & "') AND (`nama_rincian`='" & Ctr1.Text & "')", con)
                            com.ExecuteNonQuery()
                            com = New OdbcCommand("DELETE FROM `log_skimb` WHERE (`log_nosurat`='" & nosk.Text & "') AND (`log_nama_rincian`='" & Ctr1.Text & "')", con)
                            com.ExecuteNonQuery()
                        End If
                        'sampe sini
                        If Ctr.Text <> "0" Then
                            Call skoneksi()
                            com = New OdbcCommand("insert into log_skimb value('" & nosk.Text & "','" & noimblama.Text & "','" & Ctr1.Text & "','" & Ctr.Text & "') ON DUPLICATE KEY UPDATE `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "', `log_nosurat_lama`='" & noimblama.Text & "'", con)
                            'com = New OdbcCommand("UPDATE `dbase_imb`.`log_skimb` SET `log_nama_rincian`='" & Ctr1.Text & "', `log_ukuran`='" & Ctr.Text & "', `log_nosurat_lama`='" & noimblama.Text & "' WHERE (`log_nosurat`='" & nosk.Text & "')", con)
                            'com = New OdbcCommand("insert into log_skimb value(NULL,'" & nosk.Text & "','" & noimblama.Text & "','" & Ctr3.Text & "','" & Ctr2.Text & "')", con)
                            com.ExecuteNonQuery()
                        End If
                        
                    End If
                End If
            Next


        End If

    End Sub

    Private Sub simpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click
        If noimblama.Text = "" Or noimblama.Text = "-" Then
            imblama = "Tidak Terlampir"
        Else
            imblama = "Terlampir"
        End If
        If CheckBox2.Checked = True Then
            siteplant = "Terlampir"
        Else
            siteplant = "Tidak Terlampir"
        End If
        If CheckBox3.Checked = True Then
            gambar = "Terlampir"
        Else
            gambar = "Tidak Terlampir"
        End If
        Call skoneksi()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox3.Text = "" Or nobapl.Text = "" Or nobayar.Text = "" Or notanah.Text = "" Or tanahjenis.Text = "" Or namatanah.Text = "" Then
            MsgBox("Isi Semua Data, Periksa Kembali Pengisian")
        ElseIf Not IsNumeric(TextBox1.Text + TextBox2.Text + TextBox7.Text + TextBox6.Text + TextBox4.Text + TextBox5.Text + TextBox3.Text) Then
            MsgBox("Rincian Bnagunan Harus Angka")
        ElseIf updateimb = True Then
            Dim status As String
            If blk_nama.Checked Then
                status = "Balik Nama"
            Else
                status = "Penambahan"
            End If


            com = New OdbcCommand("UPDATE `dbase_imb`.`sk_imb`SET `no_daftar` = '" & nodaftar.Text & "', `tglterbit` = '" & tglterbit.Value.ToString("yyyy-MM-dd") & "', " & _
                                    " `tgldaftar` = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',`namapem` = '" & labnapem.Text & "',`alamatpem` = '" & alamatpem.Text & "',`peruntukan` = '" & peruntukan.Text & "',`kd_kec` = '" & kdkec & "',`nobapl` = '" & nobapl.Text & "', " & _
                                    " `tglbapl` = '" & tglbapl.Value.ToString("yyyy-MM-dd") & "',`jenistananh` = '" & tanahjenis.Text & "',`notanah` = '" & notanah.Text & "',`namatanah` = '" & namatanah.Text & "', " & _
                                    " `imblama` = '" & imblama & "', `noimblama` = '" & noimblama.Text & "',`tglimblama` = '" & tglimblama.Value.ToString("yyyy-MM-dd") & "', " & _
                                    " `nopembayaran` = '" & nobayar.Text & "', `tglpembayaran` = '" & tglbayar.Value.ToString("yyyy-MM-dd") & "', `siteplant` = '" & siteplant & "',`gambar` = '" & gambar & "', " & _
                                    " `id_user` = '" & Form_utama.id_admin & "', `penginput` = '" & Form_utama.ToolStripStatusLabel1.Text & "', status = '" & status & "' " & _
                                    "WHERE	(`nosurat` = '" & nosk.Text & "')", con)
            com.ExecuteNonQuery()
            rincianbangunan()
            MsgBox("Data Berhasil DiPerbaharui", MsgBoxStyle.Information)
            bersih()
            disabletext()
            Form_utama.formdataimb()
        ElseIf updateimb = False Then
            If CheckBox2.Checked = True Then
                siteplant = "Terlampir"
            Else
                siteplant = "Tidak Terlampir"
            End If
            If CheckBox3.Checked = True Then
                gambar = "Terlampir"
            Else
                gambar = "Tidak Terlampir"
            End If
            namafile = tglterbit.Value.ToString("MMddHHmmss")
            objqrcode = New QRCodeEncoder
            objqrcode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
            objqrcode.QRCodeScale = 2
            objqrcode.QRCodeVersion = 5
            objqrcode.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L
            imgimage = objqrcode.Encode(nosk.Text + " Penanggung " + Form_utama.ToolStripStatusLabel1.Text)
            objbitmap = New Bitmap(imgimage)
            objbitmap.Save("" & namafile & "qrimb.jpeg")
            myms = New IO.MemoryStream
            PictureBox1.Image = Image.FromFile("" & namafile & "qrimb.jpeg")
            PictureBox1.Image.Save(myms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = myms.GetBuffer()
            If ketper.Text = "Baru" Then
                com = New OdbcCommand("insert into sk_imb values('" & nosk.Text & "','" & nodaftar.Text & "','" & tglterbit.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & labnapem.Text & "','" & alamatpem.Text & "','" & peruntukan.Text & "','" & kdkec & "','" & nobapl.Text & "','" & tglbapl.Value.ToString("yyyy-MM-dd") & "','" & tanahjenis.Text & "','" & notanah.Text & "','" & namatanah.Text & "','" & imblama & "','" & noimblama.Text & "','" & tglimblama.Value.ToString("yyyy-MM-dd") & "','" & nobayar.Text & "','" & tglbayar.Value.ToString("yyyy-MM-dd") & "','" & siteplant & "','" & gambar & "', ?,'" & Form_utama.id_admin & "','" & Form_utama.ToolStripStatusLabel1.Text & "','Baru','1')", con)
            Else
                If blk_nama.Checked Then
                    com = New OdbcCommand("insert into sk_imb values('" & nosk.Text & "','" & nodaftar.Text & "','" & tglterbit.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & labnapem.Text & "','" & alamatpem.Text & "','" & peruntukan.Text & "','" & kdkec & "','" & nobapl.Text & "','" & tglbapl.Value.ToString("yyyy-MM-dd") & "','" & tanahjenis.Text & "','" & notanah.Text & "','" & namatanah.Text & "','" & imblama & "','" & noimblama.Text & "','" & tglimblama.Value.ToString("yyyy-MM-dd") & "','" & nobayar.Text & "','" & tglbayar.Value.ToString("yyyy-MM-dd") & "','" & siteplant & "','" & gambar & "', ?,'" & Form_utama.id_admin & "','" & Form_utama.ToolStripStatusLabel1.Text & "','Balik Nama','1')", con)
                Else
                    com = New OdbcCommand("insert into sk_imb values('" & nosk.Text & "','" & nodaftar.Text & "','" & tglterbit.Value.ToString("yyyy-MM-dd") & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & labnapem.Text & "','" & alamatpem.Text & "','" & peruntukan.Text & "','" & kdkec & "','" & nobapl.Text & "','" & tglbapl.Value.ToString("yyyy-MM-dd") & "','" & tanahjenis.Text & "','" & notanah.Text & "','" & namatanah.Text & "','" & imblama & "','" & noimblama.Text & "','" & tglimblama.Value.ToString("yyyy-MM-dd") & "','" & nobayar.Text & "','" & tglbayar.Value.ToString("yyyy-MM-dd") & "','" & siteplant & "','" & gambar & "', ?,'" & Form_utama.id_admin & "','" & Form_utama.ToolStripStatusLabel1.Text & "','Penambahan','1')", con)
                End If
            End If
            com.Parameters.AddWithValue("?", arrimage)
            com.ExecuteNonQuery()
            rincianbangunan()
            MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
            Form_utama.skimb()
            End If
    End Sub

    Sub cari()
        If nodaftar.Text.Count > 2 Then
            'nopendaftaran = codedaftar + nodaftar.Text + kec + myyear
            'nodaftar.Text = nopendaftaran
            GoTo langsung_trn
        ElseIf nodaftar.Text.Count = 2 Then
            nopendaftaran = codedaftar + nodaftar.Text + kec + myyear
            nodaftar.Text = nopendaftaran
        ElseIf nodaftar.Text.Count = 1 Then
            nopendaftaran = codedaftar + "0" + nodaftar.Text + kec + myyear
            nodaftar.Text = nopendaftaran
            'ElseIf nodaftar.Text.Count = 2 Then
            '    nopendaftaran = codedaftar + "0" + nodaftar.Text + kec + myyear
            '    nodaftar.Text = nopendaftaran
            'ElseIf nodaftar.Text.Count = 3 Then
            '    nopendaftaran = codedaftar + "0" + nodaftar.Text + kec + myyear
            '    nodaftar.Text = nopendaftaran
        End If
langsung_trn:
        Call skoneksi()
        com = New OdbcCommand(" select * from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp inner join sk_imb on sk_pendaftaran.no_daftar = sk_imb.no_daftar where sk_pendaftaran.no_daftar ='" & nodaftar.Text & "' and sk_pendaftaran.aktif='1'", con)
        rd = com.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            MsgBox("No Daftar Sudah Digunakan")
        ElseIf rd.HasRows = 0 Then
            com = New OdbcCommand(" select * from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.no_daftar ='" & nodaftar.Text & "' and sk_pendaftaran.aktif='1'", con)
            rd = com.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                almtbangun = rd.Item("alamat_ijin")
                labnapem.Text = rd.Item("nama_pemohon")
                DateTimePicker1.Value = rd.Item("tgl_daftar")
                alamatpem.Text = rd.Item("alamat_ijin")
                peruntukan.Text = rd.Item("peruntukan")
                ketper.Text = rd.Item("keterangan")
                autonum()
                If ketper.Text = "Baru" Then
                    texbox_baru()
                    Label_imb.Text = "Masukan IMB Baru"
                    label_penambahan.Text = ""
                    CheckBox1.Visible = False
                    blk_nama.Visible = False
                Else
                    blk_nama.Visible = True
                    textbox_penambahan()
                    Dim show_event As New event_imblama
                    show_event.imblama = Me
                    show_event.noimblama_event.Text = noimblama.Text
                    show_event.ShowDialog()
                    Dim calc As Integer = 9
                    For value As Integer = 1 To calc
                        Dim testString As String = "TextBox" + value.ToString
                        Dim Ctr As Control = Controls(testString)
                        If Ctr.Text = "" Then
                            Ctr.Text = "0"
                        End If
                    Next
                End If
            ElseIf Not rd.HasRows Then
                MsgBox("Surat Pendaftaran Tidak Ditemukan")
                nodaftar.Text = Nothing
            End If
        End If
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        Call skoneksi()
    '        com = New OdbcCommand("select * from rinci_bangunan where nosurat = '" & noimblama.Text & "'", con)
    '        rd = com.ExecuteReader
    '        Do While rd.Read
    '            Dim x As String = rd.Item("nama_rincian")
    '            If x = "BANGUNAN LT.1" Then
    '                TextBox1.Text = rd.Item("ukuran")
    '            ElseIf x = "BANGUNAN LT.2" Then
    '                TextBox2.Text = rd.Item("ukuran")
    '            ElseIf x = "TERAS" = True Then
    '                TextBox3.Text = rd.Item("ukuran")
    '            ElseIf x = "CARPORT" Then
    '                TextBox4.Text = rd.Item("ukuran")
    '            ElseIf x = "BALKON" Then
    '                TextBox5.Text = rd.Item("ukuran")
    '            ElseIf x = "PAGAR" Then
    '                TextBox6.Text = rd.Item("ukuran")
    '            ElseIf x = "SEPTICTANK" Then
    '                TextBox7.Text = rd.Item("ukuran")
    '            End If
    '        Loop
    '        If Not rd.HasRows Then
    '            Dim tanya As String = MsgBox("Pencarian Tidak Ditemukan, Tetap Lanjutkan ?", vbYesNo)
    '            If tanya = vbYes Then
    '                texbox_baru()
    '            End If
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            imblama = "Terlampir"
            GroupBox6.Enabled = True
        Else
            imblama = "Tidak Terlampir"
            GroupBox6.Enabled = False
            noimblama.Text = "-"
        End If
    End Sub

    Private Sub balkon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub carport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub pagar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub septic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub teras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub nodaftar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nodaftar.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            cari()
        End If
    End Sub

    Sub textbox_penambahan()
        teksubh1.Enabled = True
        teksubh2.Enabled = True
        teksubh3.Enabled = True
        teksubh4.Enabled = True
        teksubh5.Enabled = True
        teksubh6.Enabled = True
        teksubh7.Enabled = True
        teksubh8.Enabled = True
        teksubh9.Enabled = True
    End Sub

    Sub texbox_baru()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
    End Sub

    Private Sub ketper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ketper.TextChanged
        If ketper.Text = "Baru" Then
            noimblama.Enabled = False
            tglimblama.Enabled = False
        Else
            noimblama.Enabled = True
            tglimblama.Enabled = True
        End If
    End Sub
End Class