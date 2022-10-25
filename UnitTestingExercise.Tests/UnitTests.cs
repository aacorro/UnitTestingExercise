using System;
using System.ComponentModel;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 0, 0, 0)]
        [InlineData(-2, 2, 0, 0)]
        [InlineData(4, -6, 1, -1)]
        
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var add = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = add.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }   

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(5, -10, 15)]
        [InlineData(-5, -10, 5)]
        [InlineData(-5, 10, -15)]
        
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtract = new Calculator();
            //Act
            var actual = subtract.Substract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 8)]//Add test data <-------
        [InlineData(-4, 2, -8)]
        [InlineData(2, -5, -10)]
        [InlineData(0, 0, 0)]
        [InlineData(2, 0, 0)]
        [InlineData(0, 3, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multip = new Calculator();
            //Act
            var actual = multip.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]//Add test data <-------
        [InlineData(4, 0, 0)]
        [InlineData(-4, 2, -2)]
        [InlineData(0, 2, 0)]
        [InlineData(4, -2, -2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new Calculator();
            //Act
            var actual = divide.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
