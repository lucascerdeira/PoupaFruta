<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_pedidos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lb_subtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_produtos = New System.Windows.Forms.PictureBox()
        Me.btn_add = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_produtos = New System.Windows.Forms.ComboBox()
        Me.txt_qtd = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagrid_pedido = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remove_item = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lb_total = New System.Windows.Forms.Label()
        Me.btn_add_empresa = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_empresas = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_confirmar)
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.datagrid_pedido)
        Me.Panel1.Controls.Add(Me.lb_total)
        Me.Panel1.Controls.Add(Me.btn_add_empresa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_empresas)
        Me.Panel1.Location = New System.Drawing.Point(26, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 538)
        Me.Panel1.TabIndex = 1
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.Color.Navy
        Me.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_confirmar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmar.ForeColor = System.Drawing.Color.White
        Me.btn_confirmar.Location = New System.Drawing.Point(355, 492)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(106, 33)
        Me.btn_confirmar.TabIndex = 13
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(297, 500)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 12
        Me.lb_sair.Text = "Sair"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Location = New System.Drawing.Point(533, 517)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(140, 1)
        Me.Panel3.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.lb_subtotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_produtos)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_produtos)
        Me.GroupBox1.Controls.Add(Me.txt_qtd)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(49, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 131)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produto"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Navy
        Me.Panel4.Location = New System.Drawing.Point(446, 120)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(85, 1)
        Me.Panel4.TabIndex = 11
        '
        'lb_subtotal
        '
        Me.lb_subtotal.AutoSize = True
        Me.lb_subtotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_subtotal.Location = New System.Drawing.Point(443, 99)
        Me.lb_subtotal.Name = "lb_subtotal"
        Me.lb_subtotal.Size = New System.Drawing.Size(69, 18)
        Me.lb_subtotal.TabIndex = 15
        Me.lb_subtotal.Text = "R$ 0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(456, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Subtotal:"
        '
        'btn_produtos
        '
        Me.btn_produtos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_produtos.Image = Global.PolpaFruta.My.Resources.Resources.products_list_icon
        Me.btn_produtos.Location = New System.Drawing.Point(552, 22)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(30, 30)
        Me.btn_produtos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_produtos.TabIndex = 13
        Me.btn_produtos.TabStop = False
        '
        'btn_add
        '
        Me.btn_add.AccessibleDescription = ""
        Me.btn_add.AccessibleName = ""
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Image = Global.PolpaFruta.My.Resources.Resources.text_plus_icon
        Me.btn_add.Location = New System.Drawing.Point(551, 83)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(40, 40)
        Me.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_add.TabIndex = 11
        Me.btn_add.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Location = New System.Drawing.Point(349, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(83, 1)
        Me.Panel2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantidade:"
        '
        'cmb_produtos
        '
        Me.cmb_produtos.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_produtos.FormattingEnabled = True
        Me.cmb_produtos.Location = New System.Drawing.Point(6, 22)
        Me.cmb_produtos.Name = "cmb_produtos"
        Me.cmb_produtos.Size = New System.Drawing.Size(530, 26)
        Me.cmb_produtos.TabIndex = 2
        '
        'txt_qtd
        '
        Me.txt_qtd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_qtd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_qtd.Location = New System.Drawing.Point(349, 90)
        Me.txt_qtd.Name = "txt_qtd"
        Me.txt_qtd.Size = New System.Drawing.Size(83, 28)
        Me.txt_qtd.TabIndex = 4
        Me.txt_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PolpaFruta.My.Resources.Resources.Logo_3
        Me.PictureBox2.Location = New System.Drawing.Point(9, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(331, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(52, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empresa:"
        '
        'datagrid_pedido
        '
        Me.datagrid_pedido.AllowUserToAddRows = False
        Me.datagrid_pedido.AllowUserToDeleteRows = False
        Me.datagrid_pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_pedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.produto, Me.quantidade, Me.preco_uni, Me.subtotal, Me.remove_item})
        Me.datagrid_pedido.Location = New System.Drawing.Point(26, 223)
        Me.datagrid_pedido.Name = "datagrid_pedido"
        Me.datagrid_pedido.ReadOnly = True
        Me.datagrid_pedido.Size = New System.Drawing.Size(649, 257)
        Me.datagrid_pedido.TabIndex = 6
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'produto
        '
        Me.produto.DataPropertyName = "nome"
        Me.produto.HeaderText = "Produto"
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        Me.produto.Width = 360
        '
        'quantidade
        '
        Me.quantidade.DataPropertyName = "qtd"
        Me.quantidade.HeaderText = "Qtd"
        Me.quantidade.Name = "quantidade"
        Me.quantidade.ReadOnly = True
        Me.quantidade.Width = 50
        '
        'preco_uni
        '
        Me.preco_uni.DataPropertyName = "preco"
        Me.preco_uni.HeaderText = "Preço Uni"
        Me.preco_uni.Name = "preco_uni"
        Me.preco_uni.ReadOnly = True
        Me.preco_uni.Width = 60
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "subtotal"
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 60
        '
        'remove_item
        '
        Me.remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.remove_item.HeaderText = "X"
        Me.remove_item.Name = "remove_item"
        Me.remove_item.ReadOnly = True
        Me.remove_item.Width = 25
        '
        'lb_total
        '
        Me.lb_total.AccessibleDescription = ""
        Me.lb_total.AutoSize = True
        Me.lb_total.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_total.ForeColor = System.Drawing.Color.Navy
        Me.lb_total.Location = New System.Drawing.Point(533, 494)
        Me.lb_total.Name = "lb_total"
        Me.lb_total.Size = New System.Drawing.Size(85, 24)
        Me.lb_total.TabIndex = 8
        Me.lb_total.Text = "R$ 0,00"
        '
        'btn_add_empresa
        '
        Me.btn_add_empresa.BackColor = System.Drawing.Color.Transparent
        Me.btn_add_empresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_empresa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_empresa.ForeColor = System.Drawing.Color.White
        Me.btn_add_empresa.Image = Global.PolpaFruta.My.Resources.Resources.user_business_add_icon
        Me.btn_add_empresa.Location = New System.Drawing.Point(591, 33)
        Me.btn_add_empresa.Name = "btn_add_empresa"
        Me.btn_add_empresa.Size = New System.Drawing.Size(40, 43)
        Me.btn_add_empresa.TabIndex = 1
        Me.btn_add_empresa.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(471, 494)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total:"
        '
        'cmb_empresas
        '
        Me.cmb_empresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_empresas.FormattingEnabled = True
        Me.cmb_empresas.Location = New System.Drawing.Point(55, 39)
        Me.cmb_empresas.Name = "cmb_empresas"
        Me.cmb_empresas.Size = New System.Drawing.Size(530, 28)
        Me.cmb_empresas.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(845, 570)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_cadastro_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_cadastro_pedidos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro de Pedidos - Polpa Fruta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_pedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_produtos As ComboBox
    Friend WithEvents txt_qtd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents datagrid_pedido As DataGridView
    Friend WithEvents btn_add_empresa As Button
    Friend WithEvents cmb_empresas As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_produtos As PictureBox
    Friend WithEvents btn_add As PictureBox
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents lb_sair As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lb_subtotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents quantidade As DataGridViewTextBoxColumn
    Friend WithEvents preco_uni As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents remove_item As DataGridViewButtonColumn
End Class
