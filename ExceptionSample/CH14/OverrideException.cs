using System;
using System.IO;
using NUnit.Framework;

namespace ExceptionSample.CH14
{
    [TestFixture]
    class OverrideException
    {
        [Test]
        public void Main()
        {
            try
            {
                FinallyoverridesTryException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            } 
        }

        private void FinallyoverridesTryException()
        {
            var ms = new MyStream();
            try
            {
                throw new IOException("Function Failure");
            }
            finally
            {
                try
                {
                    ms.Close();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}