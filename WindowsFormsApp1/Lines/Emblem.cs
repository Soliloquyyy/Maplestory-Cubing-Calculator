using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Emblem : Lines
    {
        public Emblem()
        {
            AvailLine1 = Emblem1;
            AvailLine2 = Emblem2;
            AvailLine3 = Emblem3;
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

        private readonly int[] Emblem1 =
        {
            10,11,12,13,14,15,16,17,18,19,20,21
        };

        private readonly int[] Emblem2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21
        };

        private readonly int[] Emblem3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21
        };

        private readonly double[] Red1 =
        {
            0.114286,
            0.228572,
            0.342858,
            0.457144,
            0.514287,
            0.571430,
            0.628573,
            0.685716,
            0.771430,
            0.828573,
            1.000000
        };

        private readonly double[] Red2 = {
            0.112500,
            0.225000,
            0.337500,
            0.450000,
            0.517500,
            0.585000,
            0.675000,
            0.742500,
            0.832500,
            0.900000,
            0.911429,
            0.922858,
            0.934287,
            0.945716,
            0.951430,
            0.957144,
            0.962858,
            0.968572,
            0.977143,
            0.982857,
            0.988571,
            1.000000
        };

        private readonly double[] Red3 =
        {
            0.123750,
            0.247500,
            0.371250,
            0.495000,
            0.569250,
            0.643500,
            0.742500,
            0.816750,
            0.915750,
            0.990000,
            0.991143,
            0.992286,
            0.993429,
            0.994572,
            0.995143,
            0.995714,
            0.996285,
            0.996856,
            0.997713,
            0.998284,
            0.998855,
            1.000000
        };
    }
}
