using System;
using BilletLibary2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBilPris()
        {
            //Arrange

            Bil TestBil = new Bil("test", DateTime.Now);

            //Act

            double Pris = TestBil.Pris();

            //Assert
            Assert.AreEqual(240, Pris);
        }

        [TestMethod]
        public void TestBilType()
        {
            //Arrange

            Bil TestBil = new Bil("test", DateTime.Now);

            //Act

            string Type = TestBil.KøretøjsType();

            //Assert
            Assert.AreEqual("Bil", Type);
        }

        [TestMethod]
        public void TestMCPris()
        {
            //Arrange

            MC TestMC = new MC("test", DateTime.Now);

            //Act

            double Pris = TestMC.Pris();

            //Assert
            Assert.AreEqual(125, Pris);
        }

        [TestMethod]
        public void TestMCType()
        {
            //Arrange

            MC TestMC = new MC("test", DateTime.Now);

            //Act

            string Type = TestMC.KøretøjsType();

            //Assert
            Assert.AreEqual("MC", Type);
        }

        [DataTestMethod]
        [DataRow("31AH32EQ")]
        [DataRow("AO93ewq123")]
        [DataRow("eeiw12301md")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNummerpladeLængde(string Nummerplade)
        {
            //Arrange

            Bil TestBil = new Bil(Nummerplade, DateTime.Now);
            MC TestMC = new MC(Nummerplade, DateTime.Now);

            //Assert

            Assert.Fail();
        }

        [TestMethod]
        public void MedBrobizz()
        {
            //Arrange

            MC TestMC = new MC("Test", DateTime.Now);

            //Act
            TestMC.Brobizz = true;

            double pris = TestMC.Pris();

            //Assert
            Assert.AreEqual(125 * 0.95, pris, 0.01);
        }
    }
}

