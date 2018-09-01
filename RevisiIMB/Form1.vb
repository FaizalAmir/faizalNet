Imports System.Data.Odbc

Public Class Form1
    Dim stst As String

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'menghitung jumlah karakter
        If TextBox1.Text.Count >= 11 Then
            TextBox2.Text = "yes"
        ElseIf TextBox1.Text.Count <= 11 Then
            TextBox2.Text = "no"
        End If
        Label1.Text = TextBox1.Text.Count
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call skoneksi()
        com = New OdbcCommand("select * from sk_pendaftaran order by no_daftar desc", con)
        rd = com.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TextBox1.Text = "640/001- Kec.Pgd/" + Format(Now, "yyyy")
        ElseIf rd.HasRows Then
            Dim auto_num As String
            Dim str_num As String
            Dim year_str As Date = rd.Item("tgl_daftar")
            If Not Format(year_str, "yyyy") = Format(Now, "yyyy") Then
                TextBox1.Text = "640/001- Kec.Pgd/" + Format(Now, "yyyy")
            Else
                str_num = Microsoft.VisualBasic.Mid(rd.Item("no_daftar"), 5, 7)
                auto_num = Val(str_num) + 1
                TextBox1.Text = "640/" + Mid("00", 1, 5 - auto_num.Length) & auto_num + "- Kec.Pgd/" + Format(Now, "yyyy")
            End If
        End If
    End Sub
End Class