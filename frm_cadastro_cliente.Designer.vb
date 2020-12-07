<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_cliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label3 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_bairro = New System.Windows.Forms.TextBox()
        Me.txt_municipio = New System.Windows.Forms.TextBox()
        Me.txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.txt_complemento = New System.Windows.Forms.TextBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_uf = New System.Windows.Forms.MaskedTextBox()
        Me.lb_sair = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.White
        Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label3.Location = New System.Drawing.Point(266, 117)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 15)
        Label3.TabIndex = 64
        Label3.Text = "CEP: "
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.White
        Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label10.Location = New System.Drawing.Point(26, 74)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(51, 15)
        Label10.TabIndex = 79
        Label10.Text = "E-Mail:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.White
        Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label4.Location = New System.Drawing.Point(28, 117)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(67, 15)
        Label4.TabIndex = 78
        Label4.Text = "Telefone:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.White
        Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label5.Location = New System.Drawing.Point(26, 202)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(61, 15)
        Label5.TabIndex = 65
        Label5.Text = "BAIRRO:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.White
        Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label8.Location = New System.Drawing.Point(275, 202)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(70, 15)
        Label8.TabIndex = 70
        Label8.Text = "NÚMERO:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.White
        Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label7.Location = New System.Drawing.Point(291, 245)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(29, 15)
        Label7.TabIndex = 69
        Label7.Text = "UF:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.White
        Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label6.Location = New System.Drawing.Point(26, 161)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(83, 15)
        Label6.TabIndex = 68
        Label6.Text = "MUNICIPIO:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.White
        Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label9.Location = New System.Drawing.Point(28, 247)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(119, 15)
        Label9.TabIndex = 73
        Label9.Text = "COMPLEMENTO: "
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.White
        Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label2.Location = New System.Drawing.Point(137, 117)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 15)
        Label2.TabIndex = 63
        Label2.Text = "CNPJ:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.White
        Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Label1.Location = New System.Drawing.Point(26, 30)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 15)
        Label1.TabIndex = 81
        Label1.Text = "Nome:"
        AddHandler Label1.Click, AddressOf Me.lb_sair_Click
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(29, 91)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(316, 23)
        Me.txt_email.TabIndex = 2
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(31, 135)
        Me.txt_telefone.Mask = "(99) 0000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(103, 23)
        Me.txt_telefone.TabIndex = 3
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.Navy
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.White
        Me.btn_gravar.Location = New System.Drawing.Point(202, 315)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(143, 25)
        Me.btn_gravar.TabIndex = 11
        Me.btn_gravar.Text = "CONFIRMAR"
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(269, 135)
        Me.txt_cep.Mask = "00000\-000"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(76, 23)
        Me.txt_cep.TabIndex = 5
        '
        'txt_bairro
        '
        Me.txt_bairro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bairro.Location = New System.Drawing.Point(29, 219)
        Me.txt_bairro.Name = "txt_bairro"
        Me.txt_bairro.Size = New System.Drawing.Size(244, 23)
        Me.txt_bairro.TabIndex = 7
        '
        'txt_municipio
        '
        Me.txt_municipio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_municipio.Location = New System.Drawing.Point(29, 179)
        Me.txt_municipio.Name = "txt_municipio"
        Me.txt_municipio.Size = New System.Drawing.Size(316, 23)
        Me.txt_municipio.TabIndex = 6
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cnpj.Location = New System.Drawing.Point(140, 135)
        Me.txt_cnpj.Mask = "00\.000\.000/0000\-00"
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(123, 23)
        Me.txt_cnpj.TabIndex = 4
        '
        'txt_complemento
        '
        Me.txt_complemento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_complemento.Location = New System.Drawing.Point(29, 263)
        Me.txt_complemento.Name = "txt_complemento"
        Me.txt_complemento.Size = New System.Drawing.Size(259, 23)
        Me.txt_complemento.TabIndex = 9
        '
        'txt_numero
        '
        Me.txt_numero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numero.Location = New System.Drawing.Point(279, 219)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(66, 23)
        Me.txt_numero.TabIndex = 8
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(29, 48)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(316, 23)
        Me.txt_nome.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(838, 522)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txt_uf)
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.txt_nome)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.txt_telefone)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.btn_gravar)
        Me.Panel1.Controls.Add(Me.txt_numero)
        Me.Panel1.Controls.Add(Me.txt_cep)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.txt_bairro)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.txt_municipio)
        Me.Panel1.Controls.Add(Me.txt_cnpj)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.txt_complemento)
        Me.Panel1.Location = New System.Drawing.Point(27, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 371)
        Me.Panel1.TabIndex = 84
        '
        'txt_uf
        '
        Me.txt_uf.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uf.Location = New System.Drawing.Point(294, 263)
        Me.txt_uf.Mask = "aa"
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(51, 23)
        Me.txt_uf.TabIndex = 10
        Me.txt_uf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(137, 317)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 85
        Me.lb_sair.Text = "Sair"
        '
        'frm_cadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 426)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastro_cliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_cadastro_cliente_pj"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_bairro As TextBox
    Friend WithEvents txt_municipio As TextBox
    Friend WithEvents txt_cnpj As MaskedTextBox
    Friend WithEvents txt_complemento As TextBox
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lb_sair As Label
    Friend WithEvents txt_uf As MaskedTextBox
End Class
