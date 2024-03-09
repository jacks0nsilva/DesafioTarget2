
# Desafio Target Sistemas

Projeto Console em C# que será utilizado como forma de avaliação no processo seletivo na Target Sistemas na vaga de Estágio em Desenvolvimento.

## Como executar o projeto?

**1. Clone o repositório** 

```
git clone https://github.com/jacks0nsilva/DesafioTarget2.git
```

**2. Navegue até o diretório do projeto**

```
cd DesafioTarget2
```

**3.Compile o código usando o compilador C#**
```
dotnet build
```

**4. Execute o programa**

```
dotnet run
```

**5. Siga as instruções no console**

```
• Digite um número para verificar se ele faz parte da sequência de Fibonacci

• Responda 'S' se deseja executar novamente ou 'N' para sair do programa
```


## Explicando o método VerificarSequencia

**FUNCIONAMENTO**

_O método começa verificando se o número fornecido for zero, ele é considerado parte da sequência de Fibonacci e o método retorna true._

_Em seguida, o método utiliza um loop while para iterar pela sequência de Fibonacci, calculando os próximos números na sequência até encontrar um número igual ao fornecido. Se o número fornecido for encontrado na sequência, o método retorna true. Se o número fornecido for maior do que os números na sequência de Fibonacci, o método retorna false._


***Exemplo***

```
int numero = 8;
bool pertence = VerificarSequenciaFibonacci.VerificarSequencia(numero);

if (pertence)
{
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
}


```
_Neste exemplo, o número 8 é verificado para determinar se pertence à sequência de Fibonacci. O resultado será "8 pertence à sequência de Fibonacci.", já que 8 é um número na sequência de Fibonacci._
