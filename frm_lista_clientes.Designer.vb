<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_lista_clientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_pesquisar = New System.Windows.Forms.TextBox()
        Me.data_clientes = New System.Windows.Forms.DataGridView()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnpj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remover = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1298, 621)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txt_pesquisar)
        Me.Panel1.Controls.Add(Me.data_clientes)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1257, 558)
        Me.Panel1.TabIndex = 1
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Navy
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(970, 21)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(193, 32)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.Text = "Editar Dados"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(1196, 26)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 6
        Me.lb_sair.Text = "Sair"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PolpaFruta.My.Resources.Resources.Logo_3
        Me.PictureBox3.Location = New System.Drawing.Point(16, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(269, 50)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PolpaFruta.My.Resources.Resources.search_icon
        Me.PictureBox2.Location = New System.Drawing.Point(771, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'txt_pesquisar
        '
        Me.txt_pesquisar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisar.Location = New System.Drawing.Point(291, 26)
        Me.txt_pesquisar.Name = "txt_pesquisar"
        Me.txt_pesquisar.Size = New System.Drawing.Size(474, 26)
        Me.txt_pesquisar.TabIndex = 1
        '
        'data_clientes
        '
        Me.data_clientes.AllowUserToAddRows = False
        Me.data_clientes.AllowUserToDeleteRows = False
        Me.data_clientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.data_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nome, Me.email, Me.telefone, Me.cnpj, Me.cep, Me.municipio, Me.bairro, Me.numero, Me.complemento, Me.uf, Me.remover})
        Me.data_clientes.Location = New System.Drawing.Point(16, 66)
        Me.data_clientes.Name = "data_clientes"
        Me.data_clientes.Size = New System.Drawing.Size(1228, 477)
        Me.data_clientes.TabIndex = 0
        '
        'nome
        '
        Me.nome.DataPropertyName = "nome"
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.Width = 200
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        Me.email.Width = 180
        '
        'telefone
        '
        Me.telefone.DataPropertyName = "telefone"
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        '
        'cnpj
        '
        Me.cnpj.DataPropertyName = "cnpj"
        Me.cnpj.HeaderText = "CNPJ"
        Me.cnpj.Name = "cnpj"
        Me.cnpj.Width = 120
        '
        'cep
        '
        Me.cep.DataPropertyName = "cep"
        Me.cep.HeaderText = "CEP"
        Me.cep.Name = "cep"
        Me.cep.Width = 70
        '
        'municipio
        '
        Me.municipio.DataPropertyName = "municipio"
        Me.municipio.HeaderText = "Município"
        Me.municipio.Name = "municipio"
        Me.municipio.Width = 180
        '
        'bairro
        '
        Me.bairro.DataPropertyName = "bairro"
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.Name = "bairro"
        Me.bairro.Width = 150
        '
        'numero
        '
        Me.numero.DataPropertyName = "numero"
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.Width = 50
        '
        'complemento
        '
        Me.complemento.DataPropertyName = "complemento"
        Me.complemento.HeaderText = "Complemento"
        Me.complemento.Name = "complemento"
        Me.complemento.Width = 80
        '
        'uf
        '
        Me.uf.DataPropertyName = "uf"
        Me.uf.HeaderText = "UF"
        Me.uf.Name = "uf"
        Me.uf.Width = 35
        '
        'remover
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.remover.DefaultCellStyle = DataGridViewCellStyle1
        Me.remover.HeaderText = "X"
        Me.remover.Name = "remover"
        Me.remover.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.remover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.remover.Text = "X"
        Me.remover.ToolTipText = "X"
        Me.remover.UseColumnTextForButtonValue = True
        Me.remover.Width = 20
        '
        'frm_lista_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_lista_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Clientes - Polpa Fruta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents data_clientes As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_pesquisar As TextBox
    Friend WithEvents lb_sair As Label
    Friend WithEvents btn_editar As Button
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents cnpj As DataGridViewTextBoxColumn
    Friend WithEvents cep As DataGridViewTextBoxColumn
    Friend WithEvents municipio As DataGridViewTextBoxColumn
    Friend WithEvents bairro As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents complemento As DataGridViewTextBoxColumn
    Friend WithEvents uf As DataGridViewTextBoxColumn
    Friend WithEvents remover As DataGridViewButtonColumn
End Class
