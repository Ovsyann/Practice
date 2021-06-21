using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParsing.ArgumentMarshaler
{
    public class BoolArgumentMarshaler : IArgumentMarshaler
    {
        private bool value = false;

        public void Set(string currentArgument)
        {
            value = true;
        }

        public static bool GetValue(IArgumentMarshaler marshaler)
        {
            if (marshaler is null)
            {
                throw new ArgumentNullException(nameof(marshaler));
            }

            if(marshaler is BoolArgumentMarshaler)
            {
                return ((BoolArgumentMarshaler)marshaler).value;
            }

            return false;
        } 
    }
}
