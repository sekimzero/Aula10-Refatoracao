namespace ConversaoRealDolar;

internal class Program
{
    private const double _valorMinimo = 100;
    private const double _valorMaximo = 2500;
    private const double _cotacaoDoDolarHoje = 4.97;

    private static void Main()
    {
        // Cotação do dólar no dia 3 de maio de 2022.
        double valorConvertidoDaCompra;
        double valorCompraUsuario;

        Console.WriteLine("Digite o valor em Real da sua compra: ");
        valorCompraUsuario = Convert.ToDouble(Console.ReadLine());

        var valorConvertido = ConverterRealParaDolar(valorCompraUsuario);


        if (valorConvertido < _valorMinimo)
        {
            Console.WriteLine("A compra mínima permitida é de USD$ " + _valorMinimo + " e o valor convertido atual de sua compra é de USD$ " + valorConvertido);
        }
        else if (valorConvertido > _valorMaximo)
        {
            Console.WriteLine("A compra máxima permitida é de USD$ " + _valorMaximo + " e o valor convertido atual de sua compra é de USD$ " + valorConvertido);
        }
        else
        {
            Console.WriteLine("Você pode comprar USD$ " + valorConvertido);
        }


    }

     private static double ConverterRealParaDolar(double valorDaCompraEmReais)
    {    
       var valorConvertidoDaCompra = valorDaCompraEmReais / _cotacaoDoDolarHoje;
        return valorConvertidoDaCompra;
    }
}