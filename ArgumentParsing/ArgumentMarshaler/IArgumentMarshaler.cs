using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParsing.ArgumentMarshaler
{
    public interface IArgumentMarshaler
    {
        void Set(string currentArgument);
    }
}
