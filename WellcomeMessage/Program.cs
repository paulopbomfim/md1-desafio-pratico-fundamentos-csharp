namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para começar digite seu nome:");
            var name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Nome não informado.");
                return;
            }

            var message = Welcome.GetMessage(name);
            Console.WriteLine(message);

        }
    }
}
