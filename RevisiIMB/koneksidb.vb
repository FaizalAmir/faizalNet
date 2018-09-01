Imports System.Data.Odbc
Module koneksidb
    Public con As OdbcConnection
    Public dt As DataTable
    Public com As OdbcCommand
    Public rd As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    'Dim con As OdbcConnection
    'Dim koneksi As OdbcConnection
    Const DSN = "DSN=dbase_imb"
    Sub skoneksi()
        'Try

        '    con = New OdbcConnection(DSN)
        '    If con.State = ConnectionState.Open Then
        '    ElseIf con.State = ConnectionState.Closed Then
        '        con.Open()
        '    End If
        'Catch ex As Exception
        '    MsgBox("Koneksi Gagal")
        '    Exit Sub
        'End Try

        'Try
        '    con = New OdbcConnection(DSN)
        '    con.Open()
        '    'MsgBox("Koneksi Berhasil")
        'Catch ex As Exception
        '    MsgBox("Koneksi Gagal")
        '    Exit Sub
        '    'MsgBox(ex)
        'End Try
        con = New OdbcConnection(DSN)
        Try
            If con.State = ConnectionState.Open Then
                'form_menu.statusdb.Text = "Database Terkoneksi"
            ElseIf con.State = ConnectionState.Closed Then
                con.Open()
                'form_menu.statusdb.Text = "Database Terkoneksi"
            End If
        Catch ex As Exception
            MsgBox("Tidak Dapat Terkoneksi dengan Database, Harap hubungi Kami !!")
            'form_menu.statusdb.Text = "Koneksi Terputus"
        End Try
    End Sub
End Module
