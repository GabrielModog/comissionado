using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comissionado.Core.Models;

public class Venda
{
    public string Vendedor { get; set; } = string.Empty;
    public decimal Valor { get; set; }
}
