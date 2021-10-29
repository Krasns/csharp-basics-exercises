using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace Exercise1Test
{
    [TestClass]
    public class IntegerValuesCheckTest
    {
        [TestMethod]
        public void Constructor_ValidValues_TakesValues()
        {
            //Arrange
            int firstNumber = 4;
            int secondNumber = 3;

            //Act
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Assert
            Assert.IsTrue(valueCheck.FirstNumber==firstNumber);
            Assert.IsTrue(valueCheck.SecondNumber==secondNumber);
        }
        [TestMethod]
        public void Check_InputValidValues_ReturnsTrue()
        {
            //Arrange
            int firstNumber = 10;
            int secondNumber = 5;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool value = valueCheck.Check();

            //Assert
            Assert.IsTrue(value == true);
        }
        [TestMethod]
        public void Check_InputValidValues_ReturnsFalse()
        {
            //Arrange
            int firstNumber = 10;
            int secondNumber = 2;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool returnValue = valueCheck.Check();

            //Assert
            Assert.IsTrue(returnValue == false);
        }
        [TestMethod]
        public void Check_FirstInputIs15_ReturnsTrue()
        {
            //Arrange
            int firstNumber = 15;
            int secondNumber = 0;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool returnValue = valueCheck.Check();
            //Assert
            Assert.IsTrue(returnValue == true);
        }
        [TestMethod]
        public void Check_SecondInputIs15_ReturnsTrue()
        {
            //Arrange
            int firstNumber = 5;
            int secondNumber = 15;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool returnValue = valueCheck.Check();
            //Assert
            Assert.IsTrue(returnValue == true);
        }
        [TestMethod]
        public void Check_InputSumIs15_ReturnsTrue()
        {
            //Arrange
            int firstNumber = 5;
            int secondNumber = 10;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool returnValue = valueCheck.Check();
            //Assert
            Assert.IsTrue(returnValue == true);
        }
        [TestMethod]
        public void Check_FirstInputDifferenceIs15_ReturnsTrue()
        {
            //Arrange
            int firstNumber = 25;
            int secondNumber = 10;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool returnValue = valueCheck.Check();
            //Assert
            Assert.IsTrue(returnValue == true);
        }
        [TestMethod]
        public void Check_SecondInputDifferenceIs15_ReturnsTrue()
        {
            //Arrange
            int firstNumber = 5;
            int secondNumber = 20;
            var valueCheck = new IntegerValuesCheck(firstNumber, secondNumber);

            //Act
            bool returnValue = valueCheck.Check();
            //Assert
            Assert.IsTrue(returnValue == true);
        }
    }
}
