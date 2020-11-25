using System;
using System.Reflection;

namespace ExceptionRegeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                PassOrigial();
                RethrowOriginal();
                UseThrow();
                CreateCustom();
                TryBlindCatch();
            }
            catch(Exception ex)
            {
                ex.Data.Add("rethrowed", DateTime.Now);
                ShowInfo(ex);
            }
            
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
            catch (FormatException)
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
            catch(Exception ex)
            {
                ex.Data.Add("Rethrowed", DateTime.Now);
                throw;
            }
        }

        private static void ShowInfo(Exception exception)
        {
            Console.WriteLine("---------------- Exception ---------------");

            ShowExceptionInfo(exception);
            if(exception.InnerException != null)
            {
                Console.WriteLine("---------------- Inner exception ---------------");
                ShowExceptionInfo(exception.InnerException);
            }
        }

        private static void ShowExceptionInfo(Exception exception)
        {
            Console.WriteLine("Exception type: {0}", exception.GetType());
            Console.WriteLine("Message: {0}", exception.Message);
            Console.WriteLine("Source: {0}", exception.Source);
            Console.WriteLine("TargetSite: {0}", exception.TargetSite);
            Console.WriteLine("HResult: {0}", exception.HResult);
            if (exception as BaseException != null)
            {
                Type type = exception.GetType();
                PropertyInfo GuidInfo =
                    type.GetProperty("Guid", BindingFlags.Public | BindingFlags.Instance);
                PropertyInfo NetVersionInfo =
                    type.GetProperty("NetVersion", BindingFlags.Public | BindingFlags.Instance);
                PropertyInfo ConstructorNameInfo =
                    type.GetProperty("ConstructorName", BindingFlags.Public | BindingFlags.Instance);

                Console.WriteLine("GUID: {0}", GuidInfo.GetValue(exception));
                Console.WriteLine("Net version: {0}", NetVersionInfo.GetValue(exception));
                Console.WriteLine("Constructor name: {0}", ConstructorNameInfo.GetValue(exception));
            }

            foreach (object key in exception.Data.Keys)
            {
                Console.WriteLine("Data {0}: {1}", key, exception.Data[key]);
            }
        }
    }
}
