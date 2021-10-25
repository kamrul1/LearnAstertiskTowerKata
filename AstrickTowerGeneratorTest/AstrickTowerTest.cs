using AstrickTowerGenerator;
using System;
using Xunit;

namespace AstrickTowerGeneratorTest
{
    public class AstrickTowerTest
    {
        [Theory]
        [InlineData(3, 5)]
        [InlineData(2,3)]
        [InlineData(1,1)]
        public void ShouldGenerateBottomRowUsingOddNumberRule(int height, int expectedBottomRow)
        {
            var sut = new AstrickTower(height);

            var result = sut.TowerBottomValue();

            Assert.Equal(expectedBottomRow, result);
        }

        [Fact]
        public void ShouldReturnTwoSpaceLessAstriskAmount()
        {
            var sut = new AstrickTower(3);
            var previousRow = sut.TowerBottomValue();
            var expected = (1, 3, 1);


            (int,int,int) result = sut.nextRowUp();


            Assert.Equal(expected, result);
        }
    }
}
