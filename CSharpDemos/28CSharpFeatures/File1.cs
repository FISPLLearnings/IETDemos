using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28CSharpFeatures
{
    public class SuperBase
    {
        public void SayHi()
        {
            Console.WriteLine("Hello");
        }
    }
    public partial class CMath:SuperBase
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
