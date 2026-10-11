using Comissionado.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Comissionado.Core;

public static class EstoqueRepositorio
{
    public static void Inicializar(string caminhoEstoqueJson)
    {
        using var db = new AppDbContext();
        db.Database.Migrate();

        if (!db.Produtos.Any())
        {
            db.Produtos.AddRange(JsonDataLoader.CarregarEstoque(caminhoEstoqueJson));
            db.SaveChanges();
        }
    }

    public static List<EstoqueProduto> ObterProdutos()
    {
        using var db = new AppDbContext();
        return db.Produtos.AsNoTracking().OrderBy(p => p.CodigoProduto).ToList();
    }

    public static (Movimentacao Movimentacao, int QuantidadeFinal) Movimentar(
        int codigoProduto,
        TipoMovimentacao tipo,
        int quantidade,
        string descricao)
    {
        using var db = new AppDbContext();
        var produto = db.Produtos.FirstOrDefault(p => p.CodigoProduto == codigoProduto)
            ?? throw new ArgumentException("Produto não encontrado.", nameof(codigoProduto));

        var movimentacao = MovimentarProduto.Movimentar(produto, tipo, quantidade, descricao);

        db.Movimentacoes.Add(movimentacao);
        db.SaveChanges();

        return (movimentacao, produto.Estoque);
    }
}