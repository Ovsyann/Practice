using System;
using System.Collections;
using System.Reflection;

namespace ExceptionRegeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            RethrowOriginal();
            UseThrow();
            PassOrigial();
            CreateCustom();
            TryBlindCatch();
        }

        private static void RethrowOriginal()
        {
            try
            {
                double.Parse("Booom!!!");
            }
            catch (FormatException ex)
            {
                ex.Data.Add("rethrowed", DateTime.Now);
                throw ex;
            }
        }

        private static void UseThrow()
        {
            try
            {
                double.Parse("Booom!!!");
            }
            catch (FormatException)
            {
                BaseException baseException = new BaseException();
                baseException.Data.Add("Rethrowed", DateTime.Now);
                throw baseException;
            }
        }

        private static void PassOrigial()
        {
            try
            {
                double.Parse("Booom!!!");
            }
            catch (FormatException ex)
            {
                BaseException exception = new BaseException("BaseException thrown", ex);
                exception.Data.Add("Rethrowed", DateTime.Now);
                throw exception;
            }
        }

        private static void CreateCustom()
        {
            try
            {
                double.Parse("Booom!!!");
            }
            catch(FormatException)
            {
                BaseException exception = new BaseException();
                exception.Data.Add("Rethrowed", DateTime.Now);
                throw exception;
            }
        }

        private static void TryBlindCatch()
        {
            try
            {
                double.Parse("Booom!!!");
            }
            catch
            {
                throw;
            }
        }

        private void ShowInfo(Exception exception)
        {
            Console.WriteLine("Exception type: {0}", exception.GetType());
            Console.WriteLine("Message: {0}", exception.Message);
            Console.WriteLine("Source: {0}", exception.Source);
            Console.WriteLine("TargetSite: {0}", exception.TargetSite);
            Console.WriteLine("HResult: {0}", exception.HResult);
            if(exception as BaseException != null)
            {
                Type type = exception.GetType();
                PropertyInfo propertyInfo = type.GetProperty("NetVersion", BindingFlags.Public | BindingFlags.Instance);
                Console.WriteLine("GUID: {0}", type.GetProperty("Guid", BindingFlags.Public | BindingFlags.Instance));
                Console.WriteLine("Net version: {0}", type.GetProperty("NetVersion", BindingFlags.Public | BindingFlags.Instance));
                Console.WriteLine("Constructor name: {0}", type.GetProperty("ConstructorName", BindingFlags.Public | BindingFlags.Instance));
            }

            foreach(object key in exception.Data.Keys)
            {
                Console.WriteLine("Data {0}: {1}", key, exception.Data[key]);
            }
        }
    }
}
