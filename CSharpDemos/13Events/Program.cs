using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace _13Events
{
    public delegate void ResultDelegate(int i);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            ResultDelegate resultPass = new ResultDelegate(student.OnSuccess);
            student.Pass += resultPass;

            ResultDelegate resultFail = new ResultDelegate(student.OnFailure);
            student.Fail += resultFail;

            Console.WriteLine("Enter marks of a student");
            student.Marks = Convert.ToInt32(Console.ReadLine());

        }
    }
    public class Student
    {
        public event ResultDelegate Pass;
        public event ResultDelegate Fail;

        private int _marks;
        public int Marks
        {
            set
            {
                _marks = value;
                if (_marks > 20)
                {
                    Pass(_marks);
                }
                else
                {
                    Fail(_marks);
                }
            }
            get
            {
                return _marks;
            }
        }

        public void OnSuccess(int marks)
        {
            Console.WriteLine("Congratulations ! you passes with {0} marks",marks);
        }
        public void OnFailure(int marks)
        {
            Console.WriteLine("Congratulations ! you failed with {0} marks", marks);
        }
    }
}
