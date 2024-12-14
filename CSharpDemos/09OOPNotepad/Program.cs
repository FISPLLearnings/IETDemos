namespace _09OOPNotepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notepad notepad1 = new Notepad(null);

            SpellChekerFactory factory = new SpellChekerFactory();
           ISpellChecker someChecker= factory.GetSomeSpellChecker("gr");
            Notepad notepad2 = new Notepad(someChecker);
            notepad2.SpellCheck();


            //Notepad notepad1 = new Notepad("hindi");
            //HindiSpellChecker hindiChecker = new HindiSpellChecker();
            //Notepad notepad1 = new Notepad(hindiChecker);
            //notepad1.SpellCheck();
        }
    }
    public class Notepad
    {
        ISpellChecker _checker;
        SpellChekerFactory factory = new SpellChekerFactory();
        public Notepad(ISpellChecker checker)//Constructor Dependency Injection
        {
            if (checker == null)
            {
                _checker = factory.GetSomeSpellChecker("en");
            }
            else
            {
                _checker = checker;
            }
        }
        #region  lang based dependency 
        //ISpellChecker checker;
        //SpellChekerFactory factory = new SpellChekerFactory();
        //public Notepad(string lang)
        //{
        //    if (lang == null)
        //    {
        //        checker = factory.GetSomeSpellChecker("en");
        //    }
        //    else
        //    {
        //        checker = factory.GetSomeSpellChecker(lang);
        //    }
        //} 
        #endregion
        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
        public void Cut()
        {
            //some code here
        }
        public void Copy()
        {
            //some code here
        }
        public void Paste()
        {
            //some code here
        }
    }
    public interface ISpellChecker
    {
        void DoSpellCheck();
    }
    public class SpellChekerFactory
    {
        public ISpellChecker GetSomeSpellChecker(string lang)
        {
            ISpellChecker _checker = null;
            switch (lang)
            {
                case "en":
                    _checker = new EnglishSpellChecker();
                    break;
                case "gr":
                    _checker = new GermanSpellChecker();
                    break;
                case "sp":
                    _checker = new SpanishSpellChecker();
                    break;
                default:
                    _checker = new EnglishSpellChecker();
                    break;
            }
            return _checker;
        }
    }
    public class HindiSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //code here 
            Console.WriteLine("Hindi Spell Check Done");
        }
    }
    public class EnglishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //code here 
            //imagine huge code is here
            Console.WriteLine("English Spell Check Done");
        }
    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //code here 
            Console.WriteLine("German Spell Check Done");
        }
    }
    public class SpanishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            //code here 
            Console.WriteLine("SpanishSpell Check Done");
        }
    }
}
