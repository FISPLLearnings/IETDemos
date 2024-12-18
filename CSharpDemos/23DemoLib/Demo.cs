using _22CompanyInfoLib;

namespace _23DemoLib
{
    [Serializable]
    [Company(CompanyName ="FISPL",DeveloperName ="Mugdha Panhale")]
    public class Demo
    {
        public void SayHi()
        {
            Console.WriteLine("Hello...");
        }
    }
}
