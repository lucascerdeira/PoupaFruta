<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.status_bar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_sair_programa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_sair_conta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDePedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.adm_tool_strip = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciarUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_bar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1034, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'status_bar
        '
        Me.status_bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.status_bar.Name = "status_bar"
        Me.status_bar.Size = New System.Drawing.Size(119, 17)
        Me.status_bar.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.adm_tool_strip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strip_sair_programa, Me.menu_sair_conta})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'strip_sair_programa
        '
        Me.strip_sair_programa.Name = "strip_sair_programa"
        Me.strip_sair_programa.Size = New System.Drawing.Size(165, 22)
        Me.strip_sair_programa.Text = "Sair do Programa"
        '
        'menu_sair_conta
        '
        Me.menu_sair_conta.Name = "menu_sair_conta"
        Me.menu_sair_conta.Size = New System.Drawing.Size(165, 22)
        Me.menu_sair_conta.Text = "Sair da Conta"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDePedidosToolStripMenuItem, Me.CadastrarPedidoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Pedidos"
        '
        'ListaDePedidosToolStripMenuItem
        '
        Me.ListaDePedidosToolStripMenuItem.Name = "ListaDePedidosToolStripMenuItem"
        Me.ListaDePedidosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ListaDePedidosToolStripMenuItem.Text = "Lista de Pedidos"
        '
        'CadastrarPedidoToolStripMenuItem
        '
        Me.CadastrarPedidoToolStripMenuItem.Name = "CadastrarPedidoToolStripMenuItem"
        Me.CadastrarPedidoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CadastrarPedidoToolStripMenuItem.Text = "Cadastrar Pedido"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeClientesToolStripMenuItem, Me.CadastrarClienteToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem2.Text = "Clientes"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Clientes"
        '
        'CadastrarClienteToolStripMenuItem
        '
        Me.CadastrarClienteToolStripMenuItem.Name = "CadastrarClienteToolStripMenuItem"
        Me.CadastrarClienteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeProdutosToolStripMenuItem, Me.CadastrarProdutoToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripMenuItem3.Text = "Produtos"
        '
        'ListaDeProdutosToolStripMenuItem
        '
        Me.ListaDeProdutosToolStripMenuItem.Name = "ListaDeProdutosToolStripMenuItem"
        Me.ListaDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ListaDeProdutosToolStripMenuItem.Text = "Lista de Produtos"
        '
        'CadastrarProdutoToolStripMenuItem
        '
        Me.CadastrarProdutoToolStripMenuItem.Name = "CadastrarProdutoToolStripMenuItem"
        Me.CadastrarProdutoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto"
        '
        'adm_tool_strip
        '
        Me.adm_tool_strip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GerenciarUsuáriosToolStripMenuItem, Me.CriarUsuárioToolStripMenuItem})
        Me.adm_tool_strip.Name = "adm_tool_strip"
        Me.adm_tool_strip.Size = New System.Drawing.Size(96, 20)
        Me.adm_tool_strip.Text = "Administração"
        '
        'GerenciarUsuáriosToolStripMenuItem
        '
        Me.GerenciarUsuáriosToolStripMenuItem.Name = "GerenciarUsuáriosToolStripMenuItem"
        Me.GerenciarUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.GerenciarUsuáriosToolStripMenuItem.Text = "Gerenciar Usuários"
        '
        'CriarUsuárioToolStripMenuItem
        '
        Me.CriarUsuárioToolStripMenuItem.Name = "CriarUsuárioToolStripMenuItem"
        Me.CriarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.CriarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário"
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PolpaFruta.My.Resources.Resources.Logo_4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1034, 511)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "frm_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio - Polpa Fruta"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents status_bar As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strip_sair_programa As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListaDePedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarPedidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents adm_tool_strip As ToolStripMenuItem
    Friend WithEvents GerenciarUsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CriarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_sair_conta As ToolStripMenuItem
End Class
