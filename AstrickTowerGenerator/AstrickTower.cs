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

            List<int> Odds = new();
            for (int i = 0, x=1; i < heightInRows; i++)
            {
                Odds.Add(x);
                x += 2;
            }

            return Odds.Max();
        }
    }
}
