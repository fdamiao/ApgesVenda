<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim DescricaoCategoriaLabel As System.Windows.Forms.Label
        Dim NomeCategoriaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DescricaoCategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeCategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Categoria_tbDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria_tbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        DescricaoCategoriaLabel = New System.Windows.Forms.Label()
        NomeCategoriaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Categoria_tbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Categoria_tbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescricaoCategoriaLabel
        '
        DescricaoCategoriaLabel.AutoSize = True
        DescricaoCategoriaLabel.Location = New System.Drawing.Point(28, 130)
        DescricaoCategoriaLabel.Name = "DescricaoCategoriaLabel"
        DescricaoCategoriaLabel.Size = New System.Drawing.Size(133, 19)
        DescricaoCategoriaLabel.TabIndex = 1
        DescricaoCategoriaLabel.Text = "Descricao Categoria:"
        '
        'NomeCategoriaLabel
        '
        NomeCategoriaLabel.AutoSize = True
        NomeCategoriaLabel.Location = New System.Drawing.Point(28, 78)
        NomeCategoriaLabel.Name = "NomeCategoriaLabel"
        NomeCategoriaLabel.Size = New System.Drawing.Size(112, 19)
        NomeCategoriaLabel.TabIndex = 5
        NomeCategoriaLabel.Text = "Nome Categoria:"
        '
        'DescricaoCategoriaTextBox
        '
        Me.DescricaoCategoriaTextBox.Location = New System.Drawing.Point(32, 153)
        Me.DescricaoCategoriaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DescricaoCategoriaTextBox.Multiline = True
        Me.DescricaoCategoriaTextBox.Name = "DescricaoCategoriaTextBox"
        Me.DescricaoCategoriaTextBox.Size = New System.Drawing.Size(228, 45)
        Me.DescricaoCategoriaTextBox.TabIndex = 2
        '
        'NomeCategoriaTextBox
        '
        Me.NomeCategoriaTextBox.Location = New System.Drawing.Point(32, 101)
        Me.NomeCategoriaTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NomeCategoriaTextBox.Name = "NomeCategoriaTextBox"
        Me.NomeCategoriaTextBox.Size = New System.Drawing.Size(228, 25)
        Me.NomeCategoriaTextBox.TabIndex = 6
        '
        'Categoria_tbDataGridView
        '
        Me.Categoria_tbDataGridView.AutoGenerateColumns = False
        Me.Categoria_tbDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Categoria_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Categoria_tbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Categoria_tbDataGridView.DataSource = Me.Categoria_tbBindingSource
        Me.Categoria_tbDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Categoria_tbDataGridView.Location = New System.Drawing.Point(23, 262)
        Me.Categoria_tbDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Categoria_tbDataGridView.Name = "Categoria_tbDataGridView"
        Me.Categoria_tbDataGridView.Size = New System.Drawing.Size(401, 198)
        Me.Categoria_tbDataGridView.TabIndex = 6
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(305, 171)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 27)
        Me.btnSalvar.TabIndex = 7
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(274, 78)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(106, 19)
        Label1.TabIndex = 8
        Label1.Text = " Controle Stock:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SIM", "NAO"})
        Me.ComboBox1.Location = New System.Drawing.Point(278, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idCategoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCategoria"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomeCategoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NomeCategoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DescricaoCategoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DescricaoCategoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Categoria_tbBindingSource
        '
        Me.Categoria_tbBindingSource.DataSource = GetType(SistemaVenda.categoria_tb)
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 486)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Categoria_tbDataGridView)
        Me.Controls.Add(DescricaoCategoriaLabel)
        Me.Controls.Add(Me.DescricaoCategoriaTextBox)
        Me.Controls.Add(NomeCategoriaLabel)
        Me.Controls.Add(Me.NomeCategoriaTextBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmCategoria"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.Text = "Registrar Categorias dos Produtos"
        CType(Me.Categoria_tbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Categoria_tbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Categoria_tbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DescricaoCategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeCategoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Categoria_tbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
