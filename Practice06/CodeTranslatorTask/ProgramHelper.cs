using System;

namespace CodeTranslatorTask
{
    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string evaluatedString, string languageName)
        {
            return true;
        }
    }
}
