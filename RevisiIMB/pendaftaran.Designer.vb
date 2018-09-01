<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendaftaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pendaftaran))
        Me.noktp = New System.Windows.Forms.TextBox()
        Me.jenisijin = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Ket = New System.Windows.Forms.ComboBox()
        Me.jenisusaha = New System.Windows.Forms.TextBox()
        Me.alamatijin = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.peruntukan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hapus = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.alamat_pem = New System.Windows.Forms.TextBox()
        Me.napem = New System.Windows.Forms.TextBox()
        Me.cekno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cekktp = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.deskel = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'noktp
        '
        Me.noktp.Location = New System.Drawing.Point(230, 127)
        Me.noktp.Name = "noktp"
        Me.noktp.Size = New System.Drawing.Size(247, 20)
        Me.noktp.TabIndex = 64
        '
        'jenisijin
        '
        Me.jenisijin.Enabled = False
        Me.jenisijin.Location = New System.Drawing.Point(164, 78)
        Me.jenisijin.Name = "jenisijin"
        Me.jenisijin.Size = New System.Drawing.Size(211, 20)
        Me.jenisijin.TabIndex = 63
        Me.jenisijin.Text = "IMB"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(97, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "NO KTP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(204, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "m2"
        '
        'Ket
        '
        Me.Ket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Ket.FormattingEnabled = True
        Me.Ket.Items.AddRange(New Object() {"Baru", "Penambahan/Balik Nama"})
        Me.Ket.Location = New System.Drawing.Point(699, 338)
        Me.Ket.Name = "Ket"
        Me.Ket.Size = New System.Drawing.Size(212, 21)
        Me.Ket.TabIndex = 61
        '
        'jenisusaha
        '
        Me.jenisusaha.Location = New System.Drawing.Point(163, 104)
        Me.jenisusaha.Name = "jenisusaha"
        Me.jenisusaha.Size = New System.Drawing.Size(211, 20)
        Me.jenisusaha.TabIndex = 60
        Me.jenisusaha.Text = "-"
        '
        'alamatijin
        '
        Me.alamatijin.Location = New System.Drawing.Point(699, 365)
        Me.alamatijin.Multiline = True
        Me.alamatijin.Name = "alamatijin"
        Me.alamatijin.Size = New System.Drawing.Size(212, 104)
        Me.alamatijin.TabIndex = 58
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(549, 475)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "DESA/KELURAHAN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(549, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "ALAMAT IJIN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(548, 341)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "KETERANGAN"
        '
        'peruntukan
        '
        Me.peruntukan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.peruntukan.FormattingEnabled = True
        Me.peruntukan.Items.AddRange(New Object() {"Rumah Tinggal", "Ruko"})
        Me.peruntukan.Location = New System.Drawing.Point(163, 25)
        Me.peruntukan.Name = "peruntukan"
        Me.peruntukan.Size = New System.Drawing.Size(211, 21)
        Me.peruntukan.TabIndex = 54
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lb)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(551, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 100)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LUAS"
        '
        'lb
        '
        Me.lb.Location = New System.Drawing.Point(157, 58)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(42, 20)
        Me.lb.TabIndex = 4
        Me.lb.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(205, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "m2"
        '
        'lt
        '
        Me.lt.Location = New System.Drawing.Point(157, 21)
        Me.lt.Name = "lt"
        Me.lt.Size = New System.Drawing.Size(42, 20)
        Me.lt.TabIndex = 2
        Me.lt.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "LUAS BANGUNAN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "LUAS TANAH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "JENIS USAHA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(28, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "PERUNTUKAN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "NO PENDAFTARAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(285, 390)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 134)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QRQODE"
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(170, 501)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 23)
        Me.hapus.TabIndex = 48
        Me.hapus.Text = "BERSIH"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(170, 390)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 47
        Me.simpan.Text = "SIMPAN"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(230, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(247, 20)
        Me.DateTimePicker1.TabIndex = 46
        '
        'alamat_pem
        '
        Me.alamat_pem.Location = New System.Drawing.Point(230, 208)
        Me.alamat_pem.Multiline = True
        Me.alamat_pem.Name = "alamat_pem"
        Me.alamat_pem.Size = New System.Drawing.Size(247, 124)
        Me.alamat_pem.TabIndex = 45
        '
        'napem
        '
        Me.napem.Location = New System.Drawing.Point(230, 182)
        Me.napem.Multiline = True
        Me.napem.Name = "napem"
        Me.napem.Size = New System.Drawing.Size(247, 20)
        Me.napem.TabIndex = 44
        '
        'cekno
        '
        Me.cekno.Location = New System.Drawing.Point(163, 52)
        Me.cekno.Name = "cekno"
        Me.cekno.Size = New System.Drawing.Size(211, 20)
        Me.cekno.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "ALAMAT PEMOHON"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "NAMA PEMOHON"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "TANGGAL DAFTAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "JENIS PERIJINAN"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(483, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 66
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(483, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(483, 124)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'cekktp
        '
        Me.cekktp.Location = New System.Drawing.Point(230, 153)
        Me.cekktp.Name = "cekktp"
        Me.cekktp.Size = New System.Drawing.Size(247, 23)
        Me.cekktp.TabIndex = 71
        Me.cekktp.Text = "Cek No.KTP"
        Me.cekktp.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(86, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 299)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(86, 374)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(436, 169)
        Me.GroupBox4.TabIndex = 73
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.deskel)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.cekno)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.peruntukan)
        Me.GroupBox5.Controls.Add(Me.jenisusaha)
        Me.GroupBox5.Controls.Add(Me.jenisijin)
        Me.GroupBox5.Location = New System.Drawing.Point(536, 69)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(421, 474)
        Me.GroupBox5.TabIndex = 74
        Me.GroupBox5.TabStop = False
        '
        'deskel
        '
        Me.deskel.FormattingEnabled = True
        Me.deskel.Items.AddRange(New Object() {"Desa Cicalengka", "Desa Cihuni", "Desa Cijantra", "Desa Jatake", "Desa Kadu Sirung", "Desa Karang Tengah", "Desa Lengkong Kulon", "Desa Malang Nengah", "Kelurahan Medang", "Desa Pagedangan", "Desa Situgadung"})
        Me.deskel.Location = New System.Drawing.Point(163, 406)
        Me.deskel.Name = "deskel"
        Me.deskel.Size = New System.Drawing.Size(212, 21)
        Me.deskel.TabIndex = 66
        '
        'GroupBox6
        '
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(55, 48)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(924, 518)
        Me.GroupBox6.TabIndex = 75
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PENDAFTARAN"
        '
        'pendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.cekktp)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.noktp)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Ket)
        Me.Controls.Add(Me.alamatijin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.alamat_pem)
        Me.Controls.Add(Me.napem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "pendaftaran"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents noktp As System.Windows.Forms.TextBox
    Friend WithEvents jenisijin As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Ket As System.Windows.Forms.ComboBox
    Friend WithEvents jenisusaha As System.Windows.Forms.TextBox
    Friend WithEvents alamatijin As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents peruntukan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lb As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents simpan As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents alamat_pem As System.Windows.Forms.TextBox
    Friend WithEvents napem As System.Windows.Forms.TextBox
    Friend WithEvents cekno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cekktp As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents deskel As System.Windows.Forms.ComboBox

End Class
