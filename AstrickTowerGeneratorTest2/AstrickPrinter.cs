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
            StringBuilder stringBuilder = new();
            var noStars = astrickTupleCalculator.StarsBottomLine;
            stringBuilder = AddStars(stringBuilder, noStars);

            return stringBuilder.ToString();
        }

        private static StringBuilder AddStars(StringBuilder stringBuilder,
            int noStars)
        {
            return AddCharacter(stringBuilder, noStars, CharType.Star);
        }

        private static StringBuilder AddSpaces(StringBuilder stringBuilder, 
            int noSpaces)
        {
            return AddCharacter(stringBuilder, noSpaces, CharType.Space);
    
        }

        public enum CharType { 
            Space=0,
            Star=1
        }


        private static StringBuilder AddCharacter(StringBuilder stringBuilder, int noChars, CharType charType)
        {
            for (int i = 0; i < noChars; i++)
            {
                if (charType == CharType.Space)
                {
                    stringBuilder.Append(' ');
                    continue;
                }

                stringBuilder.Append('*');
                
            }

            return stringBuilder;
        }



        public string GetAllLines()
        {
            var starsList = astrickTupleCalculator.GetTupleAtAllLevels();

            StringBuilder stringBuilder = new();

            for (int i = starsList.Count - 1; i >= 0; i--)
            {
                (int, int, int) stars = starsList[i];
                stringBuilder = ConvertTupleToStars(stringBuilder,stars);
                stringBuilder.Append('\n');
            }

            return stringBuilder.ToString();

        }

        internal static StringBuilder ConvertTupleToStars(StringBuilder stringBuilder,
            (int left, int middle, int right) tupleToConvert)
        {
            
            stringBuilder =  AddSpaces(stringBuilder, tupleToConvert.left);
            stringBuilder = AddStars(stringBuilder, tupleToConvert.middle);
            stringBuilder = AddSpaces(stringBuilder, tupleToConvert.right);
            return stringBuilder;

        }
    }
}
