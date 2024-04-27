namespace TypeDoubleCalculator;

public class Calculator
{
    public static double Sum(double? firstNumber, double? secondNumber)
    {
        return firstNumber.GetValueOrDefault() + secondNumber.GetValueOrDefault();
    }

    public static double Subtract(double? firstNumber, double? secondNumber)
    {
        return firstNumber.GetValueOrDefault() - secondNumber.GetValueOrDefault();
    }

    public static double Multiply(double? firstNumber, double? secondNumber)
    {
        return firstNumber.GetValueOrDefault() * secondNumber.GetValueOrDefault();
    }

    public static double Divide(double? firstNumber, double? secondNumber)
    {
        return firstNumber.GetValueOrDefault() / secondNumber.GetValueOrDefault();
    }

    public static double Average(double? firstNumber, double? secondNumber)
    {
        return (firstNumber.GetValueOrDefault() + secondNumber.GetValueOrDefault()) / 2;
    }
}
