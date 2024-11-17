using static Lab6_3Iter;
using Xunit;
namespace Lab6_3IterUnitTest
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
        public void SortArrayDescending_ShouldSortArrayCorrectly()
        {
            // Arrange
            int[] array = { 1, 5, 2, 9, 3 };

            // Act
            SortArrayDescending(array);

            // Assert
            int[] expected = { 9, 5, 3, 2, 1 };
            Assert.Equal(expected, array);
        }

        [Fact]
        public void PrintArray_ShouldNotThrowException()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4 };

            // Act & Assert
            var exception = Record.Exception(() => PrintArray(array));
            Assert.Null(exception);  // Ensure no exception is thrown
        }
    }
}