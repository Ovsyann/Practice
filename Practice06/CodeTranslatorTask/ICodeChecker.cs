using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTranslator
{
    public interface ICodeChecker
    {
        bool CheckCodeSyntax(string evaluatedString, string languageName);
    }
}
