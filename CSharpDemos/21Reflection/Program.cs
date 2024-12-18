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
                Type type = types[i]; //CMath

                object dynamicallyCreatedObject = asm.CreateInstance(type.FullName);

                MethodInfo[] allMethods = type.GetMethods();
                string methodSignature = null;
                for (int j = 0; j < allMethods.Length; j++)
                {
                    MethodInfo method = allMethods[j];
                    //int Add ( 
                    methodSignature = method.ReturnType + " " + method.Name + " ( ";
                    ParameterInfo[] allParameters = method.GetParameters();

                    object[] inputParameters = new object[allParameters.Length];

                    for (int k = 0; k < allParameters.Length; k++)
                    {
                        ParameterInfo param = allParameters[k];
                        //int Add ( int x, int y,
                        methodSignature = methodSignature + param.ParameterType.ToString() + " " +
                            param.Name + ",";
                    }
                    for (int m = 0; m < inputParameters.Length; m++)
                    {
                        Console.WriteLine("Enter values for {0} of type {1}",
                            allParameters[m].Name, allParameters[m].ParameterType.ToString());
                        object val = Convert.ChangeType(Console.ReadLine(), allParameters[m].ParameterType);
                        inputParameters[m] = val;
                    }

                    //int Add ( int x, int y )
                    methodSignature = methodSignature.TrimEnd(',') +" )";
                    Console.WriteLine(methodSignature);
                    object? result = type.InvokeMember(method.Name,
                                    BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,
                                    null,
                                    dynamicallyCreatedObject,
                                    inputParameters);
                    Console.WriteLine("Result of {0} = {1}",method.Name,result);
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
