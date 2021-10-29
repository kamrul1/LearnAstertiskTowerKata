using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AstrickTowerGeneratorTest2
{
    public class AstrickPrinterTest
    {
        [Fact]
        public void ShouldReturnAstrickButtomLine()
        {
            IAstrickTupleCalculator ast
                = new AstrickTupleCalculator(3);

            var sut = new AstrickPrinter(ast);

            var result = sut.Bottom();

            Assert.Equal("*****", result);

        }


        [Fact]
        public void ShouldReturnAstrickFromTupple()
        {
            var sut = new AstrickPrinter(null);

            var expected = " *** ";
            var tupleToConvert = (1, 3, 1);

            var result = sut.ConvertTupleToStars(new StringBuilder(),
                tupleToConvert);

            Assert.Equal(expected, result.ToString());

        }

        [Fact]
        public void ShouldReturnAstrickAll3Lines()
        {
            IAstrickTupleCalculator ast
    = new AstrickTupleCalculator(3);

            var sut = new AstrickPrinter(ast);

            var expected =  "  *  \n" +
                            " *** \n" +
                            "*****\n";

            string result = sut.GetAllLines();

            Assert.Equal(expected, result);

        }

        [Fact]
        public void ShouldReturnAstrickAll5Lines()
        {
            IAstrickTupleCalculator ast
    = new AstrickTupleCalculator(4);

            var sut = new AstrickPrinter(ast);

            var expected =  "   *   \n" +
                            "  ***  \n" +
                            " ***** \n" +
                            "*******\n";


            string result = sut.GetAllLines();

            Assert.Equal(expected, result);

        }



    }

}
