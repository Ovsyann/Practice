using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace ExceptionRegeneration
{
    [Guid("936DA01F-9ABD-4d9d-80C7-02AF85C822A8")]
    class BaseException : ApplicationException
    {
        public Guid Guid { get; set; }
        public Version NetVersion { get; set; }
        public string ConstructorName { get; set; }

        public BaseException() : base("BaseException thrown")
        {
            InitializeProperties();
        }

        private void InitializeProperties()
        {
            GuidAttribute attribute = (GuidAttribute)Attribute.GetCustomAttribute(typeof(BaseException), typeof(GuidAttribute));
            Guid = new Guid(attribute.Value);
            NetVersion = new Version();
            Type type = typeof(BaseException);
            ConstructorInfo constructorInfo = type.GetConstructor(new Type[0]);
            ConstructorName = constructorInfo.Name;
            Data.Add("Created", DateTime.Now);
        }

        public BaseException(string message) : base(message)
        {
        }

        public BaseException(string message, Exception innerException) : base(message, innerException)
        {
            InitializeProperties();
        }

        protected BaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
