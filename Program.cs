namespace Calculadora;

class Program
{
    static void ImprimirCabecalho()
    {
        Console.WriteLine(@"

        █▓▒▒░░░ CALCULADORA ░░░▒▒▓█

        Info:
        Essa é uma calculadora que realiza
        operações matemáticas simples entre
        dois números.

        Como usar:
        Informe o primeiro número, depois o segundo.
        Por fim, será impresso no console o resultado
        das operações básicas.

        Obrigado! :)
        ");
    }

    static bool ContinuarPrograma()
    {
        Console.WriteLine("Deseja continuar o programa? [S/N] \n");
        bool retorno;
        string? verificador = Console.ReadLine();
        switch (verificador)
        {
            case "S":
                retorno = true;
                break;
            case "N":
                retorno = false;
                break;
            default:
                retorno = true;
                Console.WriteLine("Caractere inválido. Digite apenas [S] para continuar, ou [N] para sair");
                ContinuarPrograma();
                break;
        }

        return retorno;
    }

    public static void ImprimirOperações(double x, double y)
    {

        var soma = Somar(x, y);
        var diferenca = Subtrair(x, y);
        var multiplicacao = Multiplicar(x, y);
        var divisao = Dividir(x, y);

        Console.WriteLine(@$"
        Operações realizadas com os números {x} e {y}:
        A) Soma:            {soma}
        B) Subtração:       {diferenca}
        C) Multiplicação:   {multiplicacao}
        D) Divisão:         {divisao}
        
        ");
    }

    public static double Somar(double x, double y)
    {
        return x + y;
    }

    public static double Subtrair(double x, double y)
    {
        return x - y;
    }

    public static double Multiplicar(double x, double y)
    {
        return x * y;
    }

    public static double Dividir(double x, double y)
    {
        return Math.Round(x / y, 2);
    }
    static void Main(string[] args)
    {
        Console.Clear();
        ImprimirCabecalho();
        bool continuar;
        do
        {
            Console.Write("Digite o primeiro Número:");
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out double primeiroNumero))
            { }
            else Console.WriteLine("Entrada inválida! Por favor, insira um número!");

            Console.Write("Digite o segundo número: ");
            input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out double segundoNumero)) { }
            else Console.WriteLine("Entrada inválida! Por favor, insira um número!");

            ImprimirOperações(primeiroNumero, segundoNumero);

            continuar = ContinuarPrograma();
        } while (continuar);

        Console.Clear();
        Console.WriteLine("Obrigado! Até a próxima");
        Console.WriteLine("Pressione qualquer tecla para sair!");
        Console.ReadKey();

    }
}
