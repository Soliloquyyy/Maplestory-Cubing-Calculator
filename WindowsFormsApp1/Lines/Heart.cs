using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Heart : Lines
    {
        public Heart()
        {
            AvailLine1 = Heart1;
            AvailLine2 = Heart2;
            AvailLine3 = Heart3;
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

        private readonly int[] Heart1 =
        {
            7,8,9,10,11,12,13,14
        };

        private readonly int[] Heart2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };

        private readonly int[] Heart3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };

        private readonly double[] Red1 =
        {
            0.129032,
            0.258064,
            0.387096,
            0.516128,
            0.645160,
            0.774192,
            0.870966,
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
            0.749267,
            0.762170,
            0.775073,
            0.787976,
            0.800879,
            0.813782,
            0.823459,
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
            0.811290,
            0.812580,
            0.813870,
            0.815160,
            0.816450,
            0.817740,
            0.818708,
            1.000000
        };
        
    }
}
