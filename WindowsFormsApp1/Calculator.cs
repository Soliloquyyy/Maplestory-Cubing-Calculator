using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Calculator
    {
        public Lines lines { get; set; }
        public Item item { get; set; }

        public uint trials { get; set; }

        public ProgressBar progressBar { get; set; }
        public int[] desiredIndexArr { get; set; }

        private readonly ulong RedCubeCost = 12000000;
        private Random random = new Random();
        public ulong Simulate()
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

            progressBar.Minimum = 1;
            progressBar.Maximum = (int) trials;
            progressBar.Value = 1;
            progressBar.Step = 1;

            for(int i = 0; i < trials; ++i)
            {                
                bool finished = false;
                ulong iterations = 0;
                while(!finished)
                { 
                    Dictionary<string,int> matchLines = new Dictionary<string, int>();
                    List<string> temp = new List<string>(desiredLines);
                    List<int> match = new List<int>();
                    for (int j = 0; j < 3; ++j)
                    {                        
                        match.Add(this.simulateProbabilityR(j));
                        int[] lineArr = lines.getAvailLines(j);
                        int lineIndex = lineArr[match[j]];
                        string[] availLines = this.item.getLines();


                        if (matchLines.ContainsKey(availLines[lineIndex]))
                        {
                            matchLines[availLines[lineIndex]]++;
                        }
                        else
                        {
                            matchLines.Add(availLines[lineIndex], 1);
                        }
                    }

                    int fillCount = 0;
                    while(temp.Count > 0)
                    {
                        string firstStr = temp.First();
                        if (matchLines.ContainsKey(firstStr) && firstStr != "FILL")
                        {
                            matchLines[firstStr]--;
                            if(matchLines[firstStr] == 0)
                            {
                                matchLines.Remove(firstStr);
                            }
                        }

                        //int retIndex = matchLines.IndexOf(temp.First());
                        //if (retIndex != -1)
                        //{
                        //    matchLines.RemoveAt(retIndex);
                        //}


                        if(temp.First() == "FILL")
                        {
                            ++fillCount;
                        }
                        temp.RemoveAt(0);
                    }



                    if (matchLines.Count - fillCount == 0) finished = true;
                    ++iterations;
                }

                checked{
                    totalCost += (iterations * RedCubeCost);
                }

                progressBar.PerformStep();          
            }
            return totalCost/trials;
        }

        private int simulateProbabilityR(int dictIndex)
        {

            double prob = random.NextDouble();

            double[] probabilityArr = lines.getProbabilityR(dictIndex);

            int selectedIndex = -1;
            for (int i = 0; i < probabilityArr.Length; ++i)
            {
                if (prob <= probabilityArr[i])
                {
                    selectedIndex = i;
                    break;
                }
            }

            return selectedIndex;
        }
    }
}
