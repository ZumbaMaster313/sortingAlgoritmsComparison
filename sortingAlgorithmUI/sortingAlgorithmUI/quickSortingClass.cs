using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingAlgorithmUI
{
    class quickSortingClass
    {
        string num;
        string answer;
        string[] result = new string[] { };
        public string Answer
        {
            get
            {
                return answer;
            }
            set
            {
                num = answer;
            }
        }
        public void QuickSorter(int[] bArray)
        {
            int numberHolder = 0;
            for (int i = 0; i < bArray.Length; i++)
            //increments through passes of a loop
            {
                for (int j = 0; j < bArray.Length; j++)
                // the sorting loop foreach pass
                {
                    if (bArray[i] < bArray[j])
                    {
                        numberHolder = bArray[i];
                        //puts the greater number into a place holder

                        bArray[i] = bArray[j];

                        bArray[j] = numberHolder;
                        //swaps the greater number into the place of smaller
                    }

                }
            }
            string seperator = ", ";
            result = bArray.Select(x => x.ToString()).ToArray();
            answer = string.Join(seperator, result);
        }
    }
}
