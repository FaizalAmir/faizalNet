Imports System.Data.Odbc
Public Class event_imblama
    Public Property imblama As skimb
    Private Sub event_imblama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Call skoneksi()
            com = New OdbcCommand("select * from log_skimb where log_nosurat = '" & noimblama_event.Text & "'", con)
            rd = com.ExecuteReader

            Do While rd.Read
                Dim x As String = rd.Item("log_nama_rincian")
                If x = "BANGUNAN LT.1" Then
                    imblama.TextBox1.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "BANGUNAN LT.2" Then
                    imblama.TextBox2.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "BANGUNAN LT.3" = True Then
                    imblama.TextBox3.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "CARPORT" Then
                    imblama.TextBox4.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "BALKON" Then
                    imblama.TextBox5.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "PAGAR" Then
                    imblama.TextBox6.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "SEPTICTANK" Then
                    imblama.TextBox7.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "DAK BETON" Then
                    imblama.TextBox8.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                ElseIf x = "TERAS" Then
                    imblama.TextBox9.Text = IIf(rd.Item("log_ukuran") = "", "0", rd.Item("log_ukuran"))
                End If
            Loop
            imblama.noimblama.Text = noimblama_event.Text
            imblama.label_penambahan.Text = "Masukan Penambahan"
            imblama.Label_imb.Text = "IMB Lama"
            imblama.tidak_ada_noimblama = False
            Me.Close()
            If Not rd.HasRows Then
                Dim tanya As String = MsgBox("Pencarian Tidak Ditemukan, Tetap Lanjutkan ?", vbYesNo)
                If tanya = vbYes Then
                    imblama.label_penambahan.Text = "Masukan IMB Lama"
                    imblama.Label_imb.Text = "Masukan Penambahan"
                    imblama.tidak_ada_noimblama = True
                    imblama.texbox_baru()
                End If
                Me.Close()
            End If
            imblama.CheckBox1.Checked = True
        Catch ex As Exception

        End Try

    End Sub
End Class