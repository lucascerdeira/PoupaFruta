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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.btn_pesquisar = New System.Windows.Forms.PictureBox()
        Me.txt_pesquisa = New System.Windows.Forms.TextBox()
        Me.data_pedidos = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_aberto = New System.Windows.Forms.CheckBox()
        Me.chk_fechado = New System.Windows.Forms.CheckBox()
        Me.lb_editar = New System.Windows.Forms.Label()
        Me.id_pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome_empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnpj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_pedido = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.remover = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_pesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(962, 571)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lb_editar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.btn_pesquisar)
        Me.Panel1.Controls.Add(Me.txt_pesquisa)
        Me.Panel1.Controls.Add(Me.data_pedidos)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(882, 492)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pesquisar por ID do Pedido:"
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(827, 17)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 7
        Me.lb_sair.Text = "Sair"
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pesquisar.Image = Global.PolpaFruta.My.Resources.Resources.search_icon
        Me.btn_pesquisar.Location = New System.Drawing.Point(500, 100)
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.Size = New System.Drawing.Size(30, 30)
        Me.btn_pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_pesquisar.TabIndex = 3
        Me.btn_pesquisar.TabStop = False
        '
        'txt_pesquisa
        '
        Me.txt_pesquisa.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pesquisa.Location = New System.Drawing.Point(13, 102)
        Me.txt_pesquisa.Name = "txt_pesquisa"
        Me.txt_pesquisa.Size = New System.Drawing.Size(481, 26)
        Me.txt_pesquisa.TabIndex = 2
        '
        'data_pedidos
        '
        Me.data_pedidos.AllowUserToAddRows = False
        Me.data_pedidos.AllowUserToDeleteRows = False
        Me.data_pedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.data_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_pedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_pedido, Me.nome_empresa, Me.cnpj, Me.total, Me.date_compra, Me.status_pedido, Me.remover})
        Me.data_pedidos.Location = New System.Drawing.Point(13, 138)
        Me.data_pedidos.Name = "data_pedidos"
        Me.data_pedidos.Size = New System.Drawing.Size(854, 336)
        Me.data_pedidos.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PolpaFruta.My.Resources.Resources.Logo_3
        Me.PictureBox2.Location = New System.Drawing.Point(13, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 51)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_aberto)
        Me.GroupBox1.Controls.Add(Me.chk_fechado)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(657, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 50)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar pedidos"
        '
        'chk_aberto
        '
        Me.chk_aberto.AutoSize = True
        Me.chk_aberto.Checked = True
        Me.chk_aberto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_aberto.ForeColor = System.Drawing.Color.Navy
        Me.chk_aberto.Location = New System.Drawing.Point(9, 23)
        Me.chk_aberto.Name = "chk_aberto"
        Me.chk_aberto.Size = New System.Drawing.Size(82, 22)
        Me.chk_aberto.TabIndex = 4
        Me.chk_aberto.Text = "Aberto"
        Me.chk_aberto.UseVisualStyleBackColor = True
        '
        'chk_fechado
        '
        Me.chk_fechado.AutoSize = True
        Me.chk_fechado.Checked = True
        Me.chk_fechado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_fechado.ForeColor = System.Drawing.Color.Navy
        Me.chk_fechado.Location = New System.Drawing.Point(97, 23)
        Me.chk_fechado.Name = "chk_fechado"
        Me.chk_fechado.Size = New System.Drawing.Size(97, 22)
        Me.chk_fechado.TabIndex = 5
        Me.chk_fechado.Text = "Fechado"
        Me.chk_fechado.UseVisualStyleBackColor = True
        '
        'lb_editar
        '
        Me.lb_editar.AutoSize = True
        Me.lb_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_editar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_editar.Location = New System.Drawing.Point(553, 107)
        Me.lb_editar.Name = "lb_editar"
        Me.lb_editar.Size = New System.Drawing.Size(56, 18)
        Me.lb_editar.TabIndex = 9
        Me.lb_editar.Text = "Editar"
        '
        'id_pedido
        '
        Me.id_pedido.DataPropertyName = "id_pedido"
        Me.id_pedido.HeaderText = "ID Pedido"
        Me.id_pedido.Name = "id_pedido"
        Me.id_pedido.ReadOnly = True
        Me.id_pedido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.id_pedido.Width = 150
        '
        'nome_empresa
        '
        Me.nome_empresa.DataPropertyName = "nome_empresa"
        Me.nome_empresa.HeaderText = "Empresa"
        Me.nome_empresa.Name = "nome_empresa"
        Me.nome_empresa.ReadOnly = True
        Me.nome_empresa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.nome_empresa.Width = 200
        '
        'cnpj
        '
        Me.cnpj.DataPropertyName = "cnpj"
        Me.cnpj.HeaderText = "CNPJ"
        Me.cnpj.Name = "cnpj"
        Me.cnpj.ReadOnly = True
        Me.cnpj.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cnpj.Width = 130
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'date_compra
        '
        Me.date_compra.DataPropertyName = "data_compra"
        Me.date_compra.HeaderText = "Data Compra"
        Me.date_compra.Name = "date_compra"
        Me.date_compra.ReadOnly = True
        Me.date_compra.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.date_compra.Width = 130
        '
        'status_pedido
        '
        Me.status_pedido.DataPropertyName = "status_pedido"
        Me.status_pedido.HeaderText = "Status"
        Me.status_pedido.Name = "status_pedido"
        Me.status_pedido.ReadOnly = True
        Me.status_pedido.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'remover
        '
        Me.remover.DataPropertyName = "remover"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remover.DefaultCellStyle = DataGridViewCellStyle1
        Me.remover.HeaderText = "Remover"
        Me.remover.Name = "remover"
        Me.remover.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.remover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.remover.Text = "REMOVER"
        Me.remover.UseColumnTextForButtonValue = True
        Me.remover.Visible = False
        '
        'frm_lista_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_lista_pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de pedidos - Polpa Fruta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_pesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lb_sair As Label
    Friend WithEvents btn_pesquisar As PictureBox
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents data_pedidos As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_aberto As CheckBox
    Friend WithEvents chk_fechado As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_editar As Label
    Friend WithEvents id_pedido As DataGridViewTextBoxColumn
    Friend WithEvents nome_empresa As DataGridViewTextBoxColumn
    Friend WithEvents cnpj As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents date_compra As DataGridViewTextBoxColumn
    Friend WithEvents status_pedido As DataGridViewButtonColumn
    Friend WithEvents remover As DataGridViewButtonColumn
End Class
