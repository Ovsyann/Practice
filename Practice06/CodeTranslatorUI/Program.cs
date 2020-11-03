using System;
using CodeTranslatorTask;
using IConvertible = CodeTranslatorTask.IConvertible;

namespace CodeTranslatorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IConvertible convertible1 = new ProgramConverter();
            IConvertible convertible2 = new ProgramHelper();
            IConvertible[] convertibles = { convertible1, convertible2 };
            string toCSharp = convertible2.ConvertToCsharp("VB");
            string toVB = convertible2.ConvertToVB("C#");


        }
    }
}
