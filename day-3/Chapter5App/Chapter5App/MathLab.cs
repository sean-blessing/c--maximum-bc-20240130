using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5App {
    internal static class MathLab {
        public static void DoMath() {
            Console.WriteLine("Do math!");
            decimal sum = 0;
            int i = 0;
            for (i = 1;  i <= 75; i++) {
                double denom = Math.Pow(2, i);
                decimal num1 = 1.0m / (decimal)denom;
                //Console.WriteLine($"num1 = {num1}");
                sum += num1;
                Console.WriteLine($"{denom}, sum: {sum}");
            }

        }
    }
}
