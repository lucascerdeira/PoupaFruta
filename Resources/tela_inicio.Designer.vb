<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tela_inicio
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.progress_splash = New System.Windows.Forms.ProgressBar()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.progress_splash)
        Me.Panel1.Controls.Add(Me.img_logo)
        Me.Panel1.Location = New System.Drawing.Point(49, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 217)
        Me.Panel1.TabIndex = 0
        '
        'progress_splash
        '
        Me.progress_splash.Location = New System.Drawing.Point(41, 171)
        Me.progress_splash.Name = "progress_splash"
        Me.progress_splash.Size = New System.Drawing.Size(241, 23)
        Me.progress_splash.TabIndex = 1
        '
        'img_logo
        '
        Me.img_logo.Image = Global.PolpaFruta.My.Resources.Resources.Logo_4
        Me.img_logo.Location = New System.Drawing.Point(27, 24)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(270, 132)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_logo.TabIndex = 0
        Me.img_logo.TabStop = False
        '
        'tela_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PolpaFruta.My.Resources.Resources.Backgroud_login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(420, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tela_inicio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents progress_splash As ProgressBar
    Friend WithEvents img_logo As PictureBox
End Class
