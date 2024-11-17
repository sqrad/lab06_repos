using static Lab6_2Recur;
using Xunit;
namespace Lab6_2RecurUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void GenerateArray_ShouldReturnArrayOfCorrectSize()
        {
            // Arrange
            int size = 25;
            int min = -20;
            int max = 30;

            // Act
            int[] result = GenerateArray(size, min, max);

            // Assert
            Assert.Equal(size, result.Length);
        }

        [Fact]
        public void GenerateArray_ShouldContainElementsWithinRange()
        {
            // Arrange
            int size = 10;
            int min = -20;
            int max = 30;

            // Act
            int[] result = GenerateArray(size, min, max);

            // Assert
            foreach (var number in result)
            {
                Assert.InRange(number, min, max);  // Check if each number is within the range [min, max]
            }
        }

        [Fact]
        public void SumOddRecursive_ShouldReturnCorrectSum()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            int sum = SumOddRecursive(array, 0);

            // Assert
            Assert.Equal(9, sum);  // Sum of odd numbers: 1 + 3 + 5 = 9
        }

        [Fact]
        public void CountOddRecursive_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            int count = CountOddRecursive(array, 0);

            // Assert
            Assert.Equal(3, count);  // There are 3 odd numbers: 1, 3, and 5
        }

        [Fact]
        public void AverageOdd_ShouldReturnCorrectAverage()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            int sum = SumOddRecursive(array, 0);
            int count = CountOddRecursive(array, 0);
            double average = count > 0 ? (double)sum / count : 0;

            // Assert
            Assert.Equal(3.0, average);  // Average of odd numbers: (1 + 3 + 5) / 3 = 3.0
        }

        [Fact]
        public void PrintArrayRecursive_ShouldNotThrowException()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4 };

            // Act & Assert
            var exception = Record.Exception(() => PrintArrayRecursive(array, 0));
            Assert.Null(exception);  // Ensure no exception is thrown
        }
    }
}