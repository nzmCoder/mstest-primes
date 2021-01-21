using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;
using System.Diagnostics;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        // Conventional single value test methods.
        [TestMethod]
        public void IsPrime_1()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should NOT be prime");
        }

        [TestMethod]
        public void IsPrime_Neg()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(-10);

            Assert.IsFalse(result, "Negative should NOT be prime");
        }

        // Unconventional multiple value test method.
        [TestMethod]
        public void IsPrime_0ToN()
        {
            // Call helper method.
            IsPrime_N(0, false);
            IsPrime_N(1, false);
            IsPrime_N(2, true);
            IsPrime_N(3, true);
            IsPrime_N(4, false);
            IsPrime_N(5, true);
            IsPrime_N(6, false);
            IsPrime_N(7, true);
            IsPrime_N(8, false);
            IsPrime_N(9, false);
            IsPrime_N(10, false);
            IsPrime_N(11, true);
            IsPrime_N(12, false);
            IsPrime_N(13, true);
            IsPrime_N(14, false);
            IsPrime_N(15, false);
            IsPrime_N(16, false);
            IsPrime_N(17, true);
            IsPrime_N(18, false);
            IsPrime_N(19, true);
            IsPrime_N(20, false);
            IsPrime_N(21, false);
            IsPrime_N(22, false);
            IsPrime_N(23, true);
        }

        // Helper method.
        public void IsPrime_N(int n, bool isPrime)
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(n);

            // Show what we did successfully before failure.
            // This output will be in the "additional output" of the test.
            Debug.WriteLine($"Testing {n}");

            // Decide the truth of the matter.
            if (isPrime)
            {
                Assert.IsTrue(result, $"{n} should be prime");
            }
            else
            {
                Assert.IsFalse(result, $"{n} should be prime");
            }
        }
    }
}