using static Lab6_1Iter;
using Xunit;
namespace Lab6_1IterUnitTest
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
        public void CountFiltered_ShouldReturnCorrectCount()
        {
            // Arrange
            int[] array = { 2, 4, 6, -8, -2, 3, 7 };

            // Act
            int count = CountFiltered(array);

            // Assert
            Assert.Equal(3, count);  // 2, 4, and 6 are positive even numbers
        }

        [Fact]
        public void SumFiltered_ShouldReturnCorrectSum()
        {
            // Arrange
            int[] array = { 2, 4, 6, -8, -2, 3, 7 };

            // Act
            int sum = SumFiltered(array);

            // Assert
            Assert.Equal(12, sum);  // 2 + 4 + 6 = 12
        }

        [Fact]
        public void ReplaceFilteredWithZeros_ShouldReplaceCorrectElements()
        {
            // Arrange
            int[] array = { 2, 4, 6, -8, -2, 3, 7 };

            // Act
            ReplaceFilteredWithZeros(array);

            // Assert
            int[] expected = { 0, 0, 0, -8, -2, 3, 7 };
            Assert.Equal(expected, array);
        }

        [Fact]
        public void ReplaceFilteredWithZeros_ShouldNotModifyNonFilteredElements()
        {
            // Arrange
            int[] array = { -1, -3, 5, 7 };

            // Act
            ReplaceFilteredWithZeros(array);

            // Assert
            int[] expected = { -1, -3, 5, 7 };
            Assert.Equal(expected, array);
        }
    }
}