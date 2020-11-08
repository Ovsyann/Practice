using System;

namespace CodeTranslator
{
    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string evaluatedString, string languageName)
        {
            return true;
        }

        public new string ConvertToCsharp(string code)
        {
            return "Converted to C#";
        }

        public new string ConvertToVB(string code)
        {
            return "Converted to VB";
        }
    }
}
