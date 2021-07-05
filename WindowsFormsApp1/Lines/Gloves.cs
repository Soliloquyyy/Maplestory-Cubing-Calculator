using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Gloves : Lines
    {
        public Gloves()
        {
            AvailLine1 = Gloves1;
            AvailLine2 = Gloves2;
            AvailLine3 = Gloves3;
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

        private readonly int[] Gloves1 =
        {
            8,9,10,11,12,13,14,15,16
        };

        private readonly int[] Gloves2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17
        };

        private readonly int[] Gloves3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17
        };

        private readonly double[] Red1 =
        {
            0.090909,
            0.181818,
            0.272727,
            0.363636,
            0.454545,
            0.545454,
            0.636364,
            0.704546,
            0.772728,
            1.000000
        };

        private readonly double[] Red2 =
        {
            0.075000,
            0.150000,
            0.225000,
            0.300000,
            0.390000,
            0.480000,
            0.540000,
            0.600000,
            0.609091,
            0.618182,
            0.627273,
            0.636364,
            0.645455,
            0.654546,
            0.663636,
            0.670454,
            0.677272,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.082500,
            0.165000,
            0.247500,
            0.330000,
            0.429000,
            0.528000,
            0.594000,
            0.660000,
            0.660909,
            0.661818,
            0.662727,
            0.663636,
            0.664545,
            0.665454,
            0.665909,
            0.666591,
            0.667273,
            1.000000

        };
    }
}
