using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
                 //La clase PrimeService_IsPrimeShould contiene pruebas unitarias. 
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;
                //El m�todo SetUp es el c�digo de inicializaci�n. 
    public void SetUp()
        {
            _primeService = new PrimeService();
        }
                //El m�todo IsPrime_InputIs1_ReturnFalse() es un m�todo de prueba. 
    public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }

    }
}