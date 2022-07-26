using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 5, 5, 20)]
        [InlineData(0, -3, -2, -5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(2, 1, 1)]
        [InlineData(2, 0, 2)]
        [InlineData(0, 2, -2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtract = new Calculator();
            //Act
            var actual = minuend - subtrhend;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(2, 0, 0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiply = new Calculator();
            //Act
            var actual = num1 * num2;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(10, 2, 5)]
        [InlineData(2, 0, 0)] // How to divide by 0?
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new Calculator();
            //Act
            var actual = num2 == 0 ? 0 : num1 / num2;
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
