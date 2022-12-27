using CheckDataLibrary;
namespace CheckDataLibraryTests
   
{
    [TestClass]
    public class VinCheckTest
    {
        /// <summary>
        /// Проверка VIN на пустую строку
        /// </summary>
        [TestMethod]
        public void CheckVin_StringEmpty_ReturnedFalse()
        {
            //Arrange
            string vin=String.Empty;
            int year = 2000;
            //Act
           VinCheck check= new VinCheck();
            bool actual=check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на 17 пробелов
        /// </summary>
        [TestMethod]
        public void CheckVin_17Space_ReturnedFalse()
        {
            //Arrange
            string vin ="                 ";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на маленький VIN
        /// </summary>
        [TestMethod]
        public void CheckVin_SmallLenght_ReturnedFalse()
        {
            //Arrange
            string vin = "123";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка маленький год
        /// </summary>
        [TestMethod]
        public void CheckVin_PrevYear_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C404453";
            int year = 1919;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на все соответствующие условия
        /// </summary>
        [TestMethod]
        public void CheckVin_RightVin_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C404453";
            int year = 2006;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Проверка на несоответствующий год
        /// </summary>
        [TestMethod]
        public void CheckVin_UnRightVin_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C404453";
            int year = 2010;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на большой год
        /// </summary>
        [TestMethod]
        public void CheckVin_NextYear_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C404453";
            int year = 2077;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на специальные символы
        /// </summary>
        [TestMethod]
        public void CheckVin_SpecialSymbols_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C40445+";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на запрещённый символ Q
        /// </summary>
        [TestMethod]
        public void CheckVin_ForbiddenSymbolQ_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C40445Q";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на запрщённый символ I
        /// </summary>
        [TestMethod]
        public void CheckVin_ForbiddenSymbolI_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C40445I";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на запрещённый символ O
        /// </summary>
        [TestMethod]
        public void CheckVin_ForbiddenSymbolO_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C40445O";
            int year = 2000;
            //Act
            VinCheck check = new VinCheck();
            bool actual = check.CheckVin(vin, year);
            //Assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// Проверка на запрещённый символ O
        /// </summary>
        [TestMethod]
        public void GetVINCountry_ForbiddenSymbolO_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C404453";
            string excepted = "Япония";
            //Act
            VinCheck check = new VinCheck();
            string actual = check.GetVINCountry(vin);
            //Assert
            Assert.AreEqual(excepted,actual);
        }
    }
}