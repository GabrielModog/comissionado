using Comissionado.Core;

namespace Comissionado.Tests;

public class AplicarMultaTest
{
    [Fact]
    public static void AplicarJurosDeMultaDe2DiasTest()
    {
        decimal esperado = 2101.25m;
        decimal valor = 2000m;
        
        DateTime dataAtual = new DateTime(2026, 10, 12);
        DateTime dataVencimento = new DateTime(2026, 10, 10);

        var resultado = AplicarJurosMulta.Executar(valor, dataVencimento, dataAtual);
        
        Assert.Equal(esperado, resultado);
    }
}