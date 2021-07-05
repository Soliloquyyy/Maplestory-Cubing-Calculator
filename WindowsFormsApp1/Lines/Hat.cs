using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Hat : Lines
    {
        public Hat()
        {
            AvailLine1 = Hat1;
            AvailLine2 = Hat2;
            AvailLine3 = Hat3;
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

        private readonly int[] Hat1 =
        {
            7,8,9,10,11,12,13
        };

        private readonly int[] Hat2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17
        };

        private readonly int[] Hat3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17
        };

        private readonly double[] Red1 =
        {
            0.080000,
            0.160000,
            0.240000,
            0.320000,
            0.400000,
            0.480000,
            0.540000,
            0.600000,
            0.640000,
            0.700000,
            1.000000

        };
        private readonly double[] Red2 =
        {
            0.072581,
            0.145162,
            0.217743,
            0.290324,
            0.377421,
            0.464518,
            0.522583,
            0.530583,
            0.538583,
            0.546583,
            0.554583,
            0.562583,
            0.570583,
            0.576583,
            0.582583,
            0.586583,
            0.592583,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.079839,
            0.159678,
            0.239517,
            0.319356,
            0.415162,
            0.510968,
            0.574839,
            0.575639,
            0.576439,
            0.577239,
            0.578039,
            0.578839,
            0.579639,
            0.580239,
            0.580839,
            0.581239,
            0.581839,
            1.000000
        };


    }
}
