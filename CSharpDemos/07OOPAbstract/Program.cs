namespace _07OOPAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region solution 1
            //PDF pObj = new PDF();
            //pObj.ParsePDF();
            //pObj.ValidatePDF();
            //pObj.SavePDF();
            //Docx dObj = new Docx();
            //dObj.SaveDocx();
            //dObj.ValidateDocx();
            //dObj.ParseDocx(); 
            #endregion

            #region solution 2 
            //PDF pObj = new PDF();
            //pObj.GenerateReport();
            //Docx dObj =new Docx();
            //dObj.GenerateReport(); 
            #endregion

            while (true) 
            {
                Console.WriteLine("Tell us what do you want: 1.PDF, 2.DOCX, 3.TXT, 4. XML");
                int choice = Convert.ToInt32(Console.ReadLine());
                ReportFactory reportFactory = new ReportFactory();
               IReport  someReport = reportFactory.GetSomeReport(choice);
                someReport.GenerateReport();
                Console.WriteLine("DO you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if(ynChoice == "n")
                {
                    break;
                }
            }
        }
    }
    public interface IReport
    {
        void GenerateReport();
    }
    public abstract class Report :IReport
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
        }
    }
    public abstract class SpecialReport :Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }
    public class ReportFactory
    {
        public Report GetSomeReport(int choice)
        {
            Report report = null;
            switch (choice)
            {
                case 1:
                     report = new PDF();
                    break;
                case 2:
                    report = new Docx();
                    break;
                case 3:
                    report = new TXT();
                    break;
                case 4:
                    report = new XML();
                    break;
                default:
                    report = null;
                    break;
            }
            return report;

        }
    }
    public class PDF : Report
    {
        protected override void Parse()
        {
            //500lines code here
            Console.WriteLine("PDF Parsed.");
        }
        protected override void Validate()
        {
            //500lines code here
            Console.WriteLine("PDF Validated.");
        }
        protected override void Save()
        {
            //500lines code here
            Console.WriteLine("PDF Saved.");
        }
    }
    public class Docx : Report
    {
        protected override void Parse()
        {
            //500lines code here
            Console.WriteLine("Docx Parsed.");
        }
        protected override void Validate()
        {
            //500lines code here
            Console.WriteLine("Docx Validated.");
        }
        protected override void Save()
        {
            //500lines code here
            Console.WriteLine("Docx Saved.");
        }
    }
    public class TXT : Report
    {
        protected override void Parse()
        {
            //500lines code here
            Console.WriteLine("TXT Parsed.");
        }

        protected override void Save()
        {
            //500lines code here
            Console.WriteLine("TXT Saved.");
        }

        protected override void Validate()
        {
            //500lines code here
            Console.WriteLine("TXT Validated.");
        }
    }
    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            //500lines code here
            Console.WriteLine("XML Parsed.");
        }

        protected override void Validate()
        {
            //500lines code here
            Console.WriteLine("XML Validated.");
        }
        protected override void ReValidate()
        {
            //500lines code here
            Console.WriteLine("XML ReValidated.");
        }
        protected override void Save()
        {
            //500lines code here
            Console.WriteLine("XML Saved.");
        }
        
    }
}
