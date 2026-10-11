namespace Comissionado.Core.Models;

public class Movimentacao
{
    public Guid Id { get; set; }
    public int CodigoProduto { get; set; }
    public TipoMovimentacao Tipo { get; set; }
    public int Quantidade { get; set; }
    public string Descricao { get; set; } = string.Empty;
}
