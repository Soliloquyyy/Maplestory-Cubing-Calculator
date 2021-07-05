using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Accessories : Lines
    {
        public Accessories()
        {
            AvailLine1 = Accessories1;
            AvailLine2 = Accessories2;
            AvailLine3 = Accessories3;
            ProbabilityR1 = Red1;
            ProbabilityR2 = Red2;
            ProbabilityR3 = Red3;

            AvailLines = new Dictionary<int, int[]>
            {
                {0, AvailLine1 },
                {1, AvailLine2 },
                {2, AvailLine3 }
            };

            ProbabilityR = new Dictionary<int, double[]>
            {
                {0, ProbabilityR1 },
                {1, ProbabilityR2 },
                {2, ProbabilityR3 }
            };
        }

        private readonly int[] Accessories1 =
        {
            7,8,9,10,11,12,13,14,15,16
        };

        private readonly int[] Accessories2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
        };

        private readonly int[] Accessories3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
        };

        private readonly double[] Red1 =
        {
            0.093023,
            0.186046,
            0.279069,
            0.372092,
            0.465115,
            0.558138,
            0.627905,
            0.697672,
            0.767439,
            1.000000
        };

        private readonly double[] Red2 =
        {
            0.102273,
            0.204546,
            0.306819,
            0.409092,
            0.531819,
            0.654546,
            0.736364,
            0.745666,
            0.754968,
            0.764270,
            0.773572,
            0.782874,
            0.792176,
            0.799153,
            0.806130,
            0.813107,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.112500,
            0.225000,
            0.337500,
            0.450000,
            0.585000,
            0.720000,
            0.810000,
            0.810930,
            0.811860,
            0.812790,
            0.813720,
            0.814650,
            0.815580,
            0.816278,
            0.816976,
            0.817674,
            1.000000
        };
    }
}
