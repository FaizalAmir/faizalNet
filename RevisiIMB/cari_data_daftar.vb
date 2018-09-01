Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class cari_data_daftar
    Sub loaddata()
        skoneksi()
        da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar as 'No.Daftar', sk_pendaftaran.no_ktp as 'No.KTP', pemohon.nama_pemohon as 'Nama Pemohon', pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.tgl_daftar AS 'Tanggal Daftar', sk_pendaftaran.peruntukan AS 'Peruntukan', sk_pendaftaran.alamat_ijin AS 'Alamat Ijin', sk_pendaftaran.ds_kel AS 'Desa/Kel.', sk_pendaftaran.diinputoleh as 'Penginput' from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.aktif='1'", con)
        ds = New DataSet
        da.Fill(ds, "sk_pendaftaran")
        DataGridView1.DataSource = ds.Tables("sk_pendaftaran")
        DataGridView1.Enabled = True
        TextBox1.Text = Nothing
        katpen()
    End Sub

    Sub katpen()
        kategori.Refresh()
        kategori.Items.Clear()
        kategori.Items.Add("Nama Pemohon")
        kategori.Items.Add("No Daftar")
        kategori.Items.Add("Range Tanggal")
    End Sub

    Private Sub cari_data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form_utama.hakakses = "1" Then
            Button4.Enabled = True
        ElseIf Form_utama.hakakses = "2" Then
            Button4.Enabled = False
        End If
        loaddata()
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False
        TextBox1.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        skoneksi()
        If kategori.Text = "Nama Pemohon" Then
            da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar AS 'No. Surat',sk_pendaftaran.no_ktp AS 'No.KTP',pemohon.nama_pemohon AS 'Nama Pemohon',sk_pendaftaran.tgl_daftar,pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where pemohon.nama_pemohon like '%" & TextBox1.Text & "%' and sk_pendaftaran.aktif='1'", con)
        ElseIf kategori.Text = "No Daftar" Then
            da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar AS 'No. Surat',sk_pendaftaran.no_ktp AS 'No.KTP',pemohon.nama_pemohon AS 'Nama Pemohon',sk_pendaftaran.tgl_daftar,pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.no_daftar like '%" & TextBox1.Text & "%' and sk_pendaftaran.aktif='1'", con)
        ElseIf kategori.Text = "Range Tanggal" Then
            da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar AS 'No. Surat',sk_pendaftaran.no_ktp AS 'No.KTP',pemohon.nama_pemohon AS 'Nama Pemohon',sk_pendaftaran.tgl_daftar,pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.tgl_daftar between '" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd-MM-yyyy") & "' and sk_pendaftaran.aktif='1'", con)
        End If
        ds = New DataSet
        da.Fill(ds, "pemohon,sk_pendaftaran")
        DataGridView1.DataSource = ds.Tables("pemohon,sk_pendaftaran")
        DataGridView1.Enabled = True
        If DataGridView1.RowCount = 0 Then
            MsgBox("Pencarian " & kategori.Text & " Tidak Ditemukan")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cetakimb As New Form_cetakpendaftaran
        cetakimb.CrystalReportViewer1.Refresh()
        cetakimb.cetakimb1.Refresh()
        '  cetakimb.cetakimb1.SetParameterValue("test1", Form_utama.ToolStripStatusLabel1.Text)
        cetakimb.CrystalReportViewer1.ReportSource = cetakimb.cetakimb1
        cetakimb.cetakimb1.RecordSelectionFormula = "{sk_pendaftaran1.no_daftar} = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
        cetakimb.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tanya As String = MsgBox("Apakah anda yakin ingin menghapus data ini?", MsgBoxStyle.YesNo)
        If tanya = vbYes Then
            Call skoneksi()
            com = New OdbcCommand("UPDATE sk_pendaftaran SET aktif='0' WHERE (no_daftar='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "')", con)

            'com = New OdbcCommand("DELETE FROM sk_pendaftaran where no_daftar='" & Me.DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", con)
            com.ExecuteNonQuery()
            'com = New OdbcCommand("DELETE FROM sk_imb where no_daftar='" & Me.DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", con)
            'com = New OdbcCommand("UPDATE sk_imb SET aktif='0' WHERE (nosurat='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "')", con)

            'com.ExecuteNonQuery()
            loaddata()
            MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ubahimb As New pendaftaran
        ubahimb.MdiParent = Form_utama
        ubahimb.Dock = DockStyle.Fill
        ubahimb.cekno.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        ubahimb.updatedata = True
        ubahimb.Show()
    End Sub

    Private Sub refreshhh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshhh.Click
        loaddata()

    End Sub

    Private Sub kategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kategori.SelectedIndexChanged
        If kategori.Text = "Nama Pemohon" Then
            TextBox1.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            Label1.Text = kategori.Text
        ElseIf kategori.Text = "No Daftar" Then
            TextBox1.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            Label1.Text = kategori.Text
        ElseIf kategori.Text = "Range Tanggal" Then
            TextBox1.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        skoneksi()
        If kategori.Text = "Nama Pemohon" Then
            da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar AS 'No. Surat',sk_pendaftaran.no_ktp AS 'No.KTP',pemohon.nama_pemohon AS 'Nama Pemohon',sk_pendaftaran.tgl_daftar,pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where pemohon.nama_pemohon like '%" & TextBox1.Text & "%'", con)
        ElseIf kategori.Text = "No Daftar" Then
            da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar AS 'No. Surat',sk_pendaftaran.no_ktp AS 'No.KTP',pemohon.nama_pemohon AS 'Nama Pemohon',sk_pendaftaran.tgl_daftar,pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.no_daftar like '%" & TextBox1.Text & "%'", con)
        ElseIf kategori.Text = "Range Tanggal" Then
            da = New OdbcDataAdapter("select sk_pendaftaran.no_daftar AS 'No. Surat',sk_pendaftaran.no_ktp AS 'No.KTP',pemohon.nama_pemohon AS 'Nama Pemohon',sk_pendaftaran.tgl_daftar,pemohon.alamat_pemohon AS 'Alamat Pemohon',sk_pendaftaran.peruntukan, sk_pendaftaran.jenis_usaha, sk_pendaftaran.alamat_ijin, sk_pendaftaran.ds_kel from sk_pendaftaran inner join pemohon on sk_pendaftaran.no_ktp = pemohon.no_ktp where sk_pendaftaran.tgl_daftar between '" & DateTimePicker1.Value.ToString("dd-MM-yyyy") & "' and '" & DateTimePicker2.Value.ToString("dd-MM-yyyy") & "'", con)
        End If
        ds = New DataSet
        da.Fill(ds, "pemohon,sk_pendaftaran")
        DataGridView1.DataSource = ds.Tables("pemohon,sk_pendaftaran")
        DataGridView1.Enabled = True
        If DataGridView1.RowCount = 1 Then
            MsgBox("Pencarian " & kategori.Text & " Tidak Ditemukan")
        End If
    End Sub
End Class
