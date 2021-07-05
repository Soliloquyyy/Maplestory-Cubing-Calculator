using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Calculator
    {
        public Lines lines { get; set; }
        public Item item { get; set; }

        public int[] desiredIndexArr { get; set; }

        private readonly ulong RedCubeCost = 12000000;

        public double Simulate()
        {
            List<string> desiredLines = new List<string>();
            for (int i = 0; i < 3; ++i)
            {
                int[] lineArr = lines.getAvailLines(i);
                string[] availLines = this.item.getLines();
                int lineIndex = lineArr[desiredIndexArr[i]];
                desiredLines.Add(availLines[lineIndex]);
            }

            ulong totalCost = 0;
            uint count = 1000;
            for(int i = 0; i < count; ++i)
            {                
                bool finished = false;
                ulong iterations = 0;
                while(!finished)
                {
                    List<string> matchLines = new List<string>();
                    List<string> temp = new List<string>(desiredLines);
                    List<int> match = new List<int>();
                    for (int j = 0; j < 3; ++j)
                    {                        
                        match.Add(this.simulateProbabilityR(j));
                        int[] lineArr = lines.getAvailLines(j);
                        int lineIndex = lineArr[match[j]];
                        matchLines.Add(this.item.getLines()[lineIndex]);
                    }

                    int fillCount = 0;
                    while(temp.Count > 0)
                    {
                        int retIndex = matchLines.IndexOf(temp.First());
                        if (retIndex != -1)
                        {
                            matchLines.RemoveAt(retIndex);
                        }
                        if(temp.First() == "FILL")
                        {
                            ++fillCount;
                        }
                        temp.RemoveAt(0);
                    }



                    if (matchLines.Count - fillCount == 0) finished = true;
                    ++iterations;
                }

                totalCost += (iterations * RedCubeCost);
            }
            return totalCost/count;
        }



        private int simulateProbabilityR(int dictIndex)
        {
            Random random = new Random();
            double prob = random.NextDouble();

            double[] probabilityArr = lines.getProbabilityR(dictIndex);

            int selectedIndex = -1;
            for (int i = 0; i < probabilityArr.Length; ++i)
            {
                if(prob < probabilityArr[i])
                {
                    selectedIndex = i;
                    break;
                }
            }

            return selectedIndex;
        }
    }
}
