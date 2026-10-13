namespace Comissionado.App;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabControl = new System.Windows.Forms.TabControl();
        tabComissao = new System.Windows.Forms.TabPage();
        gridComissoes = new System.Windows.Forms.DataGridView();
        colVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colValorProduzido = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colComissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btnCalcular = new System.Windows.Forms.Button();
        tabEstoque = new System.Windows.Forms.TabPage();
        lblResultado = new System.Windows.Forms.Label();
        btnLancar = new System.Windows.Forms.Button();
        txtDescricao = new System.Windows.Forms.TextBox();
        lblDescricao = new System.Windows.Forms.Label();
        numQuantidade = new System.Windows.Forms.NumericUpDown();
        lblQuantidade = new System.Windows.Forms.Label();
        cboTipo = new System.Windows.Forms.ComboBox();
        lblTipo = new System.Windows.Forms.Label();
        cboProduto = new System.Windows.Forms.ComboBox();
        lblProduto = new System.Windows.Forms.Label();
        gridEstoque = new System.Windows.Forms.DataGridView();
        colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colEstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
        tabJuros = new System.Windows.Forms.TabPage();
        lblResultadoJuros = new System.Windows.Forms.Label();
        btnCalcularJuros = new System.Windows.Forms.Button();
        numValor = new System.Windows.Forms.NumericUpDown();
        lblValor = new System.Windows.Forms.Label();
        dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
        lblDataVencimento = new System.Windows.Forms.Label();
        dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
        lblDataConsulta = new System.Windows.Forms.Label();
        tabControl.SuspendLayout();
        tabComissao.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridComissoes).BeginInit();
        tabEstoque.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridEstoque).BeginInit();
        tabJuros.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabComissao);
        tabControl.Controls.Add(tabEstoque);
        tabControl.Controls.Add(tabJuros);
        tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        tabControl.Location = new System.Drawing.Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new System.Drawing.Size(900, 560);
        tabControl.TabIndex = 0;
        // 
        // tabComissao
        // 
        tabComissao.Controls.Add(gridComissoes);
        tabComissao.Controls.Add(btnCalcular);
        tabComissao.Location = new System.Drawing.Point(4, 28);
        tabComissao.Name = "tabComissao";
        tabComissao.Padding = new System.Windows.Forms.Padding(3);
        tabComissao.Size = new System.Drawing.Size(892, 528);
        tabComissao.TabIndex = 0;
        tabComissao.Text = "Comissão";
        tabComissao.UseVisualStyleBackColor = true;
        // 
        // gridComissoes
        // 
        gridComissoes.AllowUserToAddRows = false;
        gridComissoes.AllowUserToDeleteRows = false;
        gridComissoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        gridComissoes.AutoGenerateColumns = false;
        gridComissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridComissoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colVendedor, colValorProduzido, colComissao });
        gridComissoes.Location = new System.Drawing.Point(14, 58);
        gridComissoes.Name = "gridComissoes";
        gridComissoes.ReadOnly = true;
        gridComissoes.RowHeadersVisible = false;
        gridComissoes.RowHeadersWidth = 49;
        gridComissoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridComissoes.Size = new System.Drawing.Size(862, 452);
        gridComissoes.TabIndex = 1;
        // 
        // colVendedor
        // 
        colVendedor.DataPropertyName = "Vendedor";
        colVendedor.HeaderText = "Vendedor";
        colVendedor.MinimumWidth = 6;
        colVendedor.Name = "colVendedor";
        colVendedor.ReadOnly = true;
        colVendedor.Width = 300;
        // 
        // colValorProduzido
        // 
        colValorProduzido.DataPropertyName = "ValorProduzido";
        colValorProduzido.HeaderText = "Valor Produzido";
        colValorProduzido.MinimumWidth = 6;
        colValorProduzido.Name = "colValorProduzido";
        colValorProduzido.ReadOnly = true;
        colValorProduzido.Width = 200;
        // 
        // colComissao
        // 
        colComissao.DataPropertyName = "ValorComissao";
        colComissao.HeaderText = "Comissão";
        colComissao.MinimumWidth = 6;
        colComissao.Name = "colComissao";
        colComissao.ReadOnly = true;
        colComissao.Width = 200;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new System.Drawing.Point(14, 14);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(170, 32);
        btnCalcular.TabIndex = 0;
        btnCalcular.Text = "Calcular comissões";
        btnCalcular.UseVisualStyleBackColor = true;
        // 
        // tabEstoque
        // 
        tabEstoque.Controls.Add(lblResultado);
        tabEstoque.Controls.Add(btnLancar);
        tabEstoque.Controls.Add(txtDescricao);
        tabEstoque.Controls.Add(lblDescricao);
        tabEstoque.Controls.Add(numQuantidade);
        tabEstoque.Controls.Add(lblQuantidade);
        tabEstoque.Controls.Add(cboTipo);
        tabEstoque.Controls.Add(lblTipo);
        tabEstoque.Controls.Add(cboProduto);
        tabEstoque.Controls.Add(lblProduto);
        tabEstoque.Controls.Add(gridEstoque);
        tabEstoque.Location = new System.Drawing.Point(4, 28);
        tabEstoque.Name = "tabEstoque";
        tabEstoque.Padding = new System.Windows.Forms.Padding(3);
        tabEstoque.Size = new System.Drawing.Size(892, 528);
        tabEstoque.TabIndex = 1;
        tabEstoque.Text = "Movimentação de estoque";
        tabEstoque.UseVisualStyleBackColor = true;
        // 
        // lblResultado
        // 
        lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblResultado.Location = new System.Drawing.Point(534, 312);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new System.Drawing.Size(340, 178);
        lblResultado.TabIndex = 6;
        // 
        // btnLancar
        // 
        btnLancar.Location = new System.Drawing.Point(534, 264);
        btnLancar.Name = "btnLancar";
        btnLancar.Size = new System.Drawing.Size(340, 34);
        btnLancar.TabIndex = 5;
        btnLancar.Text = "Lançar";
        btnLancar.UseVisualStyleBackColor = true;
        // 
        // txtDescricao
        // 
        txtDescricao.Location = new System.Drawing.Point(534, 206);
        txtDescricao.Multiline = true;
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new System.Drawing.Size(340, 46);
        txtDescricao.TabIndex = 4;
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Location = new System.Drawing.Point(534, 186);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new System.Drawing.Size(198, 20);
        lblDescricao.TabIndex = 7;
        lblDescricao.Text = "Descrição da movimentação";
        // 
        // numQuantidade
        // 
        numQuantidade.Location = new System.Drawing.Point(534, 150);
        numQuantidade.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numQuantidade.Name = "numQuantidade";
        numQuantidade.Size = new System.Drawing.Size(120, 26);
        numQuantidade.TabIndex = 3;
        numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblQuantidade
        // 
        lblQuantidade.AutoSize = true;
        lblQuantidade.Location = new System.Drawing.Point(534, 130);
        lblQuantidade.Name = "lblQuantidade";
        lblQuantidade.Size = new System.Drawing.Size(87, 20);
        lblQuantidade.TabIndex = 8;
        lblQuantidade.Text = "Quantidade";
        // 
        // cboTipo
        // 
        cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboTipo.Location = new System.Drawing.Point(534, 94);
        cboTipo.Name = "cboTipo";
        cboTipo.Size = new System.Drawing.Size(340, 27);
        cboTipo.TabIndex = 2;
        // 
        // lblTipo
        // 
        lblTipo.AutoSize = true;
        lblTipo.Location = new System.Drawing.Point(534, 74);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new System.Drawing.Size(39, 20);
        lblTipo.TabIndex = 9;
        lblTipo.Text = "Tipo";
        // 
        // cboProduto
        // 
        cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboProduto.Location = new System.Drawing.Point(534, 38);
        cboProduto.Name = "cboProduto";
        cboProduto.Size = new System.Drawing.Size(340, 27);
        cboProduto.TabIndex = 1;
        // 
        // lblProduto
        // 
        lblProduto.AutoSize = true;
        lblProduto.Location = new System.Drawing.Point(534, 18);
        lblProduto.Name = "lblProduto";
        lblProduto.Size = new System.Drawing.Size(62, 20);
        lblProduto.TabIndex = 10;
        lblProduto.Text = "Produto";
        // 
        // gridEstoque
        // 
        gridEstoque.AllowUserToAddRows = false;
        gridEstoque.AllowUserToDeleteRows = false;
        gridEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        gridEstoque.AutoGenerateColumns = false;
        gridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCodigo, colDescricao, colEstoqueAtual });
        gridEstoque.Location = new System.Drawing.Point(14, 14);
        gridEstoque.Name = "gridEstoque";
        gridEstoque.ReadOnly = true;
        gridEstoque.RowHeadersVisible = false;
        gridEstoque.RowHeadersWidth = 49;
        gridEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        gridEstoque.Size = new System.Drawing.Size(500, 476);
        gridEstoque.TabIndex = 0;
        // 
        // colCodigo
        // 
        colCodigo.DataPropertyName = "CodigoProduto";
        colCodigo.HeaderText = "Código";
        colCodigo.MinimumWidth = 6;
        colCodigo.Name = "colCodigo";
        colCodigo.ReadOnly = true;
        colCodigo.Width = 90;
        // 
        // colDescricao
        // 
        colDescricao.DataPropertyName = "DescricaoProduto";
        colDescricao.HeaderText = "Descrição";
        colDescricao.MinimumWidth = 6;
        colDescricao.Name = "colDescricao";
        colDescricao.ReadOnly = true;
        colDescricao.Width = 280;
        // 
        // colEstoqueAtual
        // 
        colEstoqueAtual.DataPropertyName = "Estoque";
        colEstoqueAtual.HeaderText = "Estoque atual";
        colEstoqueAtual.MinimumWidth = 6;
        colEstoqueAtual.Name = "colEstoqueAtual";
        colEstoqueAtual.ReadOnly = true;
        colEstoqueAtual.Width = 120;
        // 
        // tabJuros
        // 
        tabJuros.Controls.Add(lblResultadoJuros);
        tabJuros.Controls.Add(btnCalcularJuros);
        tabJuros.Controls.Add(numValor);
        tabJuros.Controls.Add(lblValor);
        tabJuros.Controls.Add(dtpDataVencimento);
        tabJuros.Controls.Add(lblDataVencimento);
        tabJuros.Controls.Add(dtpDataConsulta);
        tabJuros.Controls.Add(lblDataConsulta);
        tabJuros.Location = new System.Drawing.Point(4, 28);
        tabJuros.Name = "tabJuros";
        tabJuros.Padding = new System.Windows.Forms.Padding(3);
        tabJuros.Size = new System.Drawing.Size(892, 528);
        tabJuros.TabIndex = 2;
        tabJuros.Text = "Juros e Multa";
        tabJuros.UseVisualStyleBackColor = true;
        // 
        // lblResultadoJuros
        // 
        lblResultadoJuros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        lblResultadoJuros.Location = new System.Drawing.Point(30, 152);
        lblResultadoJuros.Name = "lblResultadoJuros";
        lblResultadoJuros.Size = new System.Drawing.Size(420, 60);
        lblResultadoJuros.TabIndex = 4;
        // 
        // btnCalcularJuros
        // 
        btnCalcularJuros.Location = new System.Drawing.Point(250, 104);
        btnCalcularJuros.Name = "btnCalcularJuros";
        btnCalcularJuros.Size = new System.Drawing.Size(200, 34);
        btnCalcularJuros.TabIndex = 3;
        btnCalcularJuros.Text = "Calcular juros";
        btnCalcularJuros.UseVisualStyleBackColor = true;
        btnCalcularJuros.Click += btnCalcularJuros_Click;
        // 
        // numValor
        // 
        numValor.DecimalPlaces = 2;
        numValor.Location = new System.Drawing.Point(30, 110);
        numValor.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numValor.Name = "numValor";
        numValor.Size = new System.Drawing.Size(200, 26);
        numValor.TabIndex = 2;
        numValor.ThousandsSeparator = true;
        // 
        // lblValor
        // 
        lblValor.AutoSize = true;
        lblValor.Location = new System.Drawing.Point(30, 90);
        lblValor.Name = "lblValor";
        lblValor.Size = new System.Drawing.Size(43, 20);
        lblValor.TabIndex = 5;
        lblValor.Text = "Valor";
        // 
        // dtpDataVencimento
        // 
        dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDataVencimento.Location = new System.Drawing.Point(250, 50);
        dtpDataVencimento.Name = "dtpDataVencimento";
        dtpDataVencimento.Size = new System.Drawing.Size(200, 26);
        dtpDataVencimento.TabIndex = 1;
        // 
        // lblDataVencimento
        // 
        lblDataVencimento.AutoSize = true;
        lblDataVencimento.Location = new System.Drawing.Point(250, 30);
        lblDataVencimento.Name = "lblDataVencimento";
        lblDataVencimento.Size = new System.Drawing.Size(143, 20);
        lblDataVencimento.TabIndex = 6;
        lblDataVencimento.Text = "Data de vencimento";
        // 
        // dtpDataConsulta
        // 
        dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpDataConsulta.Location = new System.Drawing.Point(30, 50);
        dtpDataConsulta.Name = "dtpDataConsulta";
        dtpDataConsulta.Size = new System.Drawing.Size(200, 26);
        dtpDataConsulta.TabIndex = 0;
        // 
        // lblDataConsulta
        // 
        lblDataConsulta.AutoSize = true;
        lblDataConsulta.Location = new System.Drawing.Point(30, 30);
        lblDataConsulta.Name = "lblDataConsulta";
        lblDataConsulta.Size = new System.Drawing.Size(121, 20);
        lblDataConsulta.TabIndex = 7;
        lblDataConsulta.Text = "Data de consulta";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(900, 560);
        Controls.Add(tabControl);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Comissionado";
        tabControl.ResumeLayout(false);
        tabComissao.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridComissoes).EndInit();
        tabEstoque.ResumeLayout(false);
        tabEstoque.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridEstoque).EndInit();
        tabJuros.ResumeLayout(false);
        tabJuros.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;
    private TabPage tabComissao;
    private TabPage tabEstoque;
    private Button btnCalcular;
    private DataGridView gridComissoes;
    private DataGridViewTextBoxColumn colVendedor;
    private DataGridViewTextBoxColumn colValorProduzido;
    private DataGridViewTextBoxColumn colComissao;
    private DataGridView gridEstoque;
    private DataGridViewTextBoxColumn colCodigo;
    private DataGridViewTextBoxColumn colDescricao;
    private DataGridViewTextBoxColumn colEstoqueAtual;
    private Label lblProduto;
    private ComboBox cboProduto;
    private Label lblTipo;
    private ComboBox cboTipo;
    private Label lblQuantidade;
    private NumericUpDown numQuantidade;
    private Label lblDescricao;
    private TextBox txtDescricao;
    private System.Windows.Forms.Button btnLancar;
    private System.Windows.Forms.Label lblResultado;
    private TabPage tabJuros;
    private Label lblDataConsulta;
    private DateTimePicker dtpDataConsulta;
    private System.Windows.Forms.Label lblDataVencimento;
    private System.Windows.Forms.DateTimePicker dtpDataVencimento;
    private System.Windows.Forms.Label lblValor;
    private System.Windows.Forms.NumericUpDown numValor;
    private System.Windows.Forms.Button btnCalcularJuros;
    private System.Windows.Forms.Label lblResultadoJuros;
}
