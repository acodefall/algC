using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingc
{
    public class NumberSymbolCombo
    {
        /*
            Input is "123". We have to intersperse + and - among them 
            Like "1+2+3" 
			
			output:
            + 1 + 2 + 3 = 6
            + 1 + 2 - 3 = 0
            + 1 - 2 + 3 = 2
            + 1 - 2 - 3 = -4
            + 1 + 3 = 4
            + 1 - 3 = -2
            - 1 + 2 + 3 = 4
            - 1 + 2 - 3 = -2
            - 1 - 2 + 3 = 0
            - 1 - 2 - 3 = -6
            - 1 + 3 = 2
            - 1 - 3 = -4
            + 2 + 3 = 5
            + 2 - 3 = -1
            - 2 + 3 = 1
            - 2 - 3 = -5
            + 3 = 3
            - 3 = -3
         * 
         * 
         */
        public void callNumberSymbolCombo()
        {
            int[] data = { 1,2,3};
            int output = 0;
            string outputS = "";
            addSymbolToNumbers(data, 0, output, outputS);
        }

        void  addSymbolToNumbers(int[] src, int srcidx, int output, string outputS)
        {
            if(srcidx == src.Length)
            {
                Console.WriteLine(outputS + " = " + output);
                return;
            }

            //XYZ
            for(int i = srcidx; i < src.Length; i++)
            {
                string x = outputS;
                x += " + ";
                x += Convert.ToString(src[i]);
                addSymbolToNumbers(src, i+1, output + src[i], x);

                x = outputS;
                x += " - ";
                x += Convert.ToString(src[i]);
                addSymbolToNumbers(src, i + 1, output - src[i], x);
            }

        }
    }
}
