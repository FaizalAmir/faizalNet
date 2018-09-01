Imports System.Data.Odbc
Public Class cari_data_skimb

    Sub tampilkan()
        skoneksi()
        da = New OdbcDataAdapter("select * from sk_imb", con)
        ds = New DataSet
        da.Fill(ds, "sk_imb")
        DataGridView1.DataSource = ds.Tables("sk_imb")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Enabled = True
    End Sub

    Sub tampilarsip()
        skoneksi()
        da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', no_daftar as 'No. Daftar',sk_imb.noimblama AS 'IMB Lama', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.qrskimb AS 'QR SK IMB', sk_imb.Penginput, sk_imb.status AS 'Status' from sk_imb where sk_imb.aktif='1' and tglterbit is not null", con)
        ds = New DataSet
        da.Fill(ds, "sk_imb")
        DataGridView1.DataSource = ds.Tables("sk_imb")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Enabled = True
    End Sub

    Private Sub cari_data_skimb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form_utama.hakakses = 1 Then
            Button2.Enabled = True
        ElseIf Form_utama.hakakses = "2" Then
            Button2.Enabled = False
        End If
        tampilarsip()
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pencarian()
        'If DataGridView1.RowCount = 1 Then
        '    MsgBox("Pencarian " & kategori.Text & " Tidak Ditemukan")
        'End If
    End Sub

    Sub pencarian()
        skoneksi()

        If kategori.Text = "Nama Pemohon" Then
            'da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.jenisbangunan, sk_imb.alamatbangunan, sk_imb.qrskimb, sk_imb.Penginput from sk_imb where sk_imb.namapem like '%" & ktgr.Text & "%'", con)
            'ds = New DataSet
            'da.Fill(ds, "sk_imb")
            'DataGridView1.DataSource = ds.Tables("sk_imb")
            'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'DataGridView1.Enabled = True
            da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', no_daftar as 'No. Daftar',sk_imb.noimblama AS 'IMB Lama', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.qrskimb AS 'QR SK IMB', sk_imb.Penginput, sk_imb.status AS 'Status' from sk_imb where sk_imb.aktif='1' and sk_imb.namapem like '%" & ktgr.Text & "%' AND tglterbit is not null", con)
            ds = New DataSet
            da.Fill(ds, "sk_imb")
            DataGridView1.DataSource = ds.Tables("sk_imb")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.Enabled = True

        ElseIf kategori.Text = "No Surat IMB" Then
            da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', no_daftar as 'No. Daftar',sk_imb.noimblama AS 'IMB Lama', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.qrskimb AS 'QR SK IMB', sk_imb.Penginput, sk_imb.status AS 'Status' from sk_imb where sk_imb.aktif='1' and sk_imb.nosurat LIKE '%" & ktgr.Text & "%' AND tglterbit is not null", con)
            ds = New DataSet
            da.Fill(ds, "sk_imb")
            DataGridView1.DataSource = ds.Tables("sk_imb")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.Enabled = True
        ElseIf kategori.Text = "Alamat Pemohon" Then
            da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', no_daftar as 'No. Daftar',sk_imb.noimblama AS 'IMB Lama', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.qrskimb AS 'QR SK IMB', sk_imb.Penginput, sk_imb.status AS 'Status' from sk_imb where sk_imb.aktif='1' and sk_imb.alamatpem like '%" & ktgr.Text & "%' AND tglterbit is not null", con)
            ds = New DataSet
            da.Fill(ds, "sk_imb")
            DataGridView1.DataSource = ds.Tables("sk_imb")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.Enabled = True
            'ElseIf kategori.Text = "Alamat Bangunan" Then
            '    'da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.jenisbangunan, sk_imb.alamatbangunan, sk_imb.qrskimb, sk_imb.Penginput from sk_imb where sk_imb.alamatbangunan like '%" & ktgr.Text & "%'", con)
            '    'ds = New DataSet
            '    'da.Fill(ds, "sk_imb")
            '    'DataGridView1.DataSource = ds.Tables("sk_imb")
            '    'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '    'DataGridView1.Enabled = True

            '    da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', no_daftar as 'No. Daftar',sk_imb.noimblama AS 'IMB Lama', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.qrskimb AS 'QR SK IMB', sk_imb.Penginput, sk_imb.status AS 'Status' from sk_imb where sk_imb.aktif='1' and sk_imb.alamatbangunan like '%" & ktgr.Text & "%' AND tglterbit is not null", con)
            '    ds = New DataSet
            '    da.Fill(ds, "sk_imb")
            '    DataGridView1.DataSource = ds.Tables("sk_imb")
            '    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '    DataGridView1.Enabled = True
        ElseIf kategori.Text = "Range Tanggal" Then
            'da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.jenisbangunan, sk_imb.alamatbangunan, sk_imb.qrskimb, sk_imb.Penginput from sk_imb where sk_imb.tglterbit between '" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd-MM-yyyy") & "'", con)
            'ds = New DataSet
            'da.Fill(ds, "sk_imb")
            'DataGridView1.DataSource = ds.Tables("sk_imb")
            'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            'DataGridView1.Enabled = True

            da = New OdbcDataAdapter("select sk_imb.nosurat as 'No Surat', no_daftar as 'No. Daftar',sk_imb.noimblama AS 'IMB Lama', sk_imb.tglterbit as 'Tgl Terbit', sk_imb.tgldaftar as 'Tgl Daftar', sk_imb.namapem as 'Nama Pemohon', sk_imb.alamatpem as 'Alamat Pemohon', sk_imb.peruntukan, sk_imb.qrskimb AS 'QR SK IMB', sk_imb.Penginput, sk_imb.status AS 'Status' from sk_imb where sk_imb.aktif='1' and sk_imb.tglterbit between '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "' AND tglterbit is not null", con)
            ds = New DataSet
            da.Fill(ds, "sk_imb")
            DataGridView1.DataSource = ds.Tables("sk_imb")
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.Enabled = True
        End If
    End Sub

    Private Sub kategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kategori.SelectedIndexChanged
        If kategori.Text = "Range Tanggal" Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            ktgr.Visible = False
            labkunci.Visible = False
        ElseIf kategori.Text = "Alamat Bangunan" Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ktgr.Visible = True
            labkunci.Text = kategori.Text
        ElseIf kategori.Text = "Alamat Pemohon" Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ktgr.Visible = True
            labkunci.Text = kategori.Text
        ElseIf kategori.Text = "Nama Pemohon" Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ktgr.Visible = True
            labkunci.Text = kategori.Text
        ElseIf kategori.Text = "No Surat IMB" Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            ktgr.Visible = True
            labkunci.Text = kategori.Text
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ubahimb As New skimb
        Dim pesan As String = MsgBox("Ingin Ubah Data Juga?", vbYesNo + MsgBoxStyle.Information)
        If pesan = vbYes Then
            ubahimb.MdiParent = Form_utama
            ubahimb.Dock = DockStyle.Fill
            ubahimb.nosk.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            If Replace(DataGridView1.CurrentRow.Cells(2).Value.ToString, " ", "") <> "-" Then
                com = New OdbcCommand("select * from sk_imb where  nosurat ='" & DataGridView1.CurrentRow.Cells(2).Value.ToString & "'", con)
                rd = com.ExecuteReader
                rd.Read()
                'com = New OdbcCommand("", con)
                If rd.HasRows Then
                    Call skoneksi()
                    com = New OdbcCommand("select * from log_skimb where log_nosurat = '" & DataGridView1.CurrentRow.Cells(2).Value.ToString & "'", con)
                    rd = com.ExecuteReader

                    Do While rd.Read
                        Dim x As String = rd.Item("log_nama_rincian")
                        If x = "BANGUNAN LT.1" Then
                            ubahimb.TextBox1.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "BANGUNAN LT.2" Then
                            ubahimb.TextBox2.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "BANGUNAN LT.3" = True Then
                            ubahimb.TextBox3.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "CARPORT" Then
                            ubahimb.TextBox4.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "BALKON" Then
                            ubahimb.TextBox5.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "PAGAR" Then
                            ubahimb.TextBox6.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "SEPTICTANK" Then
                            ubahimb.TextBox7.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "DAK BETON" Then
                            ubahimb.TextBox8.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "TERAS" Then
                            ubahimb.TextBox9.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        End If
                    Loop
                    If ubahimb.TextBox1.Text = "" Then
                        ubahimb.TextBox1.Text = "0"
                    End If
                    If ubahimb.TextBox2.Text = "" Then
                        ubahimb.TextBox2.Text = "0"
                    End If
                    If ubahimb.TextBox3.Text = "" Then
                        ubahimb.TextBox3.Text = "0"
                    End If
                    If ubahimb.TextBox4.Text = "" Then
                        ubahimb.TextBox4.Text = "0"
                    End If
                    If ubahimb.TextBox5.Text = "" Then
                        ubahimb.TextBox5.Text = "0"
                    End If
                    If ubahimb.TextBox6.Text = "" Then
                        ubahimb.TextBox6.Text = "0"
                    End If
                    If ubahimb.TextBox7.Text = "" Then
                        ubahimb.TextBox7.Text = "0"
                    End If
                    If ubahimb.TextBox8.Text = "" Then
                        ubahimb.TextBox8.Text = "0"
                    End If
                    If ubahimb.TextBox9.Text = "" Then
                        ubahimb.TextBox9.Text = "0"
                    End If

                    com = New OdbcCommand("select * from rinci_bangunan where nosurat = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "' and nomor_surat_lama ='" & DataGridView1.CurrentRow.Cells(2).Value.ToString & "'", con)
                    rd = com.ExecuteReader
                    Do While rd.Read
                        Dim x As String = rd.Item("nama_rincian")
                        If x = "BANGUNAN LT.1" Then
                            ubahimb.teksubh1.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "BANGUNAN LT.2" Then
                            ubahimb.teksubh2.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "BANGUNAN LT.3" = True Then
                            ubahimb.teksubh3.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "CARPORT" Then
                            ubahimb.teksubh4.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "BALKON" Then
                            ubahimb.teksubh5.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "PAGAR" Then
                            ubahimb.teksubh6.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "SEPTICTANK" Then
                            ubahimb.teksubh7.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "DAK BETON" Then
                            ubahimb.teksubh8.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        ElseIf x = "TERAS" Then
                            ubahimb.teksubh9.Text = IIf(rd.Item("ukuran") = "", "0", rd.Item("ukuran"))
                        End If
                    Loop
                    If ubahimb.teksubh1.Text = "" Then
                        ubahimb.teksubh1.Text = "0"
                    End If
                    If ubahimb.teksubh2.Text = "" Then
                        ubahimb.teksubh2.Text = "0"
                    End If
                    If ubahimb.teksubh3.Text = "" Then
                        ubahimb.teksubh3.Text = "0"
                    End If
                    If ubahimb.teksubh4.Text = "" Then
                        ubahimb.teksubh4.Text = "0"
                    End If
                    If ubahimb.teksubh5.Text = "" Then
                        ubahimb.teksubh5.Text = "0"
                    End If
                    If ubahimb.teksubh6.Text = "" Then
                        ubahimb.teksubh6.Text = "0"
                    End If
                    If ubahimb.teksubh7.Text = "" Then
                        ubahimb.teksubh7.Text = "0"
                    End If
                    If ubahimb.teksubh8.Text = "" Then
                        ubahimb.teksubh8.Text = "0"
                    End If
                    If ubahimb.teksubh9.Text = "" Then
                        ubahimb.teksubh9.Text = "0"
                    End If

                    ubahimb.tidak_ada_noimblama = False
                Else
                    Call skoneksi()
                    com = New OdbcCommand("select * from log_skimb where log_nosurat = '" & DataGridView1.CurrentRow.Cells(2).Value.ToString & "'", con)
                    rd = com.ExecuteReader

                    Do While rd.Read
                        Dim x As String = rd.Item("log_nama_rincian")
                        If x = "BANGUNAN LT.1" Then
                            ubahimb.TextBox1.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "BANGUNAN LT.2" Then
                            ubahimb.TextBox2.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "BANGUNAN LT.3" = True Then
                            ubahimb.TextBox3.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "CARPORT" Then
                            ubahimb.TextBox4.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "BALKON" Then
                            ubahimb.TextBox5.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "PAGAR" Then
                            ubahimb.TextBox6.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "SEPTICTANK" Then
                            ubahimb.TextBox7.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "DAK BETON" Then
                            ubahimb.TextBox8.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        ElseIf x = "TERAS" Then
                            ubahimb.TextBox9.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                        End If
                    Loop
                    If ubahimb.TextBox1.Text = "" Then
                        ubahimb.TextBox1.Text = "0"
                    End If
                    If ubahimb.TextBox2.Text = "" Then
                        ubahimb.TextBox2.Text = "0"
                    End If
                    If ubahimb.TextBox3.Text = "" Then
                        ubahimb.TextBox3.Text = "0"
                    End If
                    If ubahimb.TextBox4.Text = "" Then
                        ubahimb.TextBox4.Text = "0"
                    End If
                    If ubahimb.TextBox5.Text = "" Then
                        ubahimb.TextBox5.Text = "0"
                    End If
                    If ubahimb.TextBox6.Text = "" Then
                        ubahimb.TextBox6.Text = "0"
                    End If
                    If ubahimb.TextBox7.Text = "" Then
                        ubahimb.TextBox7.Text = "0"
                    End If
                    If ubahimb.TextBox8.Text = "" Then
                        ubahimb.TextBox8.Text = "0"
                    End If
                    If ubahimb.TextBox9.Text = "" Then
                        ubahimb.TextBox9.Text = "0"
                    End If

                    ubahimb.tidak_ada_noimblama = True
                End If

                '
                '
                '    
                'Else
                '    
                'End If
            Else
                Call skoneksi()
                com = New OdbcCommand("select * from log_skimb where log_nosurat = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", con)
                rd = com.ExecuteReader

                Do While rd.Read
                    Dim x As String = rd.Item("log_nama_rincian")
                    If x = "BANGUNAN LT.1" Then
                        ubahimb.TextBox1.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "BANGUNAN LT.2" Then
                        ubahimb.TextBox2.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "BANGUNAN LT.3" = True Then
                        ubahimb.TextBox3.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "CARPORT" Then
                        ubahimb.TextBox4.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "BALKON" Then
                        ubahimb.TextBox5.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "PAGAR" Then
                        ubahimb.TextBox6.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "SEPTICTANK" Then
                        ubahimb.TextBox7.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "DAK BETON" Then
                        ubahimb.TextBox8.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    ElseIf x = "TERAS" Then
                        ubahimb.TextBox9.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                    End If
                Loop
                If ubahimb.TextBox1.Text = "" Then
                    ubahimb.TextBox1.Text = "0"
                End If
                If ubahimb.TextBox2.Text = "" Then
                    ubahimb.TextBox2.Text = "0"
                End If
                If ubahimb.TextBox3.Text = "" Then
                    ubahimb.TextBox3.Text = "0"
                End If
                If ubahimb.TextBox4.Text = "" Then
                    ubahimb.TextBox4.Text = "0"
                End If
                If ubahimb.TextBox5.Text = "" Then
                    ubahimb.TextBox5.Text = "0"
                End If
                If ubahimb.TextBox6.Text = "" Then
                    ubahimb.TextBox6.Text = "0"
                End If
                If ubahimb.TextBox7.Text = "" Then
                    ubahimb.TextBox7.Text = "0"
                End If
                If ubahimb.TextBox8.Text = "" Then
                    ubahimb.TextBox8.Text = "0"
                End If
                If ubahimb.TextBox9.Text = "" Then
                    ubahimb.TextBox9.Text = "0"
                End If
                ubahimb.tidak_ada_noimblama = False
            End If
            ubahimb.fordatask_on()
            ubahimb.updateimb = True
            ubahimb.Show()
            'updateimb = True
        ElseIf pesan = vbNo Then
            Exit Sub
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cetak.Click
        If DataGridView1.CurrentRow.Cells(7).Value.ToString = "Ruko" Then
            If Replace(DataGridView1.CurrentRow.Cells(2).Value.ToString, " ", "") = "-" Then
                Dim formcetak As New Form_cetak_imb_ruko
                formcetak.CrystalReportViewer1.Refresh()
                formcetak.Cetak_ruko_imb1.Refresh()
                formcetak.Cetak_ruko_imb1.SetParameterValue("Pm-sk_imb1.nosurat", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak.Cetak_ruko_imb1.RecordSelectionFormula = "{sk_imb1.nosurat} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                formcetak.ShowDialog()
                Exit Sub
            End If
            If DataGridView1.CurrentRow.Cells(10).Value.ToString = "Penambahan" Then
                Dim formcetak2 As New Form_cetak_imb_penambahan
                formcetak2.CrystalReportViewer1.Refresh()
                formcetak2.Cetak_ruko_imb_penambahan1.Refresh()
                formcetak2.Cetak_ruko_imb_penambahan1.RecordSelectionFormula = "{sk_imb1.nosurat} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                'formcetak2.Cetakskimb1.SetParameterValue("Pm-sk_imb1.noimblama", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak2.Cetak_ruko_imb_penambahan1.SetParameterValue("Pm-sk_imb1.nosurat", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak2.ShowDialog()
                Exit Sub
            Else
                Dim formcetak3 As New Form_cetak_imb_baliknama
                formcetak3.CrystalReportViewer1.Refresh()
                formcetak3.Cetak_ruko_imb_baliknama1.Refresh()
                formcetak3.Cetak_ruko_imb_baliknama1.RecordSelectionFormula = "{sk_imb1.nosurat} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                formcetak3.Cetak_ruko_imb_baliknama1.SetParameterValue("PM-nomor_imblama", DataGridView1.CurrentRow.Cells(2).Value.ToString)
                formcetak3.Cetak_ruko_imb_baliknama1.SetParameterValue("PM-nomor_imbbaru", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak3.Cetak_ruko_imb_baliknama1.SetParameterValue("Pm-sk_imb1.nosurat", DataGridView1.CurrentRow.Cells(2).Value.ToString)
                formcetak3.ShowDialog()
                Exit Sub
            End If
        Else
            If Replace(DataGridView1.CurrentRow.Cells(2).Value.ToString, " ", "") = "-" Then
                Dim formcetak1 As New Form_Cetakskimb
                formcetak1.CrystalReportViewer1.Refresh()
                formcetak1.Cetakskimb1.Refresh()
                formcetak1.Cetakskimb1.SetParameterValue("Pm-sk_imb1.nosurat", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak1.Cetakskimb1.RecordSelectionFormula = "{sk_imb1.nosurat} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                formcetak1.ShowDialog()
                Exit Sub
            End If
            If DataGridView1.CurrentRow.Cells(10).Value.ToString = "Penambahan" Then
                Dim formcetak2 As New Form_Cetak_penambahan
                formcetak2.CrystalReportViewer1.Refresh()
                formcetak2.Cetak_penambahan1.Refresh()
                formcetak2.Cetak_penambahan1.RecordSelectionFormula = "{sk_imb1.nosurat} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                'formcetak2.Cetakskimb1.SetParameterValue("Pm-sk_imb1.noimblama", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak2.Cetak_penambahan1.SetParameterValue("Pm-sk_imb1.nosurat", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak2.ShowDialog()
                Exit Sub
            Else
                Dim formcetak3 As New Form_balik_nama
                formcetak3.CrystalReportViewer1.Refresh()
                formcetak3.Cetak_baliknama1.Refresh()
                formcetak3.Cetak_baliknama1.RecordSelectionFormula = "{sk_imb1.nosurat} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
                formcetak3.Cetak_baliknama1.SetParameterValue("PM-nomor_imblama", DataGridView1.CurrentRow.Cells(2).Value.ToString)
                formcetak3.Cetak_baliknama1.SetParameterValue("PM-nomor_imbbaru", DataGridView1.CurrentRow.Cells(0).Value.ToString)
                formcetak3.Cetak_baliknama1.SetParameterValue("Pm-sk_imb1.nosurat", DataGridView1.CurrentRow.Cells(2).Value.ToString)
                formcetak3.ShowDialog()
                Exit Sub
            End If

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        tampilarsip()
        kategori.Text = Nothing
        ktgr.Text = Nothing
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
    End Sub

    Private Sub ktgr_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ktgr.TextChanged
        pencarian()
        'If DataGridView1.RowCount < 1 Then
        '    MsgBox("Pencarian " & kategori.Text & " Tidak Ditemukan")
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pesan As String = MsgBox(" Apakah data ingin di hapus?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            Call skoneksi()
            com = New OdbcCommand("UPDATE sk_imb SET aktif='0' WHERE (nosurat='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "')", con)
            'com = New OdbcCommand("delete from sk_imb where nosurat ='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", con)
            com.ExecuteReader()
            'com = New OdbcCommand("delete from sk_pendaftaran where no_daftar ='" & DataGridView1.CurrentRow.Cells(1).Value.ToString & "'", con)
            com = New OdbcCommand("UPDATE sk_pendaftaran SET aktif='0' WHERE (no_daftar='" & DataGridView1.CurrentRow.Cells(1).Value.ToString & "')", con)
            com.ExecuteReader()
            MsgBox("Data berhasil dihapus")
            tampilarsip()
        End If
    End Sub
End Class