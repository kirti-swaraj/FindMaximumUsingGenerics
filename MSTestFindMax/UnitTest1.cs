using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsTestMaximum;

namespace MSTestFindMax
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summary>
        /// UC 1.1 : Given the maximum number at first position returns the same number.
        /// </summary>
        
        public void GivenMaxNumberAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 30, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 1.2 : Given the maximum number at second position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumberAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 80;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 80, 10);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 1.3 : Given the maximum number at third position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxNumberAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            int expected = 100;
            //Act
            int actual = FindMaximum.MaxIntegerAmongThree(50, 30, 100);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC 2.1 : Given the maximum float at first position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            double expected = 10.55;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(10.55, 09, 10.2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 2.2 : Given the maximum float at second position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            double expected = 0.45;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(0.25, 0.45, 0.2);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 2.3 : Given the maximum float at third position returns the same number.
        /// </summary>
        [TestMethod]
        public void GivenMaxFloatAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            double expected = 6.6;
            //Act
            double actual = FindMaximum.MaxFloatAmongThree(1.256, 3.85, 6.6);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC 3.1 : Given the maximum string at first position returns the same string.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtFirstPos_ReturnTheSameNumber()
        {
            //Arrange
            string expected = "Kirti";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Kirti", "Appy", "Cat");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC 3.2 : Given the maximum string at second position returns the same string.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtSecondPos_ReturnTheSameNumber()
        {
            //Arrange
            string expected = "Zebra";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Kirti", "Zebra", "Rat");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UC 3.3 : Given the maximum string at third position returns the same string.
        /// </summary>
        [TestMethod]
        public void GivenMaxStringAtThirdPos_ReturnTheSameNumber()
        {
            //Arrange
            string expected = "Zebra";
            //Act
            string actual = FindMaximum.MaxStringAmongThree("Kirti", "Appy", "Zebra");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 3 : Refactor 1 : Added Generic Method
        /// </summary>
        [TestMethod]
        public void UC3Refactor1()
        {
            //Arrange
            string expected = "Zebra";
            //Act
            string actual = FindMaximum.MaxValueAmongThreeRefactor1<string>("Kirti", "Appy", "Zebra");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC 3 : Refactor 2 : Added Generic Class
        /// </summary>
        [TestMethod]
        public void UC3Refactor2()
        {
            //Arrange
            double expected = 95.67;
            GenericMaximum<double> maxFloat = new GenericMaximum<double>(25.34, 95.67, 58.64);
            //Act
            double actual = maxFloat.MaxMethod();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
