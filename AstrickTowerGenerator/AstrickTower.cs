using System;

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
            return 4;
        }
    }
}
