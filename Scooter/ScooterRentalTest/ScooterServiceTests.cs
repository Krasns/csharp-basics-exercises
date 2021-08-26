using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ScooterRentalTest
{
    [TestClass]
    public class ScooterServiceTests
    {
        private IScooterService _target;

        public ScooterServiceTests()
        {
            _target = new ScooterServiceTests();
        }
        [TestMethod]
        public void AddScooter_NewScooter_Succeeds()
        {
            //Act
            _target.AddScooter("1", 0.2);

            //Assert
            Assert.IsNotNull(_target.GetScooterById("1"));
        }

        [TestMethod]
        public void RemoveScooter_Id1_Succeeds()
        {
            //Arrange
            _target.AddScooter("1", 0.2);
            
            //Act
            _target.RemoveScooter("1");

            //Assert
            Assert.IsNull(_target.GetScooterById("1"));
        }

        [TestMethod]
        public void GetScooters_Added2_2Expected()
        {
            //Arrange
            _target.AddScooter("1", 0.1);
            _target.AddScooter("2", 0.1);

            //Act
            var scooters.GetScooters = _target.GetScooters();

            //Assert
            Assert.AreEqual(2,scooters.Count);
        }

        [TestMethod]
        public void AddScooter_NullId_ArgumentExceptionExpected()
        {
            //Act
            Assert.ThrowsExeption<ArgumentException>(() =>
                _target.AddScooter(null, 0.1));
        }
        [TestMethod]
        public void AddScooter_NullPrice_ArgumentExceptionExpected()
        {
            //Act
            Assert.ThrowsExeption<InvalidPriceException>(() =>
                _target.AddScooter(null, 0.1));
        }
    }
}
