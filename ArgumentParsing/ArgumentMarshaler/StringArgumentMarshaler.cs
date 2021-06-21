using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ArgumentParsing.Args;

namespace ArgumentParsing.ArgumentMarshaler
{
    class StringArgumentMarshaler : IArgumentMarshaler
    {
        private string value = "";

        public void Set(string currentArgument)
        {
            value = currentArgument;
        }

        public static string GetValue(IArgumentMarshaler marshaler)
        {
            if (marshaler is null)
            {
                throw new ArgumentNullException(nameof(marshaler));
            }

            if (marshaler is StringArgumentMarshaler)
            {
                return ((StringArgumentMarshaler)marshaler).value;
            }

            return "";
        }
    }
}
