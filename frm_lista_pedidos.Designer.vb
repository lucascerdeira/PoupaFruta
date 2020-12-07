<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_pedidos
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.btn_pesquisar = New System.Windows.Forms.PictureBox()
        Me.group = New System.Windows.Forms.GroupBox()
        Me.chk_aberto = New System.Windows.Forms.CheckBox()
        Me.chk_fechado = New System.Windows.Forms.CheckBox()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_pesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(913, 562)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.btn_pesquisar)
        Me.Panel1.Controls.Add(Me.group)
        Me.Panel1.Controls.Add(Me.txt_pesquisa)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 532)
        Me.Panel1.TabIndex = 1
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.Blue
        Me.lb_sair.Location = New System.Drawing.Point(649, 28)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(47, 22)
        Me.lb_sair.TabIndex = 8
        Me.lb_sair.Text = "Sair"
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pesquisar.Image = Global.PolpaFruta.My.Resources.Resources.search_icon
        Me.btn_pesquisar.Location = New System.Drawing.Point(460, 78)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(30, 30)
        Me.btn_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_pesquisar.TabIndex = 7
        Me.btn_pesquisar.TabStop = False
        '
        'group
        '
        Me.group.Controls.Add(Me.chk_aberto)
        Me.group.Controls.Add(Me.chk_fechado)
        Me.group.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.group.Location = New System.Drawing.Point(531, 68)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(165, 43)
        Me.group.TabIndex = 6
        Me.group.TabStop = False
        Me.group.Text = "Pedidos"
        '
        'chk_aberto
        '
        Me.chk_aberto.AutoSize = True
        Me.chk_aberto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aberto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_aberto.Location = New System.Drawing.Point(6, 20)
        Me.chk_aberto.Name = "chk_aberto"
        Me.chk_aberto.Size = New System.Drawing.Size(70, 19)
        Me.chk_aberto.TabIndex = 3
        Me.chk_aberto.Text = "Aberto"
        Me.chk_aberto.UseVisualStyleBackColor = True
        '
        'chk_fechado
        '
        Me.chk_fechado.AutoSize = True
        Me.chk_fechado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fechado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_fechado.Location = New System.Drawing.Point(82, 20)
        Me.chk_fechado.Name = "chk_fechado"
        Me.chk_fechado.Size = New System.Drawing.Size(82, 19)
        Me.chk_fechado.TabIndex = 4
        Me.chk_fechado.Text = "Fechado"
        Me.chk_fechado.UseVisualStyleBackColor = True
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(16, 79)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(438, 29)
        Me.txt_pesquisa.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PolpaFruta.My.Resources.Resources.Logo_3
        Me.PictureBox2.Location = New System.Drawing.Point(16, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(270, 48)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 400)
        Me.DataGridView1.TabIndex = 0
        '
        'frm_lista_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_lista_pedidos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Visuzlizar Pedidos - Polpa Fruta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_pesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group.ResumeLayout(False)
        Me.group.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_pesquisar As PictureBox
    Friend WithEvents group As GroupBox
    Friend WithEvents chk_aberto As CheckBox
    Friend WithEvents chk_fechado As CheckBox
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lb_sair As Label
End Class
