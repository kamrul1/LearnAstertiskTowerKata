using System;
using System.Collections.Generic;
using Xunit;

namespace AstrickTowerGeneratorTest2
{
    public class AstrickTupleCalculator : IAstrickTupleCalculator
    {
        private int noLines;

        public int StarsBottomLine
        {
            get { return (noLines * 2) - 1; }
        }



        public AstrickTupleCalculator(int noLines)
        {
            this.noLines = noLines;
        }

        internal (int left, int middle, int right) GetTupleAtLevel(int level)
        {
            if (level == noLines)
            {
                return (0, StarsBottomLine, 0);
            }

            var levelDiff = noLines - level;

            int middle = StarsBottomLine - (levelDiff * 2);
            int left = levelDiff, right = levelDiff;

            return (left, middle, right);
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
