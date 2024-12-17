using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace _19FileIOSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("");
            //string filePath = @"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\19FileIOSerialization\Files\Data.txt";
            //string filePath = @"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\19FileIOSerialization\Files\EmpData.txt";
            //string filePath = @"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\19FileIOSerialization\Files\EmpData.json";
            //string filePath = @"D:\IETCDAC\Dec24\IETCsharpDemos\CSharpDemos\19FileIOSerialization\Files\EmpData.xml";
            //Paper
            FileStream fs = null;

            #region Write Mode 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath,FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            ////Pen
            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("Enter something for Data.txt File");
            //string inputStr = Console.ReadLine();
            //writer.WriteLine(inputStr);
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done !"); 
            #endregion

            #region Read Mode 
            // if (File.Exists(filePath))
            // {
            //     fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            // }
            // else
            // {
            //     Console.WriteLine("File Does not exist....");
            // }
            // //Pen
            //StreamReader reader = new StreamReader(fs);
            // string outputStr =  reader.ReadToEnd();
            // reader.Close();

            // Console.WriteLine(outputStr);
            // fs.Close(); 
            #endregion

            #region Writing Emp Data in txt file 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            ////Pen
            //StreamWriter writer = new StreamWriter(fs);

            //Emp emp = new Emp();
            //Console.WriteLine("Enter Emp Id");
            //emp.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Emp NAme");
            //emp.Name =Console.ReadLine();
            //Console.WriteLine("Enter Emp Address");
            //emp.Address = Console.ReadLine();

            //writer.Write(emp);
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done !"); 
            #endregion

            #region Binary Serialization 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            //Emp emp = new Emp();
            //Console.WriteLine("Enter Emp Id");
            //emp.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Emp NAme");
            //emp.Name = Console.ReadLine();
            //Console.WriteLine("Enter Emp Address");
            //emp.Address = Console.ReadLine();

            ////Pen
            //// Serializes object data in Binary Format which is 
            ////MicroSoft own Syntax
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, emp);

            //fs.Close();
            //Console.WriteLine("Done !"); 
            #endregion

            #region Binary Deserialize
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File Does not exist....");
            //}
            ////Pen
            //BinaryFormatter bf = new BinaryFormatter();
            //Emp emp = bf.Deserialize(fs) as Emp;
            //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

            //fs.Close();
            #endregion

            #region JSON Serialization 

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            //Emp emp = new Emp();
            //Console.WriteLine("Enter Emp Id");
            //emp.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Emp NAme");
            //emp.Name = Console.ReadLine();
            //Console.WriteLine("Enter Emp Address");
            //emp.Address = Console.ReadLine();

            ////Pen
            //JsonSerializer.Serialize(fs, emp);

            //fs.Close();
            //Console.WriteLine("Done !"); 
            #endregion

            #region JSOn Deserializer 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File Does not exist....");
            //}
            ////Pen
            //Emp emp = JsonSerializer.Deserialize<Emp>(fs);
            //Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address = {emp.Address}");

            //fs.Close();
            #endregion

            #region XML Serializer 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //}
            //Emp emp = new Emp();
            //Console.WriteLine("Enter Emp Id");
            //emp.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Emp NAme");
            //emp.Name = Console.ReadLine();
            //Console.WriteLine("Enter Emp Address");
            //emp.Address = Console.ReadLine();

            //Book book = new Book();
            //book.BookName = "Let us C++";

            //ArrayList arr = new ArrayList();
            //arr.Add(emp);
            //arr.Add(book);

            ////Pen
            ////int i = 10;
            ////Console.WriteLine(i.GetType().ToString());
            ////Console.WriteLine(emp.GetType().ToString());
            //Type[] types = new Type[arr.Count];
            //types[0] = typeof(Emp);
            //types[1] = typeof(Book);
            //XmlSerializer xs = new XmlSerializer(typeof(ArrayList),types);
            //xs.Serialize(fs, arr);
            //fs.Close();
            //Console.WriteLine("Done !"); 
            #endregion

            #region XMl Deserializer 
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File Does not exist....");
            //}

            ////Pen
            //Type[] types = new Type[2];
            //types[0] = typeof(Emp);
            //types[1] = typeof(Book);
            //XmlSerializer xs = new XmlSerializer(typeof(ArrayList),types);
            //ArrayList arr = xs.Deserialize(fs) as ArrayList;
            //foreach (var item in arr)
            //{
            //    if(item is Emp)
            //    {
            //        Emp emp = item as Emp;
            //        Console.WriteLine($"Id = {emp.Id}, Name = {emp.Name}, Address ={emp.Address}");
            //    }
            //    if(item is Book)
            //    {
            //         Book book = item as Book;
            //        Console.WriteLine($"Book Name = {book.BookName}");
            //    }
            //}
            //fs.Close();
            #endregion
        }
    }
    public class Book
    {
        private string _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }

    }
    //Attributes
    //[Serializable]
    public class Emp
    {
        private int _EId;
        private string _EName;
        //[NonSerialized]
        private string _EAddress;

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

    }
}
