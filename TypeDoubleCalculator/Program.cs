namespace TypeDoubleCalculator;

class Program
{
   public static void Main(string[] args)
    {
       Console.WriteLine("Digite o primeiro número:");
       double? firstNumber = double.Parse(Console.ReadLine()!);

       Console.WriteLine("Digite o segundo número:");
       double? secondNumber = double.Parse(Console.ReadLine()!);

       var resultSum = Calculator.Sum(firstNumber, secondNumber);
       Console.WriteLine($"O resultado da soma é: {resultSum}");

       var resultSubt = Calculator.Subtract(firstNumber, secondNumber);
       Console.WriteLine($"O resultado da subtração é: {resultSubt}");

       var resultMult = Calculator.Multiply(firstNumber, secondNumber);
       Console.WriteLine($"O resultado da multiplicação é: {resultMult}");

       var resultDiv = Calculator.Divide(firstNumber, secondNumber);
       Console.WriteLine($"O resultado da divisão é: {resultDiv}");

       var resultAve = Calculator.Average(firstNumber, secondNumber);
       Console.WriteLine($"O resultado da média é: {resultAve}");
    }
}