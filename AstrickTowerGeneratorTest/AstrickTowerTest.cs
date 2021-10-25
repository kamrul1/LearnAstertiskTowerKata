using AstrickTowerGenerator;
using System;
using Xunit;

namespace AstrickTowerGeneratorTest
{
    public class AstrickTowerTest
    {
        [Fact]
        public void ShouldGenerateBottomRowUsingOddNumberRule()
        {
            var sut = new AstrickTower(3);

            var result = sut.TowerBottomValue();

            Assert.Equal(5, result);
        }
    }
}
