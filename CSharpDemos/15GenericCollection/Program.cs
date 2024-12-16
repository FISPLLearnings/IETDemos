namespace _15GenericCollection
{
    //Generic Delegate
    public delegate R MyDelegate<T1,R>(T1 para1);
    //Overloaded Generic Delegate
    public delegate R MyDelegate<T1,T2,R>(T1 para1, T2 para2);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pass by ref , pass by value and out parameter 
            //CMath obj = new CMath();
            //int p = 10;
            //int q = 20;
            //Console.WriteLine("Before Swap : P ={0} , Q = {1}",p,q);

            ////to pass arguments to a method there are two ways:
            //// obj.Swap(p, q); //1. Pass by Value
            ////2. Pass by refernce
            //obj.Swap(ref p,ref q);
            //Console.WriteLine("After Swap : P ={0} , Q = {1}",p,q);

            ////out parameter
            //int sum, product;
            //obj.Calculate(2, 3,out sum,out product);
            //Console.WriteLine($"Sum :{sum} , Product:{product} "); 
            #endregion

            #region Generic Class , Dynamic Type 
            //CMath<int> obj = new CMath<int>();
            //int p = 10, q = 20;

            //Console.WriteLine("Before Swap : P ={0} , Q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap : P ={0} , Q = {1}", p, q);

            //Console.WriteLine("-----------------------------------");

            ////This is not allowed in Generic Class Type <int>
            ////string s1 = "abc", s2 = "pqr";
            ////Console.WriteLine("Before Swap : s1 ={0} , s2 = {1}", s1, s2);
            ////obj.Swap(ref s1, ref s2);
            ////Console.WriteLine("After Swap : s1 ={0} , s2 = {1}", s1, s2);

            //#region generic methods <> 
            ////Console.WriteLine("Before Swap : P ={0} , Q = {1}", p, q);
            ////obj.Swap<int>(ref p,ref q);
            ////Console.WriteLine("After Swap : P ={0} , Q = {1}", p, q);

            ////Console.WriteLine("-----------------------------------");

            ////string s1 = "abc", s2 = "pqr";
            ////Console.WriteLine("Before Swap : s1 ={0} , s2 = {1}", s1, s2);
            ////obj.Swap<string>(ref s1, ref s2);
            ////Console.WriteLine("After Swap : s1 ={0} , s2 = {1}", s1, s2); 
            //#endregion

            //int sum, product;
            //obj.Calculate(2, 3, out sum, out product);
            //Console.WriteLine($"Sum :{sum} , Product:{product} ");  
            #endregion

            #region Generic Multiple Parameters 
            //Demo<int,string,double,bool> demoObj= new Demo<int, string, double, bool> ();
            //double d = demoObj.Display(100, "some nonsense parameter", 23.333, true);
            //Console.WriteLine("R is holding value : {0}", d); 
            #endregion
        }
    }

    public class Demo<P,Q,R,T>
    {
        public R Display(P p1, Q p2, R p3, T p4)
        {
            return p3;
        }
    }
    public class Test<T1, T2, T3, T4>
    {
        public T3 Display(T1 p1, T2 p2, T3 p3, T4 p4)
        {
            return p3;
        }
    }
    public class CMath<T> //Generic Class
    {
        public void Swap(ref T x,ref T y) //Generic Method
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        //public void Swap(ref string x, ref string  y)
        //{
        //    string temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //}
        //pN MEthod(p1,p2,p3,p4....out bool/ int/Emp pN)
        public void Calculate(T x, T y,out T sum,out T product)
        {
            //dynamic type gets defination at runtime by CLR
            dynamic para1 = x;
            dynamic para2 = y;

            sum = para1 + para2;
            product = para1 * para2;
        }
    }
}
