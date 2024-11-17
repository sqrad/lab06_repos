using static Lab6_4Iter;
using Xunit;
namespace Lab6_4IterUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void GenerateArray_ShouldReturnArrayOfGivenLength()
        {
            // Arrange
            int n = 5;

            // Act
            double[] result = GenerateArray(n);

            // Assert
            Assert.Equal(n, result.Length);
        }

        [Fact]
        public void FindMaxElement_ShouldReturnMaxElement()
        {
            // Arrange
            double[] array = { -10.5, 0.0, 15.2, 8.3, -2.2 };

            // Act
            double maxElement = FindMaxElement(array);

            // Assert
            Assert.Equal(15.2, maxElement);
        }

        [Fact]
        public void SumUntilLastPositive_ShouldReturnCorrectSum()
        {
            // Arrange
            double[] array = { -40.97, -14.41, -9.44, -3.65, 44.33 };

            // Act
            double sum = SumUntilLastPositive(array);

            // Assert
            Assert.Equal(-68.47, sum); 
        }

        [Fact]
        public void CompressArray_ShouldCompressArrayCorrectly()
        {
            // Arrange
            double[] array = { -40.97, -14.41, -9.44, -3.65, 44.33 };
            double a = 2.0;
            double b = 8.0;

            // Act
            CompressArray(ref array, a, b);

            // Assert
            double[] expected = { -40.97, -14.41, -9.44, 44.33, 0.0 };
            Assert.Equal(expected, array);
        }

        [Fact]
        public void PrintArray_ShouldNotThrowException()
        {
            // Arrange
            double[] array = { 1.1, 2.2, 3.3 };

            // Act & Assert
            var exception = Record.Exception(() => PrintArray(array));
            Assert.Null(exception); // Ensure no exception is thrown
        }
    }
}