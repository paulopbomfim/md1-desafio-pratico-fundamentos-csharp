using System.Text.RegularExpressions;

namespace BrazilianVehicleRegistrationPlateValidator
{
    public class RegistrationPlate
    {
        private string _registrationPlate { get; set; } = string.Empty;

        public RegistrationPlate(string registrationPlate)
        {
            _registrationPlate = registrationPlate;
        }

        public bool IsValid()
        {
            var isPlateLengthValid = IsPlateLengthValid();
            var isPlateFormatValid = IsPlateFormatValid();

            return isPlateLengthValid && isPlateFormatValid;
        }

        private bool IsPlateLengthValid()
        {
            return _registrationPlate.Length == 7;
        }

        private bool IsPlateFormatValid()
        {
            return Regex.IsMatch(_registrationPlate, @"^[aA-zZ]{3}\d{4}$");
        }
    }
}
