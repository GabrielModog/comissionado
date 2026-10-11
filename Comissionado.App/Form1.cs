using System.Globalization;
using Comissionado.Core;
using Comissionado.Core.Models;

namespace Comissionado.App;

public partial class Form1 : Form
{
    private readonly string _vendasPath = Path.Combine(AppContext.BaseDirectory, "vendas.json");
    private readonly string _estoquePath = Path.Combine(AppContext.BaseDirectory, "estoque.json");
    private readonly CultureInfo _ptBr = new("pt-BR");

    private List<EstoqueProduto> _produtos = new();

    public Form1()
    {
        InitializeComponent();
        ConfigurarGrids();
        btnCalcular.Click += btnCalcular_Click;
        btnLancar.Click += btnLancar_Click;
        Load += Form1_Load;
    }

    private void ConfigurarGrids()
    {
        colValorProduzido.DefaultCellStyle.FormatProvider = _ptBr;
        colValorProduzido.DefaultCellStyle.Format = "C2";
        colComissao.DefaultCellStyle.FormatProvider = _ptBr;
        colComissao.DefaultCellStyle.Format = "C2";
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        cboTipo.DataSource = Enum.GetValues<TipoMovimentacao>();

        try
        {
            EstoqueRepositorio.Inicializar(_estoquePath);
            CarregarEstoque();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Falha ao inicializar o banco de estoque: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CarregarEstoque()
    {
        _produtos = EstoqueRepositorio.ObterProdutos();
        cboProduto.DataSource = null;
        cboProduto.DataSource = _produtos;
        cboProduto.DisplayMember = nameof(EstoqueProduto.DescricaoProduto);
        AtualizarGridEstoque();
    }

    private void AtualizarGridEstoque()
    {
        gridEstoque.DataSource = null;
        gridEstoque.DataSource = _produtos;
    }

    private void btnCalcular_Click(object? sender, EventArgs e)
    {
        try
        {
            var vendas = JsonDataLoader.CarregarVendas(_vendasPath);
            var resultados = CalculoComissao.CalcularComissao(vendas);
            gridComissoes.DataSource = null;
            gridComissoes.DataSource = resultados;
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show($"Arquivo não encontrado: {_vendasPath}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Falha ao carregar vendas: {ex.Message}", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnLancar_Click(object? sender, EventArgs e)
    {
        if (cboProduto.SelectedItem is not EstoqueProduto produto)
        {
            MessageBox.Show("Selecione um produto.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var tipo = (TipoMovimentacao)cboTipo.SelectedItem!;
        var quantidade = (int)numQuantidade.Value;
        var descricao = txtDescricao.Text;

        try
        {
            var (movimentacao, quantidadeFinal) =
                EstoqueRepositorio.Movimentar(produto.CodigoProduto, tipo, quantidade, descricao);
            lblResultado.Text = $"ID: {movimentacao.Id}{Environment.NewLine}" +
                                $"Quantidade final: {quantidadeFinal}";
            txtDescricao.Clear();
            numQuantidade.Value = 1;
            CarregarEstoque();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Validação",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(ex.Message, "Estoque insuficiente",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
