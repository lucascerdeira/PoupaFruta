<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_listar_compra
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
        Me.data_compras = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_telefone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_cnpj = New System.Windows.Forms.TextBox()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.txt_data = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.data_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(806, 458)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.data_compras)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 1
        '
        'data_compras
        '
        Me.data_compras.AllowUserToAddRows = False
        Me.data_compras.AllowUserToDeleteRows = False
        Me.data_compras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.data_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_produto, Me.nome_produto, Me.qtd_produto, Me.preco_uni, Me.subtotal_produto})
        Me.data_compras.Location = New System.Drawing.Point(12, 181)
        Me.data_compras.Name = "data_compras"
        Me.data_compras.ReadOnly = True
        Me.data_compras.Size = New System.Drawing.Size(750, 231)
        Me.data_compras.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb_sair)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.txt_telefone)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_valor)
        Me.GroupBox1.Controls.Add(Me.txt_endereco)
        Me.GroupBox1.Controls.Add(Me.txt_cnpj)
        Me.GroupBox1.Controls.Add(Me.txt_empresa)
        Me.GroupBox1.Controls.Add(Me.txt_data)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 163)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do pedido"
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(702, 19)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 16
        Me.lb_sair.Text = "Sair"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PolpaFruta.My.Resources.Resources.Logo_4
        Me.PictureBox2.Location = New System.Drawing.Point(578, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 138)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'txt_telefone
        '
        Me.txt_telefone.Enabled = False
        Me.txt_telefone.Location = New System.Drawing.Point(264, 79)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(122, 23)
        Me.txt_telefone.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(261, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Telefone:"
        '
        'txt_valor
        '
        Me.txt_valor.Enabled = False
        Me.txt_valor.Location = New System.Drawing.Point(425, 35)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(118, 23)
        Me.txt_valor.TabIndex = 12
        '
        'txt_endereco
        '
        Me.txt_endereco.Enabled = False
        Me.txt_endereco.Location = New System.Drawing.Point(11, 123)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(532, 23)
        Me.txt_endereco.TabIndex = 11
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Enabled = False
        Me.txt_cnpj.Location = New System.Drawing.Point(392, 79)
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(151, 23)
        Me.txt_cnpj.TabIndex = 10
        '
        'txt_empresa
        '
        Me.txt_empresa.Enabled = False
        Me.txt_empresa.Location = New System.Drawing.Point(11, 79)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(247, 23)
        Me.txt_empresa.TabIndex = 9
        '
        'txt_data
        '
        Me.txt_data.Enabled = False
        Me.txt_data.Location = New System.Drawing.Point(264, 35)
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(155, 23)
        Me.txt_data.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Endereço"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(11, 35)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(247, 23)
        Me.txt_id.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Valor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID do Pedido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Data:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CNPJ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empresa:"
        '
        'id_produto
        '
        Me.id_produto.DataPropertyName = "id_produto"
        Me.id_produto.HeaderText = "ID Produto"
        Me.id_produto.Name = "id_produto"
        Me.id_produto.ReadOnly = True
        Me.id_produto.Width = 105
        '
        'nome_produto
        '
        Me.nome_produto.DataPropertyName = "nome_produto"
        Me.nome_produto.HeaderText = "Nome Produto"
        Me.nome_produto.Name = "nome_produto"
        Me.nome_produto.ReadOnly = True
        Me.nome_produto.Width = 260
        '
        'qtd_produto
        '
        Me.qtd_produto.DataPropertyName = "qtd_produto"
        Me.qtd_produto.HeaderText = "Qtd Produto"
        Me.qtd_produto.Name = "qtd_produto"
        Me.qtd_produto.ReadOnly = True
        '
        'preco_uni
        '
        Me.preco_uni.DataPropertyName = "preco_uni"
        Me.preco_uni.HeaderText = "Preço Unid."
        Me.preco_uni.Name = "preco_uni"
        Me.preco_uni.ReadOnly = True
        '
        'subtotal_produto
        '
        Me.subtotal_produto.DataPropertyName = "subtotal_produto"
        Me.subtotal_produto.HeaderText = "Subtotal Produto"
        Me.subtotal_produto.Name = "subtotal_produto"
        Me.subtotal_produto.ReadOnly = True
        Me.subtotal_produto.Width = 140
        '
        'frm_listar_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_listar_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Compra - Polpa Fruta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.data_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_telefone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_cnpj As TextBox
    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents txt_data As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents data_compras As DataGridView
    Friend WithEvents lb_sair As Label
    Friend WithEvents id_produto As DataGridViewTextBoxColumn
    Friend WithEvents nome_produto As DataGridViewTextBoxColumn
    Friend WithEvents qtd_produto As DataGridViewTextBoxColumn
    Friend WithEvents preco_uni As DataGridViewTextBoxColumn
    Friend WithEvents subtotal_produto As DataGridViewTextBoxColumn
End Class
