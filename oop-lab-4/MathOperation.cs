using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab_4
{
    public static class MathOperation
    {
        public static int FindMin(Queue<int> queue)
        {
            int min = queue.MasOfValue[0];

            for (int i = 0; i < queue.Size; i++)
            {
                if (min > queue.MasOfValue[i])
                {
                    min = queue.MasOfValue[i];
                }
            }
            return min;
        }
        public static int FindMax(Queue<int> queue)
        {
            int max = queue.MasOfValue[0];

            for (int i = 0; i < queue.Size; i++)
            {
                if (max < queue.MasOfValue[i])
                {
                    max = queue.MasOfValue[i];
                }
            }
            return max;
        }
        public static int Size(Queue<int> queue)
        {
            return queue.Size;
        }

        public static int TheFirstNumberInTheString(this string str)
        {
            int number=0;
            string helpString="";
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]>='0' && str[i]<='9')
                {
                    do
                    {
                        helpString += str[i];
                        i++;
                    }
                    while (str[i] >= '0' && str[i] <= '9');
                    break;
                }
                
            }
            if (int.TryParse(helpString, out number))
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        public static void ZeroingOfNegativeItemsInTheQueue(this Queue<int> queue)
        {
            for(int i=0;i<queue.Size;i++)
            {
                if(queue.MasOfValue[i]<0)
                {
                    queue.MasOfValue[i] = 0;
                }
            }
        }


    }
}
