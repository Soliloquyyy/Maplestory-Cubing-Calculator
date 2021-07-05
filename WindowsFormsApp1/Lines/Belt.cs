using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Belt : Lines 
    {
        public Belt()
        {
            AvailLine1 = Belt1;
            AvailLine2 = Belt2;
            AvailLine3 = Belt3;
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

        private readonly int[] Belt1 =
        {
            7,8,9,10,11,12,13
        };

        private readonly int[] Belt2 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };

        private readonly int[] Belt3 =
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
        };

        private readonly double[] Red1 =
        {
            0.108108,
            0.216216,
            0.324324,
            0.432432,
            0.540540,
            0.648648,
            0.729729,
            1.000000

        };

        private readonly double[] Red2 =
        {
            0.086538,
            0.173076,
            0.259614,
            0.346152,
            0.449998,
            0.553844,
            0.623075,
            0.633886,
            0.644697,
            0.655508,
            0.666319,
            0.677130,
            0.687941,
            0.696049,
            1.000000

        };

        private readonly double[] Red3 =
        {
            0.095192,
            0.190384,
            0.285576,
            0.380768,
            0.494999,
            0.609230,
            0.685384,
            0.686465,
            0.687546,
            0.688627,
            0.689708,
            0.690789,
            0.691870,
            0.692681,
            1.000000

        };
    }
}
