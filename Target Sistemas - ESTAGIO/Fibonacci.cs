namespace Target_Sistemas___ESTAGIO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
            // escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
            Console.WriteLine("Fibonacci!");
            Console.WriteLine("Digite o valor ser verificado na sequencia Fibonacci: ");
            int numero = int.Parse(Console.ReadLine());

            if (Fibonacci(numero))
            {
                Console.WriteLine($"O valor {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O valor {numero} NÃO pertence à sequência de Fibonacci.");
            }

            static bool Fibonacci(int numero)
            {
                if (numero == 0 || numero == 1)
                    return true;

                int a = 0, b = 1, c = a + b;

                while (c <= numero)
                {
                    if (c == numero)
                        return true;

                    a = b;
                    b = c;
                    c = a + b;
                }

                return false;
            }
        }
    }
}