using System.Reflection;

namespace _21Reflection
{
    internal class Program
    {
        // System.Int32 Add ( System.Int32 x, System.Int32 y)
        static void Main(string[] args)
        {
            string assemblyPath = @"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\20CMathLib\bin\Debug\net6.0\20CMathLib.dll";
            Assembly asm = Assembly.LoadFrom(assemblyPath);
            Type[] types = asm.GetTypes();
            #region Name, Full Name of Assembly Type 
            //string firstTypeFromAssembly = types[0].Name;
            //Console.WriteLine(firstTypeFromAssembly);
            //string firstTypeFromAssemblyFullName = types[0].FullName;
            //Console.WriteLine(firstTypeFromAssemblyFullName); 
            #endregion

            for (int i = 0; i < types.Length; i++)
            {
                Type type = types[i];
                MethodInfo[] allMethods = type.GetMethods();
                string str = null;
                for (int j = 0; j < allMethods.Length; j++)
                {
                    MethodInfo method = allMethods[j];
                    str = method.ReturnType + " " + method.Name + " ( ";
                    ParameterInfo[] allParameters = method.GetParameters();
                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo param = allParameters[k];
                        str = str + param.ParameterType.ToString() + " " +
                            param.Name + ",";
                    }
                    str = str.TrimEnd(',') +" )";
                    Console.WriteLine(str);
                }

               Attribute [] allAttributes= type.GetCustomAttributes().ToArray();
                for (int j = 0; j < allAttributes.Length; j++)
                {
                    Attribute attr = allAttributes[j];
                    if(attr is SerializableAttribute)
                    {
                        Console.WriteLine($"Type: {type.Name} class is Serializable");
                    }
                }
            }

        }
    }
}
