using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Triplet
    {
        int a;
        int b;
        int c;

        public List<int> Values { get; private set; }

        public Triplet(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Values = new List<int>() { a, b, c };
        }
        public int Sum
        {
            get
            {
                return a + b + c;
            }
        }
    }
    class Problem39
    {
        List<Triplet> tripDict = new List<Triplet>();
        public int GetResult()
        {

            int p = 0;
            for (int i = 1; i < 998; i++)
            {
                for (int j = 1; j < 998; j++)

                {
                    for (int k = 1; k < 998; k++)
                    {
                        if (i + j + k > 1000)
                            continue;
                        else
                        {
                            if (IsPythagoreanTriplet(i, j, k))
                            {
                                if (!tripDict.Any(x_ => x_.Values.Contains(i) && x_.Values.Contains(j) && x_.Values.Contains(k)))
                                {
                                    Triplet trip = new Triplet(i, j, k);
                                    tripDict.Add(trip);
                                }
                                   
                            }
                        }
                    }
                }
            }
            var groups = tripDict.GroupBy(x_ => x_.Sum).Select(x_ => new
            {
                Key = x_.Key,
                Count = x_.Count()
            });

            var max = groups.Max(x_ => x_.Count);

            return groups.Where(x_ => x_.Count == max).Select(x_ => x_.Key).First();
        }

        public bool IsPythagoreanTriplet(int a, int b, int c)
        {
            var max = a > b ? a > c ? a : c : b > c ? b : c;

            return a * a + b * b + c * c - (2 * max * max) == 0;

        }
    }

}
