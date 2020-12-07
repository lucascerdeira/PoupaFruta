<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_lista_produtos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_procurar = New System.Windows.Forms.PictureBox()
        Me.txt_procurar = New System.Windows.Forms.TextBox()
        Me.data_produtos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco_uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_procurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.btn_procurar)
        Me.Panel1.Controls.Add(Me.txt_procurar)
        Me.Panel1.Controls.Add(Me.data_produtos)
        Me.Panel1.Location = New System.Drawing.Point(26, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 393)
        Me.Panel1.TabIndex = 1
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(574, 22)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 11
        Me.lb_sair.Text = "Sair"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PolpaFruta.My.Resources.Resources.Logo_3
        Me.PictureBox2.Location = New System.Drawing.Point(21, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(278, 50)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'btn_procurar
        '
        Me.btn_procurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_procurar.Image = Global.PolpaFruta.My.Resources.Resources.search_icon
        Me.btn_procurar.Location = New System.Drawing.Point(584, 64)
        Me.btn_procurar.Name = "btn_procurar"
        Me.btn_procurar.Size = New System.Drawing.Size(30, 30)
        Me.btn_procurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_procurar.TabIndex = 9
        Me.btn_procurar.TabStop = False
        '
        'txt_procurar
        '
        Me.txt_procurar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_procurar.Location = New System.Drawing.Point(21, 64)
        Me.txt_procurar.Name = "txt_procurar"
        Me.txt_procurar.Size = New System.Drawing.Size(557, 32)
        Me.txt_procurar.TabIndex = 8
        '
        'data_produtos
        '
        Me.data_produtos.AllowUserToAddRows = False
        Me.data_produtos.AllowUserToDeleteRows = False
        Me.data_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.produto, Me.descricao, Me.preco_uni})
        Me.data_produtos.Location = New System.Drawing.Point(21, 100)
        Me.data_produtos.Name = "data_produtos"
        Me.data_produtos.ReadOnly = True
        Me.data_produtos.Size = New System.Drawing.Size(593, 246)
        Me.data_produtos.TabIndex = 7
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'produto
        '
        Me.produto.HeaderText = "Produto"
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        Me.produto.Width = 200
        '
        'descricao
        '
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        Me.descricao.Width = 200
        '
        'preco_uni
        '
        Me.preco_uni.HeaderText = "Preço Uni"
        Me.preco_uni.Name = "preco_uni"
        Me.preco_uni.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 458)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_lista_produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_lista_produtos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Produtos - Polpa Fruta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_procurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_procurar As PictureBox
    Friend WithEvents txt_procurar As TextBox
    Friend WithEvents data_produtos As DataGridView
    Friend WithEvents lb_sair As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents preco_uni As DataGridViewTextBoxColumn
End Class
