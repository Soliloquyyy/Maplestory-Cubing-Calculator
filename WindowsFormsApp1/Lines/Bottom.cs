using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bottom : Lines
    {
        public Bottom()
        {
            AvailLine1 = Bottom1;
            AvailLine2 = Bottom2;
            AvailLine3 = Bottom3;
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

        private readonly int[] Bottom1 =
        {
            7,8,9,10,11,12,13
        };

        private readonly int[] Bottom2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
        };

        private readonly int[] Bottom3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
        };

        private readonly double[] Red1 =
        {
            0.102564,
            0.205128,
            0.307692,
            0.410256,
            0.512820,
            0.615384,
            0.692307,
            1.000000
        };

        private readonly double[] Red2 =
        {
            0.080357,
            0.160714,
            0.241071,
            0.321428,
            0.417857,
            0.514286,
            0.578572,
            0.588828,
            0.599084,
            0.609340,
            0.619596,
            0.629852,
            0.640108,
            0.704394,
            0.712086,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.088393,
            0.176786,
            0.265179,
            0.353572,
            0.459643,
            0.565714,
            0.636428,
            0.637454,
            0.638480,
            0.639506,
            0.640532,
            0.641558,
            0.642584,
            0.713298,
            0.714067,
            1.000000
        };
    }
}
