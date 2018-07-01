using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*  It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

  9 = 7 + 2×1^2
  15 = 7 + 2×2^2
  21 = 3 + 2×3^2
  25 = 7 + 2×3^2
  27 = 19 + 2×2^2
  33 = 31 + 2×1^2

  It turns out that the conjecture was false.

  What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?*/
    class Problem46
    {
        public int GetResult()
        {
            List<long> squares = new List<long>() { 1 };
            List<int> primes = new List<int>();
            int i = 2;
            while (true)
            {
                if (i % 2 == 1)
                {
                    if (IsComposite(i))
                    {

                        for (int j = 0; j < primes.Count; j++)
                        {
                            if (squares.Contains((i - primes[j]) / 2))
                            {
                                break;
                            }
                            if (j == primes.Count - 1)
                            {
                                return i;
                            }
                        }
                    }
                    else
                    {
                        primes.Add(i);
                    }
                }

                squares.Add(i * i);
                i++;
            }
        }


        public bool IsComposite(int n)
        {
            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
    }
}
