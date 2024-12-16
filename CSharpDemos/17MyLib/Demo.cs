namespace _17MyLib
{
    public class Demo
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Addition = {0}", x+y);
        }
        private void Sub(int x, int y)
        {
            Console.WriteLine("Sub = {0}", x - y);
        }
        protected void Mult(int x, int y)
        {
            Console.WriteLine("Mult = {0}", x * y);
        }
        protected internal void Div(int x, int y)
        {
            Console.WriteLine("Div = {0}", x / y);
        }
        internal void Square(int x)
        {
            Console.WriteLine("Square = {0}", x * x);
        }
    }
}
