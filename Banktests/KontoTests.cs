using Bank;

namespace Banktests
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Einzahlung_SteigertGuthaben()
        {
            //Arrange
            int startBetrag = 100;
            Konto k1 = new Konto(startBetrag);

            int einzahlung_Betrag = 20;

            int guthaben_Soll = startBetrag + einzahlung_Betrag;

            // Act
            k1.Einzahlen(einzahlung_Betrag);

            //Assert
            Assert.AreEqual(guthaben_Soll, k1.Guthaben);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Einzahlung_MitNegativWert() 
        {
            //Arrange
            int startBetrag = 100;
            Konto k1 = new Konto(startBetrag);

            int einzahlung_Betrag = -20;

            int guthaben_Soll = startBetrag + einzahlung_Betrag;

            // Act
            k1.Einzahlen(einzahlung_Betrag);

        }
    }
}