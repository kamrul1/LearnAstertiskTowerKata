using System.Collections.Generic;

namespace AstrickTowerGeneratorTest2
{
    public interface IAstrickTupleCalculator
    {
        int StarsBottomLine { get; }

        List<(int, int, int)> GetTupleAtAllLevels();
    }
}