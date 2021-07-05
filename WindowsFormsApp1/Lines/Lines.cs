using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Lines  
    {
        public Lines() 
        {
            AvailLine1 = null;
            AvailLine2 = null;
            AvailLine3 = null;
        }
        public int[] AvailLine1 { get; protected set; }
        public int[] AvailLine2 { get; protected set; }
        public int[] AvailLine3 { get; protected set; }

        protected Dictionary<int, int[]> AvailLines;
        protected Dictionary<int, double[]> ProbabilityR;
        protected Dictionary<int, double[]> ProbabilityB;

        //Red Cubes
        public double[] ProbabilityR1 { get; protected set; }

        public double[] ProbabilityR2 { get; protected set; }

        public double[] ProbabilityR3 { get; protected set; }

        //Black Cubes
        public double[] ProbabilityB1 { get; protected set; }

        public double[] ProbabilityB2 { get; protected set; }

        public double[] ProbabilityB3 { get; protected set; }


        public int[] getAvailLines(int index)
        {
            if(AvailLines.Count != 0) return AvailLines[index];
            return null;
        }

        public double[] getProbabilityR(int index)
        {
            if (ProbabilityR.Count != 0) return ProbabilityR[index];
            return null;
        }

        public double[] getProbablityB(int index)
        {
            if (ProbabilityB.Count != 0) return ProbabilityB[index];
            return null;
        }
    }



}
