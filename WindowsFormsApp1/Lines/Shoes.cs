using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Shoes : Lines
    {
        public Shoes()
        {
            AvailLine1 = Shoes1;
            AvailLine2 = Shoes2;
            AvailLine3 = Shoes3;
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

        private readonly int[] Shoes1 =
        {
            8,9,10,11,12,13,14,15
        };

        private readonly int[] Shoes2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
        };

        private readonly int[] Shoes3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
        };
        private readonly double[] Red1 =
        {
            0.100000,
            0.200000,
            0.300000,
            0.400000,
            0.500000,
            0.600000,
            0.675000,
            0.750000,
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
            0.642858,
            0.652858,
            0.662858,
            0.672858,
            0.682858,
            0.692858,
            0.700358,
            0.710358,
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
            0.707142,
            0.708142,
            0.709142,
            0.710142,
            0.711142,
            0.712142,
            0.712892,
            0.713892,
            1.000000
        };
    }
}
