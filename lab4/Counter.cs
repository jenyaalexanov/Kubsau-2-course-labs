using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Counter
    {
        public int State { get; private set; }
        int FromDp;
        int ToDp;
        public string error;

        public Counter()
        {
            this.State = 7;
            this.ToDp = 5;
            this.FromDp = 20;
        }

        public Counter(int x, int MinValue, int MaxValue)
        {
            int T = Math.Min(MinValue, MaxValue);
            if (T != MinValue)
            {
                MaxValue = MinValue;
                MinValue = T;
            }
            
            if (x < MinValue || x > MaxValue)
            {
                this.State = MinValue;
            }
            else
            {
                this.State = x;
            }
            this.ToDp = MinValue;
            this.FromDp = MaxValue;
        }

        

        public void Increment()
        {
            this.State++;
            if (this.State > this.FromDp)
            {
                this.State = this.FromDp;
                throw new Exception("Провышено допустимое значение");
            }
        }

        public void Decrement()
        {
            this.State--;
            if (this.State < this.ToDp)
            {
                this.State = this.ToDp;
                throw new Exception("Превышено допустимое значение");
            }
        }

        public string DecToHex()
        {
            string result = string.Empty;
            var num = this.State;
            int[] divs = new int[20];
            int i = 0, j = 0;
            while (num > 0)
            {
                divs[i] = num % 16;
                num = num / 16;
                i++;
                j++;
            }

            for (i = j - 1; i >= 0; i--)
            {
                if (divs[i] > 9)
                {
                    result = string.Format("{0}{1}", result, 
                        (char)((divs[i] - 10) + 'A'));
                }
                else
                {
                    result = string.Format("{0}{1}",
                        result, divs[i].ToString());
                }
            }
            return result;
        }
    }
}
