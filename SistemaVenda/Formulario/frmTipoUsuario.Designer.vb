<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoUsuario
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
        Dim NivelPermissaoLabel As System.Windows.Forms.Label
        Dim NomeTipoUsuarioLabel As System.Windows.Forms.Label
        Me.Tipousuario_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NivelPermissaoTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NomeTipoUsuarioTextBox = New System.Windows.Forms.ComboBox()
        Me.Tipousuario_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NivelPermissaoLabel = New System.Windows.Forms.Label()
        NomeTipoUsuarioLabel = New System.Windows.Forms.Label()
        CType(Me.Tipousuario_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipousuario_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tipousuario_tbBindingSource
        '
        Me.Tipousuario_tbBindingSource.DataSource = GetType(SistemaVenda.tipousuario_tb)
        '
        'NivelPermissaoLabel
        '
        NivelPermissaoLabel.AutoSize = True
        NivelPermissaoLabel.Location = New System.Drawing.Point(26, 138)
        NivelPermissaoLabel.Name = "NivelPermissaoLabel"
        NivelPermissaoLabel.Size = New System.Drawing.Size(108, 19)
        NivelPermissaoLabel.TabIndex = 3
        NivelPermissaoLabel.Text = "Nivel Permissao:"
        '
        'NivelPermissaoTextBox
        '
        Me.NivelPermissaoTextBox.Location = New System.Drawing.Point(30, 160)
        Me.NivelPermissaoTextBox.Name = "NivelPermissaoTextBox"
        Me.NivelPermissaoTextBox.Size = New System.Drawing.Size(294, 25)
        Me.NivelPermissaoTextBox.TabIndex = 4
        '
        'NomeTipoUsuarioLabel
        '
        NomeTipoUsuarioLabel.AutoSize = True
        NomeTipoUsuarioLabel.Location = New System.Drawing.Point(26, 78)
        NomeTipoUsuarioLabel.Name = "NomeTipoUsuarioLabel"
        NomeTipoUsuarioLabel.Size = New System.Drawing.Size(130, 19)
        NomeTipoUsuarioLabel.TabIndex = 5
        NomeTipoUsuarioLabel.Text = "Nome Tipo Usuario:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.SistemaVenda.My.Resources.Resources.Checked_Checkbox_2_25px
        Me.Button2.Location = New System.Drawing.Point(224, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Salvar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NomeTipoUsuarioTextBox
        '
        Me.NomeTipoUsuarioTextBox.FormattingEnabled = True
        Me.NomeTipoUsuarioTextBox.Items.AddRange(New Object() {"Administrador", "Simples"})
        Me.NomeTipoUsuarioTextBox.Location = New System.Drawing.Point(30, 100)
        Me.NomeTipoUsuarioTextBox.Name = "NomeTipoUsuarioTextBox"
        Me.NomeTipoUsuarioTextBox.Size = New System.Drawing.Size(294, 25)
        Me.NomeTipoUsuarioTextBox.TabIndex = 27
        '
        'Tipousuario_tbDataGridView
        '
        Me.Tipousuario_tbDataGridView.AutoGenerateColumns = False
        Me.Tipousuario_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tipousuario_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tipousuario_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Tipousuario_tbDataGridView.DataSource = Me.Tipousuario_tbBindingSource
        Me.Tipousuario_tbDataGridView.Location = New System.Drawing.Point(24, 232)
        Me.Tipousuario_tbDataGridView.Name = "Tipousuario_tbDataGridView"
        Me.Tipousuario_tbDataGridView.Size = New System.Drawing.Size(300, 254)
        Me.Tipousuario_tbDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idTipoUsuario"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idTipoUsuario"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomeTipoUsuario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NomeTipoUsuario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NivelPermissao"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NivelPermissao"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmTipoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 515)
        Me.Controls.Add(Me.Tipousuario_tbDataGridView)
        Me.Controls.Add(Me.NomeTipoUsuarioTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(NivelPermissaoLabel)
        Me.Controls.Add(Me.NivelPermissaoTextBox)
        Me.Controls.Add(NomeTipoUsuarioLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmTipoUsuario"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Tipo de Usuario"
        CType(Me.Tipousuario_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipousuario_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tipousuario_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NivelPermissaoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NomeTipoUsuarioTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tipousuario_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
