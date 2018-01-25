using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var parallelQuery = ParallelEnumerable.Range(0, 100);
            foreach (var item in parallelQuery.ToList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
