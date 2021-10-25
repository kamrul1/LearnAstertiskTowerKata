using System;
using System.Collections.Generic;
using System.Linq;

namespace AstrickTowerGenerator
{
    public class AstrickTower
    {
        private readonly int heightInRows;

        public AstrickTower(int heightInRows)
        {
            this.heightInRows = heightInRows;
        }

        public int TowerBottomValue()
        {

            int maxValue = 0;
            for (int i = 0, x=1; i < heightInRows; i++)
            {
                maxValue = x;
                x += 2;
            }

            return maxValue;
        }

        public (int, int, int) nextRowUp()
        {
            var previousValue = TowerBottomValue();

            return (1, previousValue-2, 1);
        }
    }
}
