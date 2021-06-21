using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParsing.ArgumentMarshaler
{
    class IntArgumentMarshaler : IArgumentMarshaler
    {
        private int value = 0;

        public void Set(string currentArgument)
        {
            
            try
            {
                value = int.Parse(currentArgument);
            }
            catch (FormatException)
            {
                throw new ArgsException(ErrorCode.InvalidInteger);
            }

        }

        public int Value => value;
    }
}
