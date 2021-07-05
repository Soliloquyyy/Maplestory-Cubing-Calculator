using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Top : Lines
    {
        public Top()
        {
            AvailLine1 = Top1;
            AvailLine2 = Top2;
            AvailLine3 = Top3;
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

        private readonly int[] Top1 =
        {
            7,8,9,10,11,12,13
        };

        private readonly int[] Top2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };

        private readonly int[] Top3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };

        private readonly double[] Red1 =
        {
            0.088889,
            0.177778,
            0.266667,
            0.355556,
            0.444445,
            0.533334,
            0.600001,
            1.000000

        };

        private readonly double[] Red2 =
        {
            0.068182,
            0.136364,
            0.204546,
            0.272728,
            0.354546,
            0.436364,
            0.490909,
            0.499798,
            0.508687,
            0.517576,
            0.526465,
            0.535354,
            0.544243,
            0.550910,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.075000,
            0.150000,
            0.225000,
            0.300000,
            0.390000,
            0.480000,
            0.540000,
            0.540889,
            0.541778,
            0.542667,
            0.543556,
            0.544445,
            0.545334,
            0.546001,
            1.000000
        };
    }
}
