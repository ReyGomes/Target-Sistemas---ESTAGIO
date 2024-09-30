//2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

Console.WriteLine("Verificador de Strings");
Console.Write("Digite algo para velidar a ocorrencia de letra a:");
string texto = Console.ReadLine();

int aux = letras(texto);
if (aux != 0)
{
    Console.WriteLine($"\n\nForam encontradas {aux} vezes a letra na frase ");
}
else
{
    Console.WriteLine("\n\nNão foi encontrado na frase digitada a ocorrencia da letra a ...");

}
int letras(string texto)
{
    int contador = 0;

    foreach (char c in texto)
    {
        if (c == 'a') contador++;
    }
    return contador;
}