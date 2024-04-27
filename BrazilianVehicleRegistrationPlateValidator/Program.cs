namespace BrazilianVehicleRegistrationPlateValidator;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a placa do carro:");
        var plate = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(plate))
        {
            Console.WriteLine("Placa inválida.");
            return;
        }

        var registrationPlate = new RegistrationPlate(plate);
        var isPlateValid = registrationPlate.IsValid() ? "válido" : "inválido";
        Console.WriteLine($"A placa '{plate}' é um formato {isPlateValid}");
    }
}