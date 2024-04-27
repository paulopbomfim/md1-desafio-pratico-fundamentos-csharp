namespace ConcatName;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, digite seu primeiro nome:");
        var name = Console.ReadLine();
        Console.WriteLine("Por favor, digite seu sobrenome:");
        var surname = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
        {
            Console.WriteLine("Nome ou sobrenome não informado.");
            return;
        }

        var fullName = new Name().Concat(name, surname);
        Console.WriteLine($"Seu nome completo é: {fullName}");
    }
}