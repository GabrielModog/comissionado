using System.Text.Json;
using System.Text.Json.Serialization;
using Comissionado.Core.Models;

namespace Comissionado.Core;

public static class JsonDataLoader
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        AllowTrailingCommas = true,
        ReadCommentHandling = JsonCommentHandling.Skip
    };

    public static List<Venda> CarregarVendas(string caminho)
    {
        using var stream = File.OpenRead(caminho);
        var dados = JsonSerializer.Deserialize<VendasJson>(stream, Options);
        return dados?.Vendas ?? new List<Venda>();
    }

    public static List<EstoqueProduto> CarregarEstoque(string caminho)
    {
        using var stream = File.OpenRead(caminho);
        var dados = JsonSerializer.Deserialize<EstoqueJson>(stream, Options);
        return dados?.Estoque ?? new List<EstoqueProduto>();
    }

    private sealed class VendasJson
    {
        [JsonPropertyName("vendas")]
        public List<Venda> Vendas { get; set; } = new();
    }

    private sealed class EstoqueJson
    {
        [JsonPropertyName("estoque")]
        public List<EstoqueProduto> Estoque { get; set; } = new();
    }
}
