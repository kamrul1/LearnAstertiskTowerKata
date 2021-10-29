using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AstrickTowerGeneratorTest2
{
    public class AstrickTupleCalculatorTest
    {

        [Theory]
        [InlineData(1,1)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 9)]
        public void ShouldGenerateBottomLine(int noLines, int bottom)
        {
            var sut = new AstrickTupleCalculator(noLines);

            var result = sut.StarsBottomLine;

            Assert.Equal(bottom, result);

        }

        [Fact]
        public void ShouldReturnTupleAtBottomLevel()
        {
            var sut = new AstrickTupleCalculator(3);
            var expected = (0, 5, 0);

            (int left, int middle, int right) result = sut.GetTupleAtLevel(3);

            Assert.Equal(expected, result);

        }

        [Fact]
        public void ShouldReturnTupleAtOneLevelUp()
        {
            var sut = new AstrickTupleCalculator(3);

            var expected = (1, 3, 1);

            (int left, int middle, int right) result = sut.GetTupleAtLevel(2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnReturnTupleAtLevelOne()
        {
            var sut = new AstrickTupleCalculator(3);

            var expected = (2, 1, 2);

            (int left, int middle, int right) result = sut.GetTupleAtLevel(1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnAllLevels()
        {
            var sut = new AstrickTupleCalculator(3);

            List<(int, int, int)> expected 
                = new List<(int, int, int)>
            {
                (0, 5, 0),
                (1,3,1),
                (2,1,2)
            };

            List<(int, int, int)> result 
                = sut.GetTupleAtAllLevels();

            Assert.Equal(expected, result);
        }


    }
}
