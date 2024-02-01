namespace KataTest;

using KataApp;

public class SquareNTest
{
    [Fact]
    public void SumSquare_Should_Return_Sum_Of_Array()
    {
        // Arrange
        var nums = new int[] { 1, 2, 3 };
        var square = new SquareN();
        // Act
        var result = square.SumSquare(nums, 1);
        // Assert
        Assert.Equal(6, result);
    }
}
