<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lnlNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lnlNome
        '
        Me.lnlNome.AutoSize = True
        Me.lnlNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlNome.Location = New System.Drawing.Point(118, 86)
        Me.lnlNome.Name = "lnlNome"
        Me.lnlNome.Size = New System.Drawing.Size(128, 20)
        Me.lnlNome.TabIndex = 0
        Me.lnlNome.Text = "Digite seu nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(122, 127)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(198, 20)
        Me.txtNome.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(122, 168)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(245, 167)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "S&air"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 339)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lnlNome)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meu Primeiro APP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lnlNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnSair As Button
End Class
