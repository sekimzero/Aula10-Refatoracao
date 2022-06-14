namespace ConversaoRealDolar;

internal class Program
{
    private const double _valorMinimo = 100;
    private const double _valorMaximo = 2500;
    private const double _cotacaoDoDolarHoje = 4.97;

    private static void Main()
    {
        // Cotação do dólar no dia 3 de maio de 2022.
        Console.WriteLine("Digite o valor em Real da sua compra: ");
        var valorCompraUsuario = Convert.ToDouble(Console.ReadLine());
        var conversao = ConverterRealParaDolar(valorCompraUsuario);

        Console.WriteLine(Verificacao(conversao));
    }

    private static double ConverterRealParaDolar(double valorDaCompraEmReais)
    {    
        var valorConvertidoDaCompra = valorDaCompraEmReais / _cotacaoDoDolarHoje;
        return valorConvertidoDaCompra;
    }

    private static string Verificacao(double valorConvertido)
    {
        if (valorConvertido < _valorMinimo)
        {
            return "A compra mínima permitida é de USD$ " + _valorMinimo + " e o valor convertido atual de sua compra é de USD$ " + valorConvertido;
        }
        else if (valorConvertido > _valorMaximo)
        {
            return "A compra máxima permitida é de USD$ " + _valorMaximo + " e o valor convertido atual de sua compra é de USD$ " + valorConvertido;
        }
        else
        {
            return "Você pode comprar USD$ " + valorConvertido;
        }
    }
}