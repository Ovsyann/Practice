using System;
using CodeTranslator;
using IConvertible = CodeTranslator.IConvertible;

namespace CodeTranslatorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IConvertible[] convertibles = CreateArray();

            CodeConversion(convertibles);

        }

        private static void CodeConversion(IConvertible[] convertibles)
        {
            string code = "ANY_CODE";
            for (int i = 0; i < convertibles.Length; i++)
            {
                if (convertibles[i].GetType().Name == "ProgramConverter")
                {
                    Console.WriteLine(convertibles[i].ConvertToCsharp(code));
                    Console.WriteLine(convertibles[i].ConvertToVB(code));
                }
                else if (convertibles[i].GetType().Name == "ProgramHelper")
                {
                    Console.WriteLine(((ProgramHelper)convertibles[i]).ConvertToCsharp(code));
                    Console.WriteLine(((ProgramHelper)convertibles[i]).CheckCodeSyntax(code, "C#"));
                }
            }
        }

        private static IConvertible[] CreateArray()
        {
            IConvertible[] convertibles = new IConvertible[8];
            for(int i = 0; i < convertibles.Length; i++)
            {
                if (i < 4)
                {
                    convertibles[i] = new ProgramConverter();
                }
                else
                {
                    convertibles[i] = new ProgramHelper();
                }
            }

            return convertibles;
        }
    }
}
