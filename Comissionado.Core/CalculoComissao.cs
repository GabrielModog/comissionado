using Comissionado.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comissionado.Core;

public static class CalculoComissao
{
    public static List<ResultadoComissao> Executar(List<Venda> vendas)
    {
        var porVendedor = vendas
            .Select(x => new ResultadoComissao
            {
                Vendedor = x.Vendedor,
                ValorProduzido = x.Valor,
                ValorComissao = ObterComissao(x.Valor)
            })
            .ToList();

        return porVendedor;
    }

    private static decimal ObterComissao(decimal valor)
    {
        return valor switch
        {
            < 100m => 0m,
            < 500m => valor * 1.01m,
            >= 500m => valor * 1.05m,
        };
    }
}
