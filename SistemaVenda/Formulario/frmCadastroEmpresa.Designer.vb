<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroEmpresa
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim LocalizacaoEmpresaLabel As System.Windows.Forms.Label
        Dim NomeEmpresaLabel As System.Windows.Forms.Label
        Dim NuitEmpresaLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LocalizacaoEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NuitEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        LocalizacaoEmpresaLabel = New System.Windows.Forms.Label()
        NomeEmpresaLabel = New System.Windows.Forms.Label()
        NuitEmpresaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.SistemaVenda.My.Resources.Resources.Checked_Checkbox_2_25px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(385, 248)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 30)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Salvar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(94, 183)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(68, 19)
        ContactoLabel.TabIndex = 14
        ContactoLabel.Text = "Contacto:"
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.Location = New System.Drawing.Point(168, 180)
        Me.ContactoTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(299, 25)
        Me.ContactoTextBox.TabIndex = 19
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(118, 218)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 19)
        EmailLabel.TabIndex = 17
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(168, 215)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(299, 25)
        Me.EmailTextBox.TabIndex = 20
        '
        'LocalizacaoEmpresaLabel
        '
        LocalizacaoEmpresaLabel.AutoSize = True
        LocalizacaoEmpresaLabel.Location = New System.Drawing.Point(26, 117)
        LocalizacaoEmpresaLabel.Name = "LocalizacaoEmpresaLabel"
        LocalizacaoEmpresaLabel.Size = New System.Drawing.Size(136, 19)
        LocalizacaoEmpresaLabel.TabIndex = 22
        LocalizacaoEmpresaLabel.Text = "Localizacao Empresa:"
        '
        'LocalizacaoEmpresaTextBox
        '
        Me.LocalizacaoEmpresaTextBox.Location = New System.Drawing.Point(168, 114)
        Me.LocalizacaoEmpresaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LocalizacaoEmpresaTextBox.Name = "LocalizacaoEmpresaTextBox"
        Me.LocalizacaoEmpresaTextBox.Size = New System.Drawing.Size(299, 25)
        Me.LocalizacaoEmpresaTextBox.TabIndex = 16
        '
        'NomeEmpresaLabel
        '
        NomeEmpresaLabel.AutoSize = True
        NomeEmpresaLabel.Location = New System.Drawing.Point(57, 84)
        NomeEmpresaLabel.Name = "NomeEmpresaLabel"
        NomeEmpresaLabel.Size = New System.Drawing.Size(105, 19)
        NomeEmpresaLabel.TabIndex = 23
        NomeEmpresaLabel.Text = "Nome Empresa:"
        '
        'NomeEmpresaTextBox
        '
        Me.NomeEmpresaTextBox.Location = New System.Drawing.Point(168, 81)
        Me.NomeEmpresaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeEmpresaTextBox.Name = "NomeEmpresaTextBox"
        Me.NomeEmpresaTextBox.Size = New System.Drawing.Size(299, 25)
        Me.NomeEmpresaTextBox.TabIndex = 15
        '
        'NuitEmpresaLabel
        '
        NuitEmpresaLabel.AutoSize = True
        NuitEmpresaLabel.Location = New System.Drawing.Point(68, 150)
        NuitEmpresaLabel.Name = "NuitEmpresaLabel"
        NuitEmpresaLabel.Size = New System.Drawing.Size(94, 19)
        NuitEmpresaLabel.TabIndex = 24
        NuitEmpresaLabel.Text = "Nuit Empresa:"
        '
        'NuitEmpresaTextBox
        '
        Me.NuitEmpresaTextBox.Location = New System.Drawing.Point(168, 147)
        Me.NuitEmpresaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NuitEmpresaTextBox.Name = "NuitEmpresaTextBox"
        Me.NuitEmpresaTextBox.Size = New System.Drawing.Size(299, 25)
        Me.NuitEmpresaTextBox.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(488, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.SistemaVenda.My.Resources.Resources.Folder_25px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(488, 81)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 30)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Buscar Imagem"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 27
        '
        'frmCadastroEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 347)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(LocalizacaoEmpresaLabel)
        Me.Controls.Add(Me.LocalizacaoEmpresaTextBox)
        Me.Controls.Add(NomeEmpresaLabel)
        Me.Controls.Add(Me.NomeEmpresaTextBox)
        Me.Controls.Add(NuitEmpresaLabel)
        Me.Controls.Add(Me.NuitEmpresaTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmCadastroEmpresa"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "frmCadastroEmpresa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContactoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalizacaoEmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeEmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NuitEmpresaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
