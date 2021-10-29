using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstrickTowerGeneratorTest2
{
    public class AstrickPrinter
    {
        private readonly IAstrickTupleCalculator astrickTupleCalculator;

        public AstrickPrinter(IAstrickTupleCalculator astrickTupleCalculator)
        {
            this.astrickTupleCalculator = astrickTupleCalculator;
        }

        internal string Bottom()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var noStars = astrickTupleCalculator.StarsBottomLine;
            stringBuilder = AddStars(stringBuilder, noStars);

            return stringBuilder.ToString();
        }

        private static StringBuilder AddStars(StringBuilder stringBuilder,
            int noStars)
        {
            for (int i = 0; i < noStars; i++)
            {
                stringBuilder.Append("*");
            }

            return stringBuilder;
        }

        private static StringBuilder AddSpaces(StringBuilder stringBuilder, 
            int noSpaces)
        {
            for (int i = 0; i < noSpaces; i++)
            {
                stringBuilder.Append(" ");
            }

            return stringBuilder;
        }

        internal string GetAllLines()
        {
            var starsList = astrickTupleCalculator.GetTupleAtAllLevels();

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = starsList.Count - 1; i >= 0; i--)
            {
                (int, int, int) stars = starsList[i];
                stringBuilder = ConvertTupleToStars(stringBuilder,stars);
                stringBuilder.Append("\n");
            }

            return stringBuilder.ToString();

        }

        internal StringBuilder ConvertTupleToStars(StringBuilder stringBuilder,
            (int left, int middle, int right) tupleToConvert)
        {
            
            stringBuilder =  AddSpaces(stringBuilder, tupleToConvert.left);
            stringBuilder = AddStars(stringBuilder, tupleToConvert.middle);
            stringBuilder = AddSpaces(stringBuilder, tupleToConvert.right);
            return stringBuilder;

        }
    }
}
