using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTranslatorTask
{
    public interface ICodeChecker
    {
        bool CheckCodeSyntax(string evaluatedString, string languageName);
    }
}
