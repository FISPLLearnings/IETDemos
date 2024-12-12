namespace _04OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CMAth Add 
            //CMath cmath = new CMath();
            //Console.WriteLine("Enter first no");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second no");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int result = cmath.Add(x, y);
            //Console.WriteLine("Add = " + result.ToString()); 
            #endregion

            #region AdvMath obj 
            //AdvMath advmath = new AdvMath(10, 20);
            //Console.WriteLine(advmath.Square(5));
            //Console.WriteLine(advmath.AdvClassAdd(5, 5)); 
            #endregion
        }
    }
    public class Demo1
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hello");
        }
        public virtual void Greet()
        {
            Console.WriteLine("Hello World!");
        }
        public void SayBye()
        {
            Console.WriteLine("Bye");
        }
    }
    public class Demo2 :Demo1
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi Divyansh!");
        }
        //Shadowing 
        public new void SayBye()
        {
            Console.WriteLine("Bye Divyansh!");
        }
    }

    public class CMath
    {
        private int _num1;
        public CMath()
        {

        }
        public CMath(int para1)
        {
            _num1 = para1;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    public class AdvMath : CMath
    {
        private int num2;
        public AdvMath()
        {

        }
        public AdvMath(int num2, int para) : base(para)
        {
            this.num2 = num2;
        }
        public int Square(int x)
        {
            return x * x;
        }
        public int Sub(int x, int y, int p)
        {
            return (x - y) * p;
        }

        //Wrapper Methods
        public int AdvClassAdd(int x, int y)
        {
            int result = base.Add(x, y);
            return result;
        }
        public  virtual  void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }

    public class MyClass : AdvMath
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
