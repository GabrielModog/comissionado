using Comissionado.Core.Models;

namespace Comissionado.Core;

public static class MovimentarProduto
{
    public static Movimentacao Movimentar(
        EstoqueProduto produto,
        TipoMovimentacao tipo,
        int quantidade,
        string descricao)
    {
        if (produto is null)
            throw new ArgumentNullException(nameof(produto));

        if (quantidade < 1)
            throw new ArgumentException("A quantidade deve ser no mínimo 1.", nameof(quantidade));

        if (string.IsNullOrWhiteSpace(descricao))
            throw new ArgumentException("A descrição da movimentação é obrigatória.", nameof(descricao));

        if (tipo == TipoMovimentacao.Saida && quantidade > produto.Estoque)
            throw new InvalidOperationException(
                $"Estoque insuficiente para '{produto.DescricaoProduto}'. " +
                $"Disponível: {produto.Estoque}, solicitado: {quantidade}.");

        produto.Estoque += tipo == TipoMovimentacao.Entrada ? quantidade : -quantidade;

        return new Movimentacao
        {
            Id = Guid.NewGuid(),
            CodigoProduto = produto.CodigoProduto,
            Tipo = tipo,
            Quantidade = quantidade,
            Descricao = descricao
        };
    }
}
