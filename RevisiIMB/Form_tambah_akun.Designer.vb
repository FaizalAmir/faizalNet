<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_tambah_akun
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_tambah_akun))
        Me.SIMPAN = New System.Windows.Forms.Button()
        Me.nm_satff = New System.Windows.Forms.TextBox()
        Me.nip = New System.Windows.Forms.TextBox()
        Me.napeng = New System.Windows.Forms.TextBox()
        Me.sandi = New System.Windows.Forms.TextBox()
        Me.ulang_sandi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hak_akses = New System.Windows.Forms.ComboBox()
        Me.notif = New System.Windows.Forms.Label()
        Me.betul = New System.Windows.Forms.PictureBox()
        Me.salah = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.betul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SIMPAN
        '
        Me.SIMPAN.Location = New System.Drawing.Point(309, 246)
        Me.SIMPAN.Name = "SIMPAN"
        Me.SIMPAN.Size = New System.Drawing.Size(75, 23)
        Me.SIMPAN.TabIndex = 0
        Me.SIMPAN.Text = "SIMPAN"
        Me.SIMPAN.UseVisualStyleBackColor = True
        '
        'nm_satff
        '
        Me.nm_satff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm_satff.Location = New System.Drawing.Point(213, 64)
        Me.nm_satff.Name = "nm_satff"
        Me.nm_satff.Size = New System.Drawing.Size(171, 24)
        Me.nm_satff.TabIndex = 1
        '
        'nip
        '
        Me.nip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nip.Location = New System.Drawing.Point(213, 94)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(171, 24)
        Me.nip.TabIndex = 2
        '
        'napeng
        '
        Me.napeng.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.napeng.Location = New System.Drawing.Point(213, 124)
        Me.napeng.Name = "napeng"
        Me.napeng.Size = New System.Drawing.Size(171, 24)
        Me.napeng.TabIndex = 3
        '
        'sandi
        '
        Me.sandi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sandi.Location = New System.Drawing.Point(213, 186)
        Me.sandi.Name = "sandi"
        Me.sandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.sandi.Size = New System.Drawing.Size(171, 24)
        Me.sandi.TabIndex = 4
        '
        'ulang_sandi
        '
        Me.ulang_sandi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ulang_sandi.Location = New System.Drawing.Point(213, 216)
        Me.ulang_sandi.Name = "ulang_sandi"
        Me.ulang_sandi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ulang_sandi.Size = New System.Drawing.Size(171, 24)
        Me.ulang_sandi.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nama Staff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NIP Staff"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Pengguna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kata Sandi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ulang Kata Sandi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Hak Akses"
        '
        'hak_akses
        '
        Me.hak_akses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hak_akses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hak_akses.FormattingEnabled = True
        Me.hak_akses.Items.AddRange(New Object() {"Administrator", "Operator"})
        Me.hak_akses.Location = New System.Drawing.Point(213, 154)
        Me.hak_akses.Name = "hak_akses"
        Me.hak_akses.Size = New System.Drawing.Size(171, 26)
        Me.hak_akses.TabIndex = 12
        '
        'notif
        '
        Me.notif.AutoSize = True
        Me.notif.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notif.Location = New System.Drawing.Point(397, 127)
        Me.notif.Name = "notif"
        Me.notif.Size = New System.Drawing.Size(0, 18)
        Me.notif.TabIndex = 13
        '
        'betul
        '
        Me.betul.Image = CType(resources.GetObject("betul.Image"), System.Drawing.Image)
        Me.betul.Location = New System.Drawing.Point(390, 124)
        Me.betul.Name = "betul"
        Me.betul.Size = New System.Drawing.Size(22, 25)
        Me.betul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.betul.TabIndex = 14
        Me.betul.TabStop = False
        '
        'salah
        '
        Me.salah.Image = CType(resources.GetObject("salah.Image"), System.Drawing.Image)
        Me.salah.Location = New System.Drawing.Point(390, 124)
        Me.salah.Name = "salah"
        Me.salah.Size = New System.Drawing.Size(22, 25)
        Me.salah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.salah.TabIndex = 15
        Me.salah.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(390, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(390, 216)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 244)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Akun"
        '
        'Form_tambah_akun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 293)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.salah)
        Me.Controls.Add(Me.betul)
        Me.Controls.Add(Me.notif)
        Me.Controls.Add(Me.hak_akses)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ulang_sandi)
        Me.Controls.Add(Me.sandi)
        Me.Controls.Add(Me.napeng)
        Me.Controls.Add(Me.nip)
        Me.Controls.Add(Me.nm_satff)
        Me.Controls.Add(Me.SIMPAN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_tambah_akun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_tambah_akun"
        CType(Me.betul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SIMPAN As System.Windows.Forms.Button
    Friend WithEvents nm_satff As System.Windows.Forms.TextBox
    Friend WithEvents nip As System.Windows.Forms.TextBox
    Friend WithEvents napeng As System.Windows.Forms.TextBox
    Friend WithEvents sandi As System.Windows.Forms.TextBox
    Friend WithEvents ulang_sandi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hak_akses As System.Windows.Forms.ComboBox
    Friend WithEvents notif As System.Windows.Forms.Label
    Friend WithEvents betul As System.Windows.Forms.PictureBox
    Friend WithEvents salah As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
