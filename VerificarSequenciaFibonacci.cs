namespace DesafioTarget2;

public static class VerificarSequenciaFibonacci
{
    // Verifica se um número pertence à sequência de Fibonacci
    public static bool VerificarSequencia(int numero)
    {
        
        int anterior = 0;
        int atual = 1;

        // Caso especial para o zero
        if (numero == 0)
        {
            return true;
        }

        while (atual <= numero)
        {
            if (atual == numero)
            {
                return true;
            }

            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        return false;
    }
}
