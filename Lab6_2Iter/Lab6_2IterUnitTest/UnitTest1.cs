using static Lab6_2Iter;
using Xunit;
namespace Lab6_2IterUnitTest
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
        public void CalculateOddAverage_ShouldReturnCorrectAverage()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            double average = CalculateOddAverage(array);

            // Assert
            Assert.Equal(3.0, average);  // Average of odd numbers: (1 + 3 + 5) / 3 = 3.0
        }

        [Fact]
        public void CalculateOddAverage_ShouldReturnZeroWhenNoOddNumbers()
        {
            // Arrange
            int[] array = { 2, 4, 6, 8 };

            // Act
            double average = CalculateOddAverage(array);

            // Assert
            Assert.Equal(0, average);  // No odd numbers, so the average is 0
        }

        [Fact]
        public void CalculateOddAverage_ShouldReturnZeroWhenArrayIsEmpty()
        {
            // Arrange
            int[] array = new int[0];

            // Act
            double average = CalculateOddAverage(array);

            // Assert
            Assert.Equal(0, average);  // Empty array should result in average = 0
        }
    }
}