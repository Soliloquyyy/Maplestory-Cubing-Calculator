using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Secondary:Lines
    {
        public Secondary()
        {
            AvailLine1 = Secondary1;
            AvailLine2 = Secondary2;
            AvailLine3 = Secondary3;
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

        private readonly int[] Secondary1 =
        {
            11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
        };

        private readonly int[] Secondary2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
        };

        private readonly int[] Secondary3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
        };

        private readonly double[] Red1 =
        {
            0.085106,
            0.170212,
            0.255318,
            0.340424,
            0.382977,
            0.425530,
            0.468083,
            0.510636,
            0.574466,
            0.617019,
            0.659572,
            0.702125,
            0.744678,
            0.787231,
            1.000000
        };

        private readonly double[] Red2 =
        {
            0.084906,
            0.169812,
            0.254718,
            0.339624,
            0.390567,
            0.441510,
            0.509435,
            0.560378,
            0.628303,
            0.679246,
            0.730189,
            0.768406,
            0.776917,
            0.785428,
            0.793939,
            0.802450,
            0.806705,
            0.810960,
            0.815215,
            0.819470,
            0.825853,
            0.830108,
            0.834363,
            0.838618,
            0.842873,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.093396,
            0.186792,
            0.280188,
            0.373584,
            0.429622,
            0.485660,
            0.560377,
            0.616415,
            0.691132,
            0.747170,
            0.784528,
            0.822312,
            0.823163,
            0.824014,
            0.824865,
            0.825716,
            0.826142,
            0.826568,
            0.826994,
            0.827420,
            0.828058,
            0.828484,
            0.828910,
            0.829336,
            0.829762,
            1.000000
        };
    }
}
