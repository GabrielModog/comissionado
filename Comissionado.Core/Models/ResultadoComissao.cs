using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comissionado.Core.Models;

public class ResultadoComissao
{
    public string Vendedor { get; set; } = string.Empty;
    public decimal ValorProduzido { get; set;  }
    public decimal ValorComissao { get; set; }
}
