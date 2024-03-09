using DesafioTarget2;

bool executarNovamente = true;

while (executarNovamente)
{

    Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    bool pertence = VerificarSequenciaFibonacci.VerificarSequencia(numero);

    if (pertence)
    {
        Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
    }

    Console.Write("\nDeseja verificar outro número? (S/N)   ");

    char resposta = char.ToUpper(Console.ReadKey().KeyChar);
    Console.WriteLine();
    executarNovamente = (resposta == 'S');
}