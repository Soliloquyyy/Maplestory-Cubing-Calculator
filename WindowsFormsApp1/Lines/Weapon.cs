using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Weapon : Lines
    {
        public Weapon()
        {
            AvailLine1 = Weapon1;
            AvailLine2 = Weapon2;
            AvailLine3 = Weapon3;
            ProbabilityR1 = red1;
            ProbabilityR2 = red2;
            ProbabilityR3 = red3;

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

        private readonly int[] Weapon1 =
        {
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25
        };

        private readonly int[] Weapon2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
        };

        private readonly int[] Weapon3 =
        {
             0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
        };

        private readonly double[] red1 =
        {
            0.097561,
            0.195122,
            0.292683,
            0.390244,
            0.439024,
            0.487804,
            0.536584,
            0.585364,
            0.658535,
            0.707315,
            0.756095,
            0.804875,
            0.853655,
            0.902435,
            1.000000
        };

        private readonly double[] red2 =
        {
            0.100000,
            0.200000,
            0.300000,
            0.400000,
            0.460000,
            0.520000,
            0.600000,
            0.660000,
            0.740000,
            0.800000,
            0.860000,
            0.904878,
            0.914634,
            0.924390,
            0.934146,
            0.943902,
            0.948780,
            0.953658,
            0.958536,
            0.963414,
            0.970731,
            0.975609,
            0.980487,
            0.985365,
            0.990243,
            1.000000
        };

        private readonly double[] red3 = {
            0.110000,
            0.220000,
            0.330000,
            0.440000,
            0.506000,
            0.572000,
            0.660000,
            0.726000,
            0.814000,
            0.880000,
            0.946000,
            0.990878,
            0.991854,
            0.992830,
            0.993806,
            0.994782,
            0.995270,
            0.995758,
            0.996246,
            0.996734,
            0.997466,
            0.997954,
            0.998442,
            0.998930,
            0.999418,
            1.000000
        };
    }
}
