namespace Comissionado.Core;

public static class AplicarJurosMulta
{
    private const decimal _multa = 0.025m;
        
    public static decimal Executar(decimal valor, DateTime dataVencimento, DateTime dataAtual)
    {
        var diferencaDias = (dataAtual.Date - dataVencimento.Date).TotalDays;
        var dias = Math.Max(0, diferencaDias);

        decimal valorNovo = valor;
        decimal juros = 0m;
        
        for (int i = 0; i < dias; i++)
        {
            valorNovo += (valorNovo * _multa);
        }

        return valorNovo;
    }
}