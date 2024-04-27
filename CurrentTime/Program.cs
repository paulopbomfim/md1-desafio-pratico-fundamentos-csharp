namespace CurrentTime;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1 - dia da semana, dia do mês, mês, ano, hora, minutos, segundo");
        Console.WriteLine("2 - dia, mês, ano");
        Console.WriteLine("3 - hora(24h)");
        Console.WriteLine("4 - data com Mês por extenso");
        Console.WriteLine("Selecione uma opção:");

        var dateOption = Console.ReadLine();

        switch (dateOption)
        {
            case "1":
                Console.WriteLine(CurrentTime.GetFullTime());
                break;
            case "2":
                Console.WriteLine(CurrentTime.GetDate());
                break;
            case "3":
                Console.WriteLine(CurrentTime.GetHour());
                break;
            case "4":
                Console.WriteLine(CurrentTime.GetWritenDate());
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}