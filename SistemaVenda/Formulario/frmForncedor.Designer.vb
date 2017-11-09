<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForncedor
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
        Dim NomeFonecedorLabel As System.Windows.Forms.Label
        Dim NuitLabel As System.Windows.Forms.Label
        Dim FonecedorCodLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Fonecedor_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FonecedorCodTextBox = New System.Windows.Forms.TextBox()
        Me.NuitTextBox = New System.Windows.Forms.TextBox()
        Me.NomeFonecedorTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fonecedor_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NomeFonecedorLabel = New System.Windows.Forms.Label()
        NuitLabel = New System.Windows.Forms.Label()
        FonecedorCodLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.Fonecedor_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.Fonecedor_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeFonecedorLabel
        '
        NomeFonecedorLabel.AutoSize = True
        NomeFonecedorLabel.Location = New System.Drawing.Point(104, 84)
        NomeFonecedorLabel.Name = "NomeFonecedorLabel"
        NomeFonecedorLabel.Size = New System.Drawing.Size(117, 19)
        NomeFonecedorLabel.TabIndex = 2
        NomeFonecedorLabel.Text = "Nome Fonecedor:"
        '
        'NuitLabel
        '
        NuitLabel.AutoSize = True
        NuitLabel.Location = New System.Drawing.Point(183, 117)
        NuitLabel.Name = "NuitLabel"
        NuitLabel.Size = New System.Drawing.Size(38, 19)
        NuitLabel.TabIndex = 4
        NuitLabel.Text = "Nuit:"
        '
        'FonecedorCodLabel
        '
        FonecedorCodLabel.AutoSize = True
        FonecedorCodLabel.Location = New System.Drawing.Point(116, 51)
        FonecedorCodLabel.Name = "FonecedorCodLabel"
        FonecedorCodLabel.Size = New System.Drawing.Size(105, 19)
        FonecedorCodLabel.TabIndex = 6
        FonecedorCodLabel.Text = "Fonecedor Cod:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(177, 150)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 19)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "Email:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(153, 181)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(68, 19)
        ContactoLabel.TabIndex = 12
        ContactoLabel.Text = "Contacto:"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 82)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(665, 335)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.Fonecedor_tbDataGridView)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 6
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(657, 293)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Lista de Fornecedores"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 8
        '
        'Fonecedor_tbDataGridView
        '
        Me.Fonecedor_tbDataGridView.AutoGenerateColumns = False
        Me.Fonecedor_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Fonecedor_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Fonecedor_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Fonecedor_tbDataGridView.DataSource = Me.Fonecedor_tbBindingSource
        Me.Fonecedor_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fonecedor_tbDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Fonecedor_tbDataGridView.Name = "Fonecedor_tbDataGridView"
        Me.Fonecedor_tbDataGridView.Size = New System.Drawing.Size(657, 293)
        Me.Fonecedor_tbDataGridView.TabIndex = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Button2)
        Me.MetroTabPage2.Controls.Add(Me.Button1)
        Me.MetroTabPage2.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage2.Controls.Add(ContactoLabel)
        Me.MetroTabPage2.Controls.Add(Me.ContactoTextBox)
        Me.MetroTabPage2.Controls.Add(EmailLabel)
        Me.MetroTabPage2.Controls.Add(Me.EmailTextBox)
        Me.MetroTabPage2.Controls.Add(FonecedorCodLabel)
        Me.MetroTabPage2.Controls.Add(Me.FonecedorCodTextBox)
        Me.MetroTabPage2.Controls.Add(NuitLabel)
        Me.MetroTabPage2.Controls.Add(Me.NuitTextBox)
        Me.MetroTabPage2.Controls.Add(NomeFonecedorLabel)
        Me.MetroTabPage2.Controls.Add(Me.NomeFonecedorTextBox)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 6
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(657, 293)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Cadastro de Fornecedor"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 8
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fonecedor_tbBindingSource, "Contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(227, 178)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(216, 25)
        Me.ContactoTextBox.TabIndex = 13
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fonecedor_tbBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(227, 147)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(216, 25)
        Me.EmailTextBox.TabIndex = 9
        '
        'FonecedorCodTextBox
        '
        Me.FonecedorCodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fonecedor_tbBindingSource, "FonecedorCod", True))
        Me.FonecedorCodTextBox.Location = New System.Drawing.Point(227, 48)
        Me.FonecedorCodTextBox.Name = "FonecedorCodTextBox"
        Me.FonecedorCodTextBox.Size = New System.Drawing.Size(214, 25)
        Me.FonecedorCodTextBox.TabIndex = 7
        '
        'NuitTextBox
        '
        Me.NuitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fonecedor_tbBindingSource, "Nuit", True))
        Me.NuitTextBox.Location = New System.Drawing.Point(227, 114)
        Me.NuitTextBox.Name = "NuitTextBox"
        Me.NuitTextBox.Size = New System.Drawing.Size(214, 25)
        Me.NuitTextBox.TabIndex = 5
        '
        'NomeFonecedorTextBox
        '
        Me.NomeFonecedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fonecedor_tbBindingSource, "NomeFonecedor", True))
        Me.NomeFonecedorTextBox.Location = New System.Drawing.Point(227, 81)
        Me.NomeFonecedorTextBox.Name = "NomeFonecedorTextBox"
        Me.NomeFonecedorTextBox.Size = New System.Drawing.Size(214, 25)
        Me.NomeFonecedorTextBox.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idFonecedor_tb"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idFonecedor_tb"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FonecedorCod"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fon.Cod"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomeFonecedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NomeFonecedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nuit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nuit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contacto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Data_Fornecedor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data_Fornecedor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Fonecedor_tbBindingSource
        '
        Me.Fonecedor_tbBindingSource.DataSource = GetType(SistemaVenda.fonecedor_tb)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.SistemaVenda.My.Resources.Resources.Checked_Checkbox_2_25px
        Me.Button2.Location = New System.Drawing.Point(343, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 35)
        Me.Button2.TabIndex = 24
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
        Me.Button1.Location = New System.Drawing.Point(227, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Novo"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVenda.My.Resources.Resources.Supplier_96px
        Me.PictureBox1.Location = New System.Drawing.Point(456, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmForncedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(711, 443)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmForncedor"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Cadastro Fornecedor"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.Fonecedor_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.Fonecedor_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Fonecedor_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fonecedor_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ContactoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FonecedorCodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NuitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeFonecedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
