using System;
using System.Collections.Generic;
using System.Linq;

namespace AstrickTowerGeneratorTest
{
    public class AstrickTower
    {
        private readonly int heightInRows;
        private readonly int runningCounter;

        public AstrickTower(int heightInRows)
        {
            this.heightInRows = heightInRows;
            runningCounter = TowerBottomValue();
        }

        public int TowerBottomValue()
        {

            int maxValue = 0;
            for (int i = 0, x = 1; i < heightInRows; i++)
            {
                maxValue = x;
                x += 2;
            }

            return maxValue;
        }

        public (int left, int middle, int right) nextRowUp()
        {
            var previousValue = runningCounter;
            int middle = previousValue - 2;
            int space = (previousValue - middle) / 2;

            return (space, middle, space);
        }

        //TODo: abandoned for next timed attempt
        public (int left, int middle, int right) ConvertToTupple()
        {
            return (default, default, default);
        }

        public (int, int, int) ConvertToTupple((int left, int middle, int right) rowValues)
        {
            throw new NotImplementedException();
        }
    }
}
