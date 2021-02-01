<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciar_usuarios
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
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.lb_sair = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.data_usuarios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.lb_sair)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.data_usuarios)
        Me.Panel1.Location = New System.Drawing.Point(18, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 426)
        Me.Panel1.TabIndex = 1
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.Navy
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.Color.White
        Me.btn_editar.Location = New System.Drawing.Point(563, 21)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(105, 29)
        Me.btn_editar.TabIndex = 8
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'lb_sair
        '
        Me.lb_sair.AutoSize = True
        Me.lb_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_sair.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb_sair.Location = New System.Drawing.Point(694, 26)
        Me.lb_sair.Name = "lb_sair"
        Me.lb_sair.Size = New System.Drawing.Size(40, 18)
        Me.lb_sair.TabIndex = 7
        Me.lb_sair.Text = "Sair"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PolpaFruta.My.Resources.Resources.Logo_3
        Me.PictureBox3.Location = New System.Drawing.Point(16, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(269, 50)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'data_usuarios
        '
        Me.data_usuarios.AllowUserToAddRows = False
        Me.data_usuarios.AllowUserToDeleteRows = False
        Me.data_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.data_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nome, Me.usuario, Me.senha, Me.status})
        Me.data_usuarios.Location = New System.Drawing.Point(16, 77)
        Me.data_usuarios.Name = "data_usuarios"
        Me.data_usuarios.ReadOnly = True
        Me.data_usuarios.Size = New System.Drawing.Size(718, 331)
        Me.data_usuarios.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 250
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        Me.usuario.Width = 200
        '
        'senha
        '
        Me.senha.HeaderText = "Senha"
        Me.senha.Name = "senha"
        Me.senha.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.status.Width = 75
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(809, 459)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_gerenciar_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_gerenciar_usuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gerenciamento de Usuarios - Polpa Fruta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents data_usuarios As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lb_sair As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewButtonColumn
    Friend WithEvents btn_editar As Button
End Class
