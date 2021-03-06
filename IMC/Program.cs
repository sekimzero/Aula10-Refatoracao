namespace Imc;

internal class Program
{
    private static void Main()
    {
        var altura = GetInput("Digite sua altura em metros: ");
        var peso = GetInput("Digite seu peso em KG: ");

        // Utilize a mensagem a seguir como base do retorno esperado:
        // Seu diagnóstico é XXXXXX.
        Console.WriteLine($"Seu diagnóstico é {RetornarDiagnosticoDoUsuario(altura, peso)}");
    }

    private static double GetInput(string mensagem)
    {
        Console.Write(mensagem);
        double.TryParse(Console.ReadLine(), out var input);

        return input;
    }

    private static string RetornarDiagnosticoDoUsuario(double altura, double peso)
    {
        var imc = peso / (altura * altura);

        return imc switch
        {
            < 18.5 => "Anêmico",
            >= 18.5 and < 25 => "Normal",
            >= 25 and < 30 => "Sobrepeso",
            >= 30 and < 40 => "Obesidade",
            >= 40 => "Obesidade Mórbida",
            _ => "Valor não faz sentido"
        };
    }
}