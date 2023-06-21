using Lab03Review;
using Xunit;

namespace MyProgram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge1Test_InputStringOfNumbers_ReturnsProductOfAllNumbers()
        {
            // Arrange
            string input = "4 8 15";
            double expected = 480;

            // Act
            //double actual = Program.Challenge1(input);

            // Assert
            // Assert.Equal(expected, actual);
        }

        [Fact]
        public void Challenge2Test_InputArrayOfNumbers_ReturnsSumOfEvenNumbers()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int expected = 20;

            // Act
            // int actual = Program.Challenge2(input);

            // Assert
            // Assert.Equal(expected, actual);
        }

        [Fact]
        public void Challenge3Test_InputStringOfNumbers_ReturnsAverageOfNumbers()
        {
            // Arrange
            string input = "10 20 30 40 50";
            double expected = 30.0;

            // Act
            //   double actual = Program.Challenge3(input);

            // Assert
            // Assert.Equal(expected, actual);
        }
    }
}
