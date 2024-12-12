namespace _03BasicsandDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Boxing , unboxing, type casting 
            //int x = 100; // value type
            //bool isActive=false;

            ////reference type
            //string str = "abc";// String str = new String();

            //str = x.ToString(); //Boxing 
            //int y = Convert.ToInt32(str); //Unboxing
            //int p = x; // 
            //double d = 23.33;
            //x =Convert.ToInt32(d);

            //Object obj = new object();
            //obj = x;// Boxing
            //obj = str;// Type Casting
            //obj = d;// Boxing

            //double d1 = Convert.ToDouble(obj);// 
            #endregion

            #region Loops

            #region if - else 
            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 10) 
            //{
            //    Console.WriteLine("Number is greater than 10");
            //}
            //else if(num <30)
            //{
            //    Console.WriteLine("Number is less than 30 and greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("unknown number");
            //} 
            #endregion

            #region for
            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #endregion
            #region Exception Handling 
            //try
            //{
            //    Console.WriteLine("Enter first number:");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    if(x >10)
            //    {
            //        throw new Exception("x can not be grater than 10");
            //    }
            //    Console.WriteLine("Enter second number:");
            //    int y = Convert.ToInt32(Console.ReadLine());

            //    int result = x / y;
            //    Console.WriteLine("Div  = " + result.ToString());
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block...");
            //} 
            #endregion

            #region Add result op 
            //int addition = x + y;
            //Console.WriteLine("Addition = " + addition.ToString()); 
            #endregion

            #region Input in boolean format 
            ////ctr + k + c - commenting - ctr + /
            ////ctr + k + u - uncommenting
            //Console.WriteLine("true or flase");
            //bool isActive = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("is active  = "+ isActive); 
            #endregion

        }
    }
}
