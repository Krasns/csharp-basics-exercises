using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;
using System;

namespace Exercise6Test
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void FillTenRandomNumbers_InputsNumbers_ReturnsNumbers()
        {
            // Arrange
            int[] changedArray = new int[10];
            int originalValue = 0;
            Random rand = new Random();
            var array = new ArrayExtensions();

            // Act
            array.FillTenRandomNumbers(rand,changedArray);

            // Assert
            for (int i = 0; i < changedArray.Length; i++)
            {
                Assert.AreNotEqual(originalValue, changedArray[i]);
            }
        }
        [TestMethod]
        public void CopyArray_CopysArraysValues()
        {
            //Arrange
            int[] originlArray = new int[10];
            var rand = new Random();
            var array = new ArrayExtensions();
            array.FillTenRandomNumbers(rand, originlArray);
            int[] copyedArray = new int[10];

            //Act
            array.CopyArray(originlArray,copyedArray);

            //Assert
            for (int i = 0; i < originlArray.Length; i++)
            {
                Assert.AreEqual(originlArray[i], copyedArray[i]);
            }
        }
        [TestMethod]
        public void ChangeLastValue_InputsArray_ChangesArraysLastValue()
        {
            //Arrange
            int[] originlArray = new int[10];
            var rand = new Random();
            var array = new ArrayExtensions();
            array.FillTenRandomNumbers(rand, originlArray);;

            //Act
            array.ChangeLastValue(originlArray);

            //Assert
            Assert.IsTrue(originlArray[originlArray.Length - 1] == -7);
        }
        //[TestMethod]
        //public void Display_InputsTwoArrays_DisplaysTwoArrays()
        //{
        //    //Arrange
        //    var firstArray = new int[10];
        //    var secondArray = new int[10];
        //    var arrayObject = new ArrayExtensions();
        //    Random r = new Random();
        //    arrayObject.FillTenRandomNumbers(r, firstArray);
        //    arrayObject.CopyArray(firstArray, secondArray);

        //    //Act
        //    arrayObject.Display(firstArray, secondArray);

        //    //Assert
            
        //}
    }
}
