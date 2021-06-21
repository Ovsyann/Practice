using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ArgumentParsing
{
    internal class ArgsException : Exception
    {
        private readonly char errorArgumentId = '\0';
        private readonly string errorParameter = null;
        private readonly ErrorCode errorCode = ErrorCode.Ok;

        public char ErrorArgumentId => errorArgumentId;

        public string ErrorParameter => errorParameter;

        internal ErrorCode ErrorCode => errorCode;

        public ArgsException()
        {
        }

        public ArgsException(ErrorCode code)
        {
            errorCode = code;
        }

        public ArgsException(ErrorCode code, string errorParameter)
        {
            errorCode = code;
            this.errorParameter = errorParameter;
        }

        public ArgsException(ErrorCode code, char errorArgumentId, string errorParameter)
        {
            errorCode = code;
            this.errorArgumentId = errorArgumentId;
            this.errorParameter = errorParameter;
        }

        public string GetErrorMessage()
        {
            switch (this.ErrorCode)
            {
                case ErrorCode.Ok:
                    return "TILT: Should not be here.";
                case ErrorCode.MissingString:
                    return string.Format("Could not find string parameter for {0}", ErrorArgumentId);
                case ErrorCode.MissingInteger:
                    return string.Format("Could not find integer parameter for {0}", ErrorArgumentId);
                case ErrorCode.InvalidInteger:
                    return string.Format("Argument -{0} expects an integer but was '{1}'.", ErrorArgumentId, ErrorParameter);
                case ErrorCode.InvalidDouble:
                    return string.Format("Argument -{0} expects a double but was '{1}'.", ErrorArgumentId, ErrorParameter);
                case ErrorCode.MissingDouble:
                    return string.Format("Could not find doublie parameter for {0}", ErrorArgumentId);
                case ErrorCode.InvalidArgumentName:
                    return string.Format("'{0}' is not a valid argument name", ErrorArgumentId);
                case ErrorCode.InvalidArgumentFormat:
                    return string.Format("'{0}' is not a valid argument format", ErrorParameter);
                case ErrorCode.UnexpectedArgument:
                    return string.Format("Argument -{0} expected.", ErrorArgumentId);
                default:
                    return "";
            }
        }

        public ArgsException(string message) : base(message)
        {

        }

        public ArgsException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected ArgsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
