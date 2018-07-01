using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem41
    {
        public long GetResult()
        {
            List<long> panDigitals = new List<long>();
            Parallel.ForEach(Enumerable.Range(2143, (int)Math.Pow(10, 10) - 2143), (i) =>
                 {
                     if (!i.ToString().Contains('0'))
                     {

                         if (!IsComposite(i) && IsPanDigital(i))
                         {
                             Console.WriteLine(i);
                             panDigitals.Add(i);
                         }
                     }
                 });
            
            return panDigitals.Max();
        }
        public bool IsPanDigital(long n)
        {
            if(n.ToString().Length < 9 && !n.ToString().Contains('0'))
            {
                return n.ToString().ToCharArray().Where(x_ => x_ -48 <= n.ToString().Length).Distinct().Count() == n.ToString().ToCharArray().Length;
            }
            return false;   
        }

        public bool IsComposite(long n)
        {
            for (long i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
    }
}
