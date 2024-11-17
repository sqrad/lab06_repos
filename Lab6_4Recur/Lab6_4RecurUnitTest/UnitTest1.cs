using static Lab6_4Recur;
using Xunit;
namespace Lab6_4RecurUnitTest
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
            public void FindMaxElementRecursive_ShouldReturnMaxElement()
            {
                // Arrange
                double[] array = { -10.5, 0.0, 15.2, 8.3, -2.2 };

                // Act
                double maxElement = FindMaxElementRecursive(array);

                // Assert
                Assert.Equal(15.2, maxElement);
            }

            [Fact]
            public void FindLastPositiveIndex_ShouldReturnCorrectIndex()
            {
                // Arrange
                double[] array = { -1.0, 3.0, -4.0, 5.0, -2.0 };

                // Act
                int lastPositiveIndex = FindLastPositiveIndex(array);

                // Assert
                Assert.Equal(3, lastPositiveIndex);
            }

            [Fact]
            public void SumUntilLastPositiveRecursive_ShouldReturnCorrectSum()
            {
                // Arrange
                double[] array = { 9.58, 25.72, -31.41, -5.13, -47.61 };
                int lastPositiveIndex = FindLastPositiveIndex(array);

                // Act
                double sum = SumUntilLastPositiveRecursive(array, 0, lastPositiveIndex); 

                // Assert
                Assert.Equal(9.58, sum);
            }

            [Fact]
            public void CompressArrayRecursive_ShouldCompressArrayCorrectly()
            {
                double[] array = { 9.58, 25.72, -31.41, -5.13, -47.61 };
                double a = 2.0;
                double b = 8.0;

                // Act
                CompressArrayRecursive(array, a, b);

                // Assert
                double[] expected = { 9.58, 25.72, -31.41, -47.61, 0.0 };
                Assert.Equal(expected, array);
            }

            [Fact]
            public void PrintArray_ShouldNotThrowException()
            {
                // Arrange
                double[] array = { 1.1, 2.2, 3.3 };

                // Act & Assert
                var exception = Record.Exception(() => PrintArray(array));
                Assert.Null(exception);
            }
    }
}
