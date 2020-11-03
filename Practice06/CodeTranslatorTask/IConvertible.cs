using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTranslatorTask
{
    public interface IConvertible
    {
        string ConvertToCsharp(string code);

        string ConvertToVB(string code);

    }
}
