namespace CharacterCounter;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra ou frase: ");
        string input = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Nenhum caractere foi digitado.");
            return;
        }

        Console.WriteLine($"A palavra ou frase '{input}' possui {input.Length} caracteres.");
        Console.WriteLine($"A palavra ou frase '{input}', ignorando espaçamentos, possui {input.Replace(" ", "").Length} caracteres.");
    }
}