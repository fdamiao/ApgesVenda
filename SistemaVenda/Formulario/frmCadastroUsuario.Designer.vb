<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroUsuario
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
        Me.components = New System.ComponentModel.Container()
        Dim DataNascimentoLabel As System.Windows.Forms.Label
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim NomeUsuarioLabel As System.Windows.Forms.Label
        Dim SenhaUsuarioLabel As System.Windows.Forms.Label
        Me.Usuario_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataNascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Usuario_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoUsuarioTextBox = New System.Windows.Forms.ComboBox()
        Me.TipousuariotbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        DataNascimentoLabel = New System.Windows.Forms.Label()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        NomeUsuarioLabel = New System.Windows.Forms.Label()
        SenhaUsuarioLabel = New System.Windows.Forms.Label()
        CType(Me.Usuario_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuario_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipousuariotbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataNascimentoLabel
        '
        DataNascimentoLabel.AutoSize = True
        DataNascimentoLabel.Location = New System.Drawing.Point(26, 114)
        DataNascimentoLabel.Name = "DataNascimentoLabel"
        DataNascimentoLabel.Size = New System.Drawing.Size(117, 19)
        DataNascimentoLabel.TabIndex = 1
        DataNascimentoLabel.Text = "Data Nascimento:"
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Location = New System.Drawing.Point(236, 114)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(89, 19)
        IdUsuarioLabel.TabIndex = 5
        IdUsuarioLabel.Text = "Tipo Usuario:"
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.Location = New System.Drawing.Point(30, 82)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(113, 19)
        NomeCompletoLabel.TabIndex = 7
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'NomeUsuarioLabel
        '
        NomeUsuarioLabel.AutoSize = True
        NomeUsuarioLabel.Location = New System.Drawing.Point(43, 148)
        NomeUsuarioLabel.Name = "NomeUsuarioLabel"
        NomeUsuarioLabel.Size = New System.Drawing.Size(100, 19)
        NomeUsuarioLabel.TabIndex = 9
        NomeUsuarioLabel.Text = "Nome Usuario:"
        '
        'SenhaUsuarioLabel
        '
        SenhaUsuarioLabel.AutoSize = True
        SenhaUsuarioLabel.Location = New System.Drawing.Point(43, 179)
        SenhaUsuarioLabel.Name = "SenhaUsuarioLabel"
        SenhaUsuarioLabel.Size = New System.Drawing.Size(100, 19)
        SenhaUsuarioLabel.TabIndex = 11
        SenhaUsuarioLabel.Text = "Senha Usuario:"
        '
        'Usuario_tbBindingSource
        '
        Me.Usuario_tbBindingSource.DataSource = GetType(SistemaVenda.usuario_tb)
        '
        'DataNascimentoDateTimePicker
        '
        Me.DataNascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Usuario_tbBindingSource, "DataNascimento", True))
        Me.DataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataNascimentoDateTimePicker.Location = New System.Drawing.Point(149, 110)
        Me.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker"
        Me.DataNascimentoDateTimePicker.Size = New System.Drawing.Size(74, 25)
        Me.DataNascimentoDateTimePicker.TabIndex = 2
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(149, 79)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(306, 25)
        Me.NomeCompletoTextBox.TabIndex = 1
        '
        'NomeUsuarioTextBox
        '
        Me.NomeUsuarioTextBox.Location = New System.Drawing.Point(149, 145)
        Me.NomeUsuarioTextBox.Name = "NomeUsuarioTextBox"
        Me.NomeUsuarioTextBox.Size = New System.Drawing.Size(306, 25)
        Me.NomeUsuarioTextBox.TabIndex = 4
        '
        'SenhaUsuarioTextBox
        '
        Me.SenhaUsuarioTextBox.Location = New System.Drawing.Point(149, 176)
        Me.SenhaUsuarioTextBox.Name = "SenhaUsuarioTextBox"
        Me.SenhaUsuarioTextBox.Size = New System.Drawing.Size(306, 25)
        Me.SenhaUsuarioTextBox.TabIndex = 5
        Me.SenhaUsuarioTextBox.UseSystemPasswordChar = True
        '
        'Usuario_tbDataGridView
        '
        Me.Usuario_tbDataGridView.AutoGenerateColumns = False
        Me.Usuario_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Usuario_tbDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Usuario_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Usuario_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Usuario_tbDataGridView.DataSource = Me.Usuario_tbBindingSource
        Me.Usuario_tbDataGridView.Location = New System.Drawing.Point(26, 288)
        Me.Usuario_tbDataGridView.Name = "Usuario_tbDataGridView"
        Me.Usuario_tbDataGridView.Size = New System.Drawing.Size(486, 264)
        Me.Usuario_tbDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idUsuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idUsuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomeCompleto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NomeCompleto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DataNascimento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DataNascimento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NomeUsuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "NomeUsuario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SenhaUsuario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SenhaUsuario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'IdTipoUsuarioTextBox
        '
        Me.IdTipoUsuarioTextBox.DataSource = Me.TipousuariotbBindingSource
        Me.IdTipoUsuarioTextBox.DisplayMember = "NomeTipoUsuario"
        Me.IdTipoUsuarioTextBox.FormattingEnabled = True
        Me.IdTipoUsuarioTextBox.Location = New System.Drawing.Point(331, 111)
        Me.IdTipoUsuarioTextBox.Name = "IdTipoUsuarioTextBox"
        Me.IdTipoUsuarioTextBox.Size = New System.Drawing.Size(124, 25)
        Me.IdTipoUsuarioTextBox.TabIndex = 3
        Me.IdTipoUsuarioTextBox.ValueMember = "idTipoUsuario"
        '
        'TipousuariotbBindingSource
        '
        Me.TipousuariotbBindingSource.DataSource = GetType(SistemaVenda.tipousuario_tb)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.SistemaVenda.My.Resources.Resources.Checked_Checkbox_2_25px
        Me.Button2.Location = New System.Drawing.Point(355, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salvar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SistemaVenda.My.Resources.Resources.Plus_Math_25px
        Me.Button1.Location = New System.Drawing.Point(239, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Novo"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.SistemaVenda.My.Resources.Resources.Plus_25px
        Me.Button3.Location = New System.Drawing.Point(461, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 25)
        Me.Button3.TabIndex = 13
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmCadastroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 581)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IdTipoUsuarioTextBox)
        Me.Controls.Add(Me.Usuario_tbDataGridView)
        Me.Controls.Add(DataNascimentoLabel)
        Me.Controls.Add(Me.DataNascimentoDateTimePicker)
        Me.Controls.Add(IdUsuarioLabel)
        Me.Controls.Add(NomeCompletoLabel)
        Me.Controls.Add(Me.NomeCompletoTextBox)
        Me.Controls.Add(NomeUsuarioLabel)
        Me.Controls.Add(Me.NomeUsuarioTextBox)
        Me.Controls.Add(SenhaUsuarioLabel)
        Me.Controls.Add(Me.SenhaUsuarioTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmCadastroUsuario"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Novo Usuario"
        CType(Me.Usuario_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuario_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipousuariotbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Usuario_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataNascimentoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomeCompletoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeUsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SenhaUsuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Usuario_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoUsuarioTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipousuariotbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
