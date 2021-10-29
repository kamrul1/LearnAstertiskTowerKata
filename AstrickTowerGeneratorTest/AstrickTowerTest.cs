
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
        public void ShouldReturnBottomAsTupleOfLeftSpacesMiddleAstricksRightSpaces()
        {
            var sut = new AstrickTower(3);

            var expected = (0, 3, 0);

            var bottomValue = sut.TowerBottomValue();


            (int, int, int) actual = sut.ConvertToTupple();

            Assert.Equal(expected, actual);

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

        [Fact]
        public void ShouldNextRowUpFromBottom()
        {
            var sut = new AstrickTower(3);
            var previousRow = sut.TowerBottomValue();

            var expected = (2, 1, 2);
            _= sut.nextRowUp();
            (int, int, int) result = sut.nextRowUp();


            Assert.Equal(expected, result);

        }
    }
}
