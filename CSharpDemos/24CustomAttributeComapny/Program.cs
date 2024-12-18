using _22CompanyInfoLib;
using System.Reflection;

namespace _24CustomAttributeComapny
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = @"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\23DemoLib\bin\Debug\net6.0\23DemoLib.dll";
            Assembly asm = Assembly.LoadFrom(assemblyPath);
            Type [] types = asm.GetTypes();
            for (int i = 0; i < types.Length; i++) 
            {
                Type type = types[i];
                Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if(attr is Company)
                    {
                        Company companyRef =  attr as Company;
                        Console.WriteLine("Type {0} is belongs to {1} company and is Developed by {2} developer",
                                            type.FullName,companyRef.CompanyName, companyRef
                                            .DeveloperName);
                    }
                }
            }
        }
    }
}
