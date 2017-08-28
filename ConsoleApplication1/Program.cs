using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string GetAgeEvaluation(int age)
        {
            if (age >= 0 && age <= 20)
            { return "baby"; }
            else if (age > 20 && age <= 100)
            { return "adult"; }
            else if (age < 0)
            { throw new Exception("Are you human?"); } //抛出程序自定义的异常
            else
            { throw new Exception("Do u live too long?"); }
        }
    }
}
