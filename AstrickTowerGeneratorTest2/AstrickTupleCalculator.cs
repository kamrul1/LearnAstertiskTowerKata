using System;
using System.Collections.Generic;
using Xunit;

namespace AstrickTowerGeneratorTest2
{
    public class AstrickTupleCalculator : IAstrickTupleCalculator
    {
        private const int ZERO_SPACES = 0;
        private const int TWO_SIDES = 2;
        private readonly int noLines;

        public int StarsBottomLine
        {
            get { return FormulaForBaseStars(); }
        }

        private int FormulaForBaseStars()
        {
            return (2*noLines) - 1;
        }

        public AstrickTupleCalculator(int noLines)
        {
            this.noLines = noLines;
        }

        internal (int left, int middle, int right) GetTupleAtLevel(int level)
        {
            if (IsBottomLevel(level))
            {
                return (ZERO_SPACES, StarsBottomLine, ZERO_SPACES);
            }

            return RemoveTwoSpacesPerLevel(level);
        }

        private (int left, int middle, int right) RemoveTwoSpacesPerLevel(int level)
        {
            var levelDiff = noLines - level;

            int middle = StarsBottomLine - (levelDiff * TWO_SIDES);
            int spaceOnEachSide = levelDiff;

            return (spaceOnEachSide, middle, spaceOnEachSide);
        }

        private bool IsBottomLevel(int level)
        {
            return level == noLines;
        }

        public List<(int, int, int)> GetTupleAtAllLevels()
        {
            List<(int, int, int)> tupleLines = new();
            for (int i = noLines; i > 0; i--)
            {
                var tupleLine = GetTupleAtLevel(i);
                tupleLines.Add(tupleLine);
            }

            return tupleLines;
        }
    }
}
