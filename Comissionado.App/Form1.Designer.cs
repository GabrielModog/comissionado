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

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tabControl = new TabControl();
        tabComissao = new TabPage();
        btnCalcular = new Button();
        gridComissoes = new DataGridView();
        colVendedor = new DataGridViewTextBoxColumn();
        colValorProduzido = new DataGridViewTextBoxColumn();
        colComissao = new DataGridViewTextBoxColumn();
        tabEstoque = new TabPage();
        gridEstoque = new DataGridView();
        colCodigo = new DataGridViewTextBoxColumn();
        colDescricao = new DataGridViewTextBoxColumn();
        colEstoqueAtual = new DataGridViewTextBoxColumn();
        lblProduto = new Label();
        cboProduto = new ComboBox();
        lblTipo = new Label();
        cboTipo = new ComboBox();
        lblQuantidade = new Label();
        numQuantidade = new NumericUpDown();
        lblDescricao = new Label();
        txtDescricao = new TextBox();
        btnLancar = new Button();
        lblResultado = new Label();
        tabJuros = new TabPage();
        lblDataConsulta = new Label();
        dtpDataConsulta = new DateTimePicker();
        lblDataVencimento = new Label();
        dtpDataVencimento = new DateTimePicker();
        lblValor = new Label();
        numValor = new NumericUpDown();
        btnCalcularJuros = new Button();
        lblResultadoJuros = new Label();
        tabControl.SuspendLayout();
        tabComissao.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridComissoes).BeginInit();
        tabEstoque.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridEstoque).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
        tabJuros.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabComissao);
        tabControl.Controls.Add(tabEstoque);
        tabControl.Controls.Add(tabJuros);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(900, 560);
        tabControl.TabIndex = 0;
        // 
        // tabComissao
        // 
        tabComissao.Controls.Add(gridComissoes);
        tabComissao.Controls.Add(btnCalcular);
        tabComissao.Location = new Point(4, 24);
        tabComissao.Name = "tabComissao";
        tabComissao.Padding = new Padding(3);
        tabComissao.Size = new Size(892, 532);
        tabComissao.TabIndex = 0;
        tabComissao.Text = "Comissão";
        tabComissao.UseVisualStyleBackColor = true;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new Point(14, 14);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(170, 32);
        btnCalcular.TabIndex = 0;
        btnCalcular.Text = "Calcular comissões";
        btnCalcular.UseVisualStyleBackColor = true;
        // 
        // gridComissoes
        // 
        gridComissoes.AllowUserToAddRows = false;
        gridComissoes.AllowUserToDeleteRows = false;
        gridComissoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridComissoes.AutoGenerateColumns = false;
        gridComissoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridComissoes.Columns.AddRange(new DataGridViewColumn[] { colVendedor, colValorProduzido, colComissao });
        gridComissoes.Location = new Point(14, 58);
        gridComissoes.Name = "gridComissoes";
        gridComissoes.ReadOnly = true;
        gridComissoes.RowHeadersVisible = false;
        gridComissoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridComissoes.Size = new Size(862, 456);
        gridComissoes.TabIndex = 1;
        // 
        // colVendedor
        // 
        colVendedor.DataPropertyName = "Vendedor";
        colVendedor.HeaderText = "Vendedor";
        colVendedor.Name = "colVendedor";
        colVendedor.Width = 300;
        // 
        // colValorProduzido
        // 
        colValorProduzido.DataPropertyName = "ValorProduzido";
        colValorProduzido.HeaderText = "Valor Produzido";
        colValorProduzido.Name = "colValorProduzido";
        colValorProduzido.Width = 200;
        // 
        // colComissao
        // 
        colComissao.DataPropertyName = "ValorComissao";
        colComissao.HeaderText = "Comissão";
        colComissao.Name = "colComissao";
        colComissao.Width = 200;
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
        tabEstoque.Location = new Point(4, 24);
        tabEstoque.Name = "tabEstoque";
        tabEstoque.Padding = new Padding(3);
        tabEstoque.Size = new Size(892, 532);
        tabEstoque.TabIndex = 1;
        tabEstoque.Text = "Movimentação de estoque";
        tabEstoque.UseVisualStyleBackColor = true;
        // 
        // gridEstoque
        // 
        gridEstoque.AllowUserToAddRows = false;
        gridEstoque.AllowUserToDeleteRows = false;
        gridEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        gridEstoque.AutoGenerateColumns = false;
        gridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridEstoque.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescricao, colEstoqueAtual });
        gridEstoque.Location = new Point(14, 14);
        gridEstoque.Name = "gridEstoque";
        gridEstoque.ReadOnly = true;
        gridEstoque.RowHeadersVisible = false;
        gridEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        gridEstoque.Size = new Size(500, 480);
        gridEstoque.TabIndex = 0;
        // 
        // colCodigo
        // 
        colCodigo.DataPropertyName = "CodigoProduto";
        colCodigo.HeaderText = "Código";
        colCodigo.Name = "colCodigo";
        colCodigo.Width = 90;
        // 
        // colDescricao
        // 
        colDescricao.DataPropertyName = "DescricaoProduto";
        colDescricao.HeaderText = "Descrição";
        colDescricao.Name = "colDescricao";
        colDescricao.Width = 280;
        // 
        // colEstoqueAtual
        // 
        colEstoqueAtual.DataPropertyName = "Estoque";
        colEstoqueAtual.HeaderText = "Estoque atual";
        colEstoqueAtual.Name = "colEstoqueAtual";
        colEstoqueAtual.Width = 120;
        // 
        // lblProduto
        // 
        lblProduto.AutoSize = true;
        lblProduto.Location = new Point(534, 18);
        lblProduto.Name = "lblProduto";
        lblProduto.Size = new Size(50, 15);
        lblProduto.Text = "Produto";
        // 
        // cboProduto
        // 
        cboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
        cboProduto.Location = new Point(534, 38);
        cboProduto.Name = "cboProduto";
        cboProduto.Size = new Size(340, 23);
        cboProduto.TabIndex = 1;
        // 
        // lblTipo
        // 
        lblTipo.AutoSize = true;
        lblTipo.Location = new Point(534, 74);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(30, 15);
        lblTipo.Text = "Tipo";
        // 
        // cboTipo
        // 
        cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTipo.Location = new Point(534, 94);
        cboTipo.Name = "cboTipo";
        cboTipo.Size = new Size(340, 23);
        cboTipo.TabIndex = 2;
        // 
        // lblQuantidade
        // 
        lblQuantidade.AutoSize = true;
        lblQuantidade.Location = new Point(534, 130);
        lblQuantidade.Name = "lblQuantidade";
        lblQuantidade.Size = new Size(69, 15);
        lblQuantidade.Text = "Quantidade";
        // 
        // numQuantidade
        // 
        numQuantidade.Location = new Point(534, 150);
        numQuantidade.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numQuantidade.Name = "numQuantidade";
        numQuantidade.Size = new Size(120, 23);
        numQuantidade.TabIndex = 3;
        numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblDescricao
        // 
        lblDescricao.AutoSize = true;
        lblDescricao.Location = new Point(534, 186);
        lblDescricao.Name = "lblDescricao";
        lblDescricao.Size = new Size(120, 15);
        lblDescricao.Text = "Descrição da movimentação";
        // 
        // txtDescricao
        // 
        txtDescricao.Location = new Point(534, 206);
        txtDescricao.Multiline = true;
        txtDescricao.Name = "txtDescricao";
        txtDescricao.Size = new Size(340, 46);
        txtDescricao.TabIndex = 4;
        // 
        // btnLancar
        // 
        btnLancar.Location = new Point(534, 264);
        btnLancar.Name = "btnLancar";
        btnLancar.Size = new Size(120, 34);
        btnLancar.TabIndex = 5;
        btnLancar.Text = "Lançar";
        btnLancar.UseVisualStyleBackColor = true;
        // 
        // lblResultado
        // 
        lblResultado.BorderStyle = BorderStyle.FixedSingle;
        lblResultado.Location = new Point(534, 312);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new Size(340, 60);
        lblResultado.TabIndex = 6;
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
        tabJuros.Location = new Point(4, 24);
        tabJuros.Name = "tabJuros";
        tabJuros.Padding = new Padding(3);
        tabJuros.Size = new Size(892, 532);
        tabJuros.TabIndex = 2;
        tabJuros.Text = "Juros e Multa";
        tabJuros.UseVisualStyleBackColor = true;
        // 
        // lblDataConsulta
        // 
        lblDataConsulta.AutoSize = true;
        lblDataConsulta.Location = new Point(30, 30);
        lblDataConsulta.Name = "lblDataConsulta";
        lblDataConsulta.Size = new Size(96, 15);
        lblDataConsulta.Text = "Data de consulta";
        // 
        // dtpDataConsulta
        // 
        dtpDataConsulta.Format = DateTimePickerFormat.Short;
        dtpDataConsulta.Location = new Point(30, 50);
        dtpDataConsulta.Name = "dtpDataConsulta";
        dtpDataConsulta.Size = new Size(200, 23);
        dtpDataConsulta.TabIndex = 0;
        // 
        // lblDataVencimento
        // 
        lblDataVencimento.AutoSize = true;
        lblDataVencimento.Location = new Point(30, 90);
        lblDataVencimento.Name = "lblDataVencimento";
        lblDataVencimento.Size = new Size(109, 15);
        lblDataVencimento.Text = "Data de vencimento";
        // 
        // dtpDataVencimento
        // 
        dtpDataVencimento.Format = DateTimePickerFormat.Short;
        dtpDataVencimento.Location = new Point(30, 110);
        dtpDataVencimento.Name = "dtpDataVencimento";
        dtpDataVencimento.Size = new Size(200, 23);
        dtpDataVencimento.TabIndex = 1;
        // 
        // lblValor
        // 
        lblValor.AutoSize = true;
        lblValor.Location = new Point(30, 150);
        lblValor.Name = "lblValor";
        lblValor.Size = new Size(33, 15);
        lblValor.Text = "Valor";
        // 
        // numValor
        // 
        numValor.DecimalPlaces = 2;
        numValor.Location = new Point(30, 170);
        numValor.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numValor.Name = "numValor";
        numValor.Size = new Size(200, 23);
        numValor.TabIndex = 2;
        numValor.ThousandsSeparator = true;
        // 
        // btnCalcularJuros
        // 
        btnCalcularJuros.Location = new Point(30, 214);
        btnCalcularJuros.Name = "btnCalcularJuros";
        btnCalcularJuros.Size = new Size(160, 34);
        btnCalcularJuros.TabIndex = 3;
        btnCalcularJuros.Text = "Calcular juros";
        btnCalcularJuros.UseVisualStyleBackColor = true;
        // 
        // lblResultadoJuros
        // 
        lblResultadoJuros.BorderStyle = BorderStyle.FixedSingle;
        lblResultadoJuros.Location = new Point(30, 262);
        lblResultadoJuros.Name = "lblResultadoJuros";
        lblResultadoJuros.Size = new Size(420, 60);
        lblResultadoJuros.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 560);
        Controls.Add(tabControl);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Comissionado";
        tabControl.ResumeLayout(false);
        tabComissao.ResumeLayout(false);
        tabComissao.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridComissoes).EndInit();
        tabEstoque.ResumeLayout(false);
        tabEstoque.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)gridEstoque).EndInit();
        ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
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
    private Button btnLancar;
    private Label lblResultado;
    private TabPage tabJuros;
    private Label lblDataConsulta;
    private DateTimePicker dtpDataConsulta;
    private Label lblDataVencimento;
    private DateTimePicker dtpDataVencimento;
    private Label lblValor;
    private NumericUpDown numValor;
    private Button btnCalcularJuros;
    private Label lblResultadoJuros;
}
