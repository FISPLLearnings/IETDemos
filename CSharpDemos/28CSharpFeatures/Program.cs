namespace _28CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Classes 
            CMath obj = new CMath();
            Console.WriteLine($"Add ={obj.Add(10, 20)} ");
            Console.WriteLine($"Sub ={obj.Sub(10, 20)} ");
            obj.SayHi();
            #endregion
        }
    }
}
