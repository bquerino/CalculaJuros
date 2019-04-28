using CalculaJuros.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculaJuros.Test
{
    [TestClass]
    public class CalculaJurosTest
    {
        [TestMethod]
        public void TestCalculaJuros()
        {
            CalculaJurosController calculaJurosController = new CalculaJurosController();
            var response = calculaJurosController.Get(100, 5);

            Assert.AreEqual("105,10", response.Value);
        }

        [TestMethod]
        public void TestShowMeTheCode()
        {
            ShowMeTheCodeController showMeTheCodeController = new ShowMeTheCodeController();
            var response = showMeTheCodeController.Get();

            Assert.AreEqual("https://github.com/cdcunha/CalculaJuros", response.Value);
        }
    }
}
