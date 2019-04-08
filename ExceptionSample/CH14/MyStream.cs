using System;
using System.IO;

namespace ExceptionSample.CH14
{
    internal class MyStream: MemoryStream
    {
        public override void Close()
        {
            throw new Exception("close failure");
        }
    }
}
