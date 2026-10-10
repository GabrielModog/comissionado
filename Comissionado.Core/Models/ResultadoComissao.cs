using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Comissionado.Core.Models;

public class ResultadoComissao
{
    [JsonPropertyName("vendedor")]
    public string Vendedor { get; set; } = string.Empty;
    
    [JsonPropertyName("valorProduzido")]
    public decimal ValorProduzido { get; set;  }
    
    [JsonPropertyName("valorComissao")]
    public decimal ValorComissao { get; set; }
}
