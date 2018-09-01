<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Akun
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
        Me.username = New System.Windows.Forms.ComboBox()
        Me.passskrg = New System.Windows.Forms.TextBox()
        Me.passbaru = New System.Windows.Forms.TextBox()
        Me.ulangpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hapus = New System.Windows.Forms.Button()
        Me.apdet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.FormattingEnabled = True
        Me.username.Location = New System.Drawing.Point(228, 24)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(213, 24)
        Me.username.TabIndex = 0
        '
        'passskrg
        '
        Me.passskrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passskrg.Location = New System.Drawing.Point(228, 63)
        Me.passskrg.Name = "passskrg"
        Me.passskrg.Size = New System.Drawing.Size(213, 22)
        Me.passskrg.TabIndex = 1
        '
        'passbaru
        '
        Me.passbaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passbaru.Location = New System.Drawing.Point(228, 91)
        Me.passbaru.Name = "passbaru"
        Me.passbaru.Size = New System.Drawing.Size(213, 22)
        Me.passbaru.TabIndex = 2
        '
        'ulangpass
        '
        Me.ulangpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ulangpass.Location = New System.Drawing.Point(228, 119)
        Me.ulangpass.Name = "ulangpass"
        Me.ulangpass.Size = New System.Drawing.Size(213, 22)
        Me.ulangpass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Akun Username Anda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Masukan Password Sekarang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password Baru"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ulang Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Passwor Sekarang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pilih Akun Username "
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(366, 169)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 23)
        Me.hapus.TabIndex = 10
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'apdet
        '
        Me.apdet.Location = New System.Drawing.Point(285, 169)
        Me.apdet.Name = "apdet"
        Me.apdet.Size = New System.Drawing.Size(75, 23)
        Me.apdet.TabIndex = 11
        Me.apdet.Text = "UBAH"
        Me.apdet.UseVisualStyleBackColor = True
        '
        'Form_Data_Akun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 204)
        Me.Controls.Add(Me.apdet)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ulangpass)
        Me.Controls.Add(Me.passbaru)
        Me.Controls.Add(Me.passskrg)
        Me.Controls.Add(Me.username)
        Me.Name = "Form_Data_Akun"
        Me.Text = "Form_Data_Akun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username As System.Windows.Forms.ComboBox
    Friend WithEvents passskrg As System.Windows.Forms.TextBox
    Friend WithEvents passbaru As System.Windows.Forms.TextBox
    Friend WithEvents ulangpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents hapus As System.Windows.Forms.Button
    Friend WithEvents apdet As System.Windows.Forms.Button
End Class
