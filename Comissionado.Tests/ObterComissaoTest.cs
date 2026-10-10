using Comissionado.Core;
using Comissionado.Core.Models;

namespace Comissionado.Tests;

public class ObterComissaoTest
{
    private readonly List<Venda> vendas = new List<Venda>
    {
        new() { Vendedor = "João Silva", Valor = 1200.50m },
        new() { Vendedor = "João Silva", Valor = 320.40m },
    };

    [Fact]
    public void ObterComissaoDe5Porcento()
    {
        var comissaoEsperada = new List<ResultadoComissao>
        {
             new() { Vendedor = "João Silva", ValorProduzido = 1200.50m, ValorComissao = 1260.525m  },
        };
        
        var comissaoObtida = CalculoComissao.CalcularComissao(vendas.Take(1).ToList());

        Assert.Equal(comissaoEsperada[0].ValorProduzido, comissaoObtida[0].ValorProduzido);
        Assert.Equal(comissaoEsperada[0].ValorComissao, comissaoObtida[0].ValorComissao);
    }

    [Fact]
    public void ObterComissaoDe1Porcento()
    {
        var comissaoEsperada = new List<ResultadoComissao>
        {
            new() { Vendedor = "João Silva", ValorProduzido = 320.40m, ValorComissao = 323.604m  },
        };
        
        var comissaoObtida = CalculoComissao.CalcularComissao(vendas.Skip(1).ToList());

        Assert.Equal(comissaoEsperada[0].ValorProduzido, comissaoObtida[0].ValorProduzido);
        Assert.Equal(comissaoEsperada[0].ValorComissao, comissaoObtida[0].ValorComissao);
    }
}