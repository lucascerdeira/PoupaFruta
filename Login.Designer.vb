<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.login_user = New System.Windows.Forms.TextBox()
        Me.login_senha = New System.Windows.Forms.TextBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_senha_gravada = New System.Windows.Forms.TextBox()
        Me.check_visualizar = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tipo_conta = New System.Windows.Forms.ComboBox()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.txt_login_user = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Enabled = False
        Me.TabControl1.Location = New System.Drawing.Point(122, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 287)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Salmon
        Me.TabPage1.Controls.Add(Me.txt_login_user)
        Me.TabPage1.Controls.Add(Me.btn_confirmar)
        Me.TabPage1.Controls.Add(Me.login_senha)
        Me.TabPage1.Controls.Add(Me.login_user)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 261)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IDENTIFICAÇÃO"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_criar)
        Me.TabPage2.Controls.Add(Me.tipo_conta)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.check_visualizar)
        Me.TabPage2.Controls.Add(Me.txt_senha_gravada)
        Me.TabPage2.Controls.Add(Me.txt_senha)
        Me.TabPage2.Controls.Add(Me.txt_email)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_user)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 261)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "NOVA CONTA"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuário ou E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha"
        '
        'login_user
        '
        Me.login_user.Location = New System.Drawing.Point(74, 257)
        Me.login_user.Name = "login_user"
        Me.login_user.Size = New System.Drawing.Size(250, 20)
        Me.login_user.TabIndex = 3
        '
        'login_senha
        '
        Me.login_senha.BackColor = System.Drawing.SystemColors.Window
        Me.login_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.login_senha.ForeColor = System.Drawing.SystemColors.Window
        Me.login_senha.Location = New System.Drawing.Point(118, 118)
        Me.login_senha.Name = "login_senha"
        Me.login_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.login_senha.Size = New System.Drawing.Size(250, 20)
        Me.login_senha.TabIndex = 4
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(118, 161)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(250, 25)
        Me.btn_confirmar.TabIndex = 5
        Me.btn_confirmar.Text = "CONFIRMAR"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 321)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 132)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(647, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 317)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(300, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(348, 50)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(119, 317)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(122, -2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(179, 28)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "NOME DE USUÁRIO:"
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(41, 65)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(474, 20)
        Me.txt_user.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "E-MAIL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "SENHA: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "REPETIR SENHA:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(41, 120)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(474, 20)
        Me.txt_email.TabIndex = 5
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(41, 173)
        Me.txt_senha.Multiline = True
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(159, 21)
        Me.txt_senha.TabIndex = 6
        '
        'txt_senha_gravada
        '
        Me.txt_senha_gravada.Location = New System.Drawing.Point(255, 173)
        Me.txt_senha_gravada.Multiline = True
        Me.txt_senha_gravada.Name = "txt_senha_gravada"
        Me.txt_senha_gravada.Size = New System.Drawing.Size(154, 21)
        Me.txt_senha_gravada.TabIndex = 7
        '
        'check_visualizar
        '
        Me.check_visualizar.AutoSize = True
        Me.check_visualizar.Location = New System.Drawing.Point(434, 175)
        Me.check_visualizar.Name = "check_visualizar"
        Me.check_visualizar.Size = New System.Drawing.Size(89, 17)
        Me.check_visualizar.TabIndex = 8
        Me.check_visualizar.Text = "VISUALIZAR"
        Me.check_visualizar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "TIPO DE CONTA"
        '
        'tipo_conta
        '
        Me.tipo_conta.FormattingEnabled = True
        Me.tipo_conta.Location = New System.Drawing.Point(41, 232)
        Me.tipo_conta.Name = "tipo_conta"
        Me.tipo_conta.Size = New System.Drawing.Size(128, 21)
        Me.tipo_conta.TabIndex = 10
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.MintCream
        Me.btn_criar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_criar.Location = New System.Drawing.Point(310, 228)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(133, 25)
        Me.btn_criar.TabIndex = 11
        Me.btn_criar.Text = "CRIAR CONTA"
        Me.btn_criar.UseVisualStyleBackColor = False
        '
        'txt_login_user
        '
        Me.txt_login_user.BackColor = System.Drawing.SystemColors.Window
        Me.txt_login_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_login_user.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_login_user.Location = New System.Drawing.Point(118, 65)
        Me.txt_login_user.Name = "txt_login_user"
        Me.txt_login_user.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_login_user.Size = New System.Drawing.Size(250, 20)
        Me.txt_login_user.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents login_senha As TextBox
    Friend WithEvents login_user As TextBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_senha_gravada As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_criar As Button
    Friend WithEvents tipo_conta As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents check_visualizar As CheckBox
    Friend WithEvents txt_login_user As TextBox
End Class
