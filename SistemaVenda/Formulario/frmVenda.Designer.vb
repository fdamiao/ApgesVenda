<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenda
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
        Dim NuitEmpresaLabel As System.Windows.Forms.Label
        Dim NomeEmpresaLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtDesignacao = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtRefer = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desginacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prec_Unt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idProdut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ckIva = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotakValor = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.cmbFormaPagamento = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NuitEmpresaLabel1 = New System.Windows.Forms.Label()
        Me.NomeEmpresaLabel1 = New System.Windows.Forms.Label()
        Me.EmailLabel1 = New System.Windows.Forms.Label()
        Me.ContactoLabel1 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        NuitEmpresaLabel = New System.Windows.Forms.Label()
        NomeEmpresaLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NuitEmpresaLabel
        '
        NuitEmpresaLabel.AutoSize = True
        NuitEmpresaLabel.Location = New System.Drawing.Point(167, 119)
        NuitEmpresaLabel.Name = "NuitEmpresaLabel"
        NuitEmpresaLabel.Size = New System.Drawing.Size(94, 19)
        NuitEmpresaLabel.TabIndex = 22
        NuitEmpresaLabel.Text = "Nuit Empresa:"
        '
        'NomeEmpresaLabel
        '
        NomeEmpresaLabel.AutoSize = True
        NomeEmpresaLabel.Location = New System.Drawing.Point(156, 50)
        NomeEmpresaLabel.Name = "NomeEmpresaLabel"
        NomeEmpresaLabel.Size = New System.Drawing.Size(105, 19)
        NomeEmpresaLabel.TabIndex = 20
        NomeEmpresaLabel.Text = "Nome Empresa:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(217, 73)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 19)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(193, 96)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(68, 19)
        ContactoLabel.TabIndex = 16
        ContactoLabel.Text = "Contacto:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(25, 79)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(67, 13)
        Label5.TabIndex = 30
        Label5.Text = "Valor Prod.:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(7, 10)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(85, 13)
        Label8.TabIndex = 28
        Label8.Text = "Nome Produto:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(62, 33)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(30, 13)
        Label9.TabIndex = 26
        Label9.Text = "Ref.:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(21, 56)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(71, 13)
        Label10.TabIndex = 24
        Label10.Text = "Quant. Exist:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.txtDesignacao)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtRefer)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(952, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Produtos"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(662, 24)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(82, 25)
        Me.txtQty.TabIndex = 8
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SistemaVenda.My.Resources.Resources.Money_25px
        Me.PictureBox4.Location = New System.Drawing.Point(767, 25)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Location = New System.Drawing.Point(798, 24)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(122, 25)
        Me.txtTotal.TabIndex = 6
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SistemaVenda.My.Resources.Resources.Qt_25px
        Me.PictureBox3.Location = New System.Drawing.Point(631, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'txtDesignacao
        '
        Me.txtDesignacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDesignacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDesignacao.Location = New System.Drawing.Point(251, 25)
        Me.txtDesignacao.Name = "txtDesignacao"
        Me.txtDesignacao.Size = New System.Drawing.Size(359, 25)
        Me.txtDesignacao.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SistemaVenda.My.Resources.Resources.Seasrch_25px
        Me.PictureBox2.Location = New System.Drawing.Point(220, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaVenda.My.Resources.Resources.Barcode_25px
        Me.PictureBox1.Location = New System.Drawing.Point(6, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtRefer
        '
        Me.txtRefer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtRefer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtRefer.Location = New System.Drawing.Point(37, 24)
        Me.txtRefer.Name = "txtRefer"
        Me.txtRefer.Size = New System.Drawing.Size(152, 25)
        Me.txtRefer.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(668, 330)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Pedidos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Referencia, Me.Desginacao, Me.Prec_Unt, Me.Quantidade, Me.Total, Me.idProdut})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(662, 306)
        Me.DataGridView1.TabIndex = 0
        '
        'Referencia
        '
        Me.Referencia.FillWeight = 30.0!
        Me.Referencia.HeaderText = "Refe."
        Me.Referencia.Name = "Referencia"
        '
        'Desginacao
        '
        Me.Desginacao.HeaderText = "Desgnicacao"
        Me.Desginacao.Name = "Desginacao"
        '
        'Prec_Unt
        '
        Me.Prec_Unt.FillWeight = 50.0!
        Me.Prec_Unt.HeaderText = "Prec_Unitario"
        Me.Prec_Unt.Name = "Prec_Unt"
        '
        'Quantidade
        '
        Me.Quantidade.FillWeight = 30.0!
        Me.Quantidade.HeaderText = "Qty"
        Me.Quantidade.Name = "Quantidade"
        '
        'Total
        '
        Me.Total.FillWeight = 50.0!
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'idProdut
        '
        Me.idProdut.HeaderText = "idProd"
        Me.idProdut.Name = "idProdut"
        Me.idProdut.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ckIva)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtTotakValor)
        Me.GroupBox3.Controls.Add(Me.txtIva)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.cmbFormaPagamento)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(700, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(278, 327)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pagamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Total:"
        '
        'ckIva
        '
        Me.ckIva.AutoSize = True
        Me.ckIva.Checked = True
        Me.ckIva.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckIva.Location = New System.Drawing.Point(26, 94)
        Me.ckIva.Name = "ckIva"
        Me.ckIva.Size = New System.Drawing.Size(15, 14)
        Me.ckIva.TabIndex = 29
        Me.ckIva.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Iva(17%):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Sub-Total:"
        '
        'txtTotakValor
        '
        Me.txtTotakValor.Location = New System.Drawing.Point(124, 117)
        Me.txtTotakValor.Name = "txtTotakValor"
        Me.txtTotakValor.Size = New System.Drawing.Size(145, 25)
        Me.txtTotakValor.TabIndex = 26
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(124, 86)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(145, 25)
        Me.txtIva.TabIndex = 26
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(124, 55)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(145, 25)
        Me.txtSubTotal.TabIndex = 26
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SistemaVenda.My.Resources.Resources.Sell_25px
        Me.PictureBox5.Location = New System.Drawing.Point(45, 24)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'cmbFormaPagamento
        '
        Me.cmbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFormaPagamento.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbFormaPagamento.FormattingEnabled = True
        Me.cmbFormaPagamento.Items.AddRange(New Object() {"Dinheiro", "Cartao", "Cheque"})
        Me.cmbFormaPagamento.Location = New System.Drawing.Point(76, 24)
        Me.cmbFormaPagamento.Name = "cmbFormaPagamento"
        Me.cmbFormaPagamento.Size = New System.Drawing.Size(193, 25)
        Me.cmbFormaPagamento.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.SistemaVenda.My.Resources.Resources.Checked_Checkbox_2_25px
        Me.Button1.Location = New System.Drawing.Point(145, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 35)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Vender"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 188)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 92)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comentarios:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(23, 550)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(958, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'NuitEmpresaLabel1
        '
        Me.NuitEmpresaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuitEmpresaLabel1.Location = New System.Drawing.Point(267, 119)
        Me.NuitEmpresaLabel1.Name = "NuitEmpresaLabel1"
        Me.NuitEmpresaLabel1.Size = New System.Drawing.Size(263, 23)
        Me.NuitEmpresaLabel1.TabIndex = 23
        Me.NuitEmpresaLabel1.Text = "?"
        '
        'NomeEmpresaLabel1
        '
        Me.NomeEmpresaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeEmpresaLabel1.Location = New System.Drawing.Point(267, 50)
        Me.NomeEmpresaLabel1.Name = "NomeEmpresaLabel1"
        Me.NomeEmpresaLabel1.Size = New System.Drawing.Size(263, 23)
        Me.NomeEmpresaLabel1.TabIndex = 21
        Me.NomeEmpresaLabel1.Text = "?"
        '
        'EmailLabel1
        '
        Me.EmailLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel1.Location = New System.Drawing.Point(267, 73)
        Me.EmailLabel1.Name = "EmailLabel1"
        Me.EmailLabel1.Size = New System.Drawing.Size(263, 23)
        Me.EmailLabel1.TabIndex = 19
        Me.EmailLabel1.Text = "?"
        '
        'ContactoLabel1
        '
        Me.ContactoLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoLabel1.Location = New System.Drawing.Point(267, 96)
        Me.ContactoLabel1.Name = "ContactoLabel1"
        Me.ContactoLabel1.Size = New System.Drawing.Size(263, 23)
        Me.ContactoLabel1.TabIndex = 17
        Me.ContactoLabel1.Text = "?"
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(32, 50)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(118, 88)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(634, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 100)
        Me.Panel1.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "?"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 23)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "?"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(98, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 23)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "?"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(98, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(220, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "?"
        '
        'frmVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 598)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(NuitEmpresaLabel)
        Me.Controls.Add(Me.NuitEmpresaLabel1)
        Me.Controls.Add(Me.NomeEmpresaLabel1)
        Me.Controls.Add(NomeEmpresaLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.EmailLabel1)
        Me.Controls.Add(Me.ContactoLabel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmVenda"
        Me.Padding = New System.Windows.Forms.Padding(23, 78, 23, 26)
        Me.Resizable = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtRefer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDesignacao As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desginacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prec_Unt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idProdut As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFormaPagamento As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ckIva As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotakValor As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NuitEmpresaLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomeEmpresaLabel1 As System.Windows.Forms.Label
    Friend WithEvents EmailLabel1 As System.Windows.Forms.Label
    Friend WithEvents ContactoLabel1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
End Class
