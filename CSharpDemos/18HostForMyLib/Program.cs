using _17MyLib;

namespace _18HostForMyLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Add(10, 20);
            MyClass obj2 =new MyClass();
            obj2.Add(100, 200);
            obj2.WrapperMEthodForBase();
        }
    }
    public class MyClass:Demo
    {
        public void WrapperMEthodForBase()
        {
            base.Mult(4, 4);
            base.Div(15, 5);
        }
    }
}
