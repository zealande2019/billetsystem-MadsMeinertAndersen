using System;
using BilletLibary2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Øresund;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ØresundBilPriserMedBrobizz()
        {
            //Arrange
            Bil testBil = new Bil("testBil", new DateTime(2019, 2, 23));

            //Act
            testBil.Brobizz = true;
            ØresundPriser priser = new ØresundPriser();
            double pris = priser.Priser(testBil);

            //Assert
            Assert.AreEqual(161, pris);
        }
        [TestMethod]
        public void ØresundBilPriserUdenBrobizz()
        {
            //Arrange
            Bil testBil = new Bil("testBil", new DateTime(2019, 2, 23));

            //Act
            ØresundPriser priser = new ØresundPriser();
            double pris = priser.Priser(testBil);

            //Assert
            Assert.AreEqual(410, pris);
        }


        [TestMethod]
        public void ØresundMCPriserUdenBrobizz()
        {
            //Arrange
            MC testMC = new MC("testBil", new DateTime(2019, 2, 23));

            //Act
            ØresundPriser priser = new ØresundPriser();
            double pris = priser.Priser(testMC);

            //Assert
            Assert.AreEqual(210, pris);
        }
        [TestMethod]
        public void ØresundMCPriserMedBrobizz()
        {
            //Arrange
            MC testMC = new MC("testBil", new DateTime(2019, 2, 23));

            //Act
            testMC.Brobizz = true;
            ØresundPriser priser = new ØresundPriser();
            double pris = priser.Priser(testMC);

            //Assert
            Assert.AreEqual(73, pris);
        }
    }
}
