Imports System.Data.Odbc
Imports System.IO
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '    Dim valu As Integer = 1
        '    Dim emptyTextBoxes =
        'From txt In Me.Controls.OfType(Of TextBox)()
        'Where Not IsDBNull(txt.Text)
        'Select txt.Name
        '    If emptyTextBoxes.Any Then
        '        MessageBox.Show(String.Format("Please fill following textboxes: {0}",
        '                        String.Join(",", emptyTextBoxes)))
        '    End If
        Dim calc As Integer = 3
        For value As Integer = 1 To calc
            Dim testString As String = "TextBox" + value.ToString
            Dim teststring2 As String = "Label" + value.ToString
            Dim TB As TextBox = Nothing
            Dim TB2 As Label = Nothing
            Dim Ctr As Control = Controls(testString)
            Dim Ctr2 As Control = Controls(teststring2)
            If TypeOf Ctr Is TextBox Then
                TB = DirectCast(Ctr, TextBox)
                If TypeOf Ctr2 Is Label Then
                    TB2 = DirectCast(Ctr2, Label)
                End If
            End If
            If TB IsNot Nothing Then
                Call skoneksi()
                com = New OdbcCommand("insert into rinci_bangunan value(NULL,'" & TextBox4.Text & "','" & Ctr2.Text & "','" & Ctr.Text & "')", con)
                com.ExecuteNonQuery()
            End If
            MsgBox("alhamdulillah")
        Next
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim calc As Integer = 3
        For value As Integer = 1 To calc
            Dim testString As String = "TextBox" + value.ToString
            Dim teststring1 As String = "TextBox" + Val(calc + value).ToString
            Dim teststring2 As String = "Label" + value.ToString
            Dim TB As TextBox = Nothing
            Dim TB1 As TextBox = Nothing
            Dim TB2 As Label = Nothing
            Dim Ctr As Control = Controls(testString)
            Dim Ctr1 As Control = Controls(teststring1)
            Dim Ctr2 As Control = Controls(teststring2)
            If TypeOf Ctr Is TextBox Then
                TB = DirectCast(Ctr, TextBox)
                If TypeOf Ctr1 Is TextBox Then
                    TB1 = DirectCast(Ctr1, TextBox)
                    If TypeOf Ctr2 Is Label Then
                        TB2 = DirectCast(Ctr2, Label)
                    End If
                End If
            End If
            If TB IsNot Nothing Then
                Call skoneksi()
                com = New OdbcCommand("insert into rinci_bangunan value(NULL,'" & TextBox6.Text & "','" & Ctr2.Text & "','" & Ctr.Text & "')", con)
                com.ExecuteNonQuery()
                MsgBox("alhamdulillah")
            End If
        Next

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Opentest()

    End Sub

    Sub Opentest()
        Dim whileArray As String
        Dim myOpenFileDialog As New OpenFileDialog()
        myOpenFileDialog.CheckFileExists = True
        myOpenFileDialog.DefaultExt = "txt"
        myOpenFileDialog.InitialDirectory = "C:\Users\ABIDZAR\Documents"
        myOpenFileDialog.Multiselect = False

        If myOpenFileDialog.ShowDialog = DialogResult.OK Then
            whileArray = System.IO.File.ReadAllText(myOpenFileDialog.FileName)
            Dim linecount = System.IO.File.ReadAllLines(myOpenFileDialog.FileName).Length
            text1.Text = whileArray.Length
            number1.Text = CountNumbers(whileArray).ToString
            word1.Text = CountWord(whileArray).ToString
            symbol1.Text = CountSymbol(whileArray).ToString
            space1.Text = CountSpace(whileArray).ToString
            sign1.Text = Countsign(whileArray).ToString
            'TextBox1.Text = myOpenFileDialog.FileName.Length
            line1.Text = System.IO.File.ReadAllLines(myOpenFileDialog.FileName).Length.ToString
            TextBox1.Text = (ReadALine(whileArray, GetNumberOfLines(whileArray), 1))
        End If
    End Sub

    Function CountNumbers(ByVal phrase As String) As Integer
        Dim numberCount As Integer
        For Each ch As Char In phrase
            If Char.IsNumber(ch) Then numberCount += 1
        Next
        Return numberCount
        Return phrase.Count(Function(c) Char.IsDigit(c))
    End Function

    Function CountWord(ByVal phrase As String) As Integer
        Dim wordCount As Integer
        For Each ch As Char In phrase
            If Char.IsLetter(ch) Then wordCount += 1
        Next
        Return wordCount
        Return phrase.Count(Function(c) Char.IsDigit(c))
    End Function

    Function CountSymbol(ByVal phrase As String) As Integer
        Dim symbolCount As Integer
        For Each ch As Char In phrase
            If Char.IsSymbol(ch) Then symbolCount += 1
        Next
        Return symbolCount
        Return phrase.Count(Function(c) Char.IsDigit(c))
    End Function

    Function CountSpace(ByVal phrase As String) As Integer
        Dim symbolCount As Integer
        For Each ch As Char In phrase
            If Char.IsWhiteSpace(ch) Then symbolCount += 1
        Next
        Return symbolCount
        Return phrase.Count(Function(c) Char.IsDigit(c))
    End Function

    Function Countsign(ByVal phrase As String) As Integer
        Dim symbolCount As Integer
        For Each ch As Char In phrase
            If Char.IsPunctuation(ch) Then symbolCount += 1
        Next
        Return symbolCount
        Return phrase.Count(Function(c) Char.IsDigit(c))
    End Function

    Public Function ReadALine(ByVal File_Path As String, ByVal TotalLine As Integer, ByVal Line2Read As Integer) As String
        Dim Buffer As Array
        Dim Line As String
        If TotalLine <= Line2Read Then
            Return "No Such Line"
        End If
        Buffer = File.ReadAllLines(File_Path)
        Line = Buffer(Line2Read)
        Return Line
    End Function

    Public Function GetNumberOfLines(ByVal file_path As String) As Integer
        Dim sr As New StreamReader(file_path)
        Dim NumberOfLines As Integer
        Do While sr.Peek >= 0
            sr.ReadLine()
            NumberOfLines += 1
        Loop
        Return NumberOfLines
        sr.Close()
        sr.Dispose()
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim counter = 0
        For Each testCharacter In TextBox1.Text
            If (Char.IsPunctuation(testCharacter)) Then
                counter += 1
                TextBox2.Text = counter
            End If
        Next
    End Sub
End Class