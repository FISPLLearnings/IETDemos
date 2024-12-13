namespace _06OOPInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CMath obj =new CMath(); - not usefull in explicit implementation of Interface
            IX xObj = new CMath();
            xObj.Add(2, 3);
            xObj.Sub(3, 4);
            IY yObj = new CMath();
            yObj.Add(2, 3);
            yObj.Mult(3, 4);

            #region Old 
            //CMath obj = new CMath();
            //obj.Add(10, 20);
            //obj.Sub(10, 20);
            //obj.Mult(10, 20);

            //IX xObj = new CMath();
            //xObj.Add(10, 20);
            //IY yObj = new CMath();
            //yObj.Mult(10, 20); 
            #endregion
        }
    }
    public interface IX
    {
        void Add(int x, int y);
        void Sub(int x, int y);
    }
    public interface IY
    {
        void Add(int x, int y);
        void Mult(int x, int y);
    }
    public class CMath : IX, IY
    {
        void IX.Add(int x, int y)
        {
            int result = x + y;
            Console.WriteLine("IX Add = " + result);
        }

        void IY.Add(int x, int y)
        {
            int result = x + y + 100;
            Console.WriteLine("IY Add = " + result);
        }

        void IY.Mult(int x, int y)
        {
            int result = x * y * 2;
            Console.WriteLine("IY Mult = " + result);
        }

        void IX.Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("IX Sub = " + result);
        }
    }

    #region  Implicit way 
    //public class CMath : IX, IY
    //{
    //    public void Add(int x, int y)
    //    {
    //        int result = x + y;
    //        Console.WriteLine("Add = "+ result);
    //    }

    //    public void Mult(int x, int y)
    //    {
    //        int result = x * y;
    //        Console.WriteLine("Mult = " + result);
    //    }

    //    public void Sub(int x, int y)
    //    {
    //        int result = x - y;
    //        Console.WriteLine("Sub = " + result);
    //    }
    //} 
    #endregion
}
