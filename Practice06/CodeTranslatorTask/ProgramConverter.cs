using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTranslator
{
    public class ProgramConverter : IConvertible
    {
        public string ConvertToCsharp(string code)
        {
            return "Converted to C#";
        }

        public string ConvertToVB(string code)
        {
            return "Converted to VB";
        }
    }
}
