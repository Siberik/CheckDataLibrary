using CheckDataLibrary;
namespace CheckDataLibraryTests
   
{
    [TestClass]
    public class VinCheckTest
    {
        /// <summary>
        /// �������� VIN �� ������ ������
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
        /// �������� �� 17 ��������
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
        /// �������� �� ��������� VIN
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
        /// �������� ��������� ���
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
        /// �������� �� ��� ��������������� �������
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
        /// �������� �� ����������������� ���
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
        /// �������� �� ������� ���
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
        /// �������� �� ����������� �������
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
        /// �������� �� ����������� ������ Q
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
        /// �������� �� ���������� ������ I
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
        /// �������� �� ����������� ������ O
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
        /// �������� �� ����������� ������ O
        /// </summary>
        [TestMethod]
        public void GetVINCountry_ForbiddenSymbolO_ReturnedFalse()
        {
            //Arrange
            string vin = "JHMCM56557C404453";
            string excepted = "������";
            //Act
            VinCheck check = new VinCheck();
            string actual = check.GetVINCountry(vin);
            //Assert
            Assert.AreEqual(excepted,actual);
        }
    }
}