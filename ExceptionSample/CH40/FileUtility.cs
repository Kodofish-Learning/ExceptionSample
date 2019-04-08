using System;

namespace ExceptionSample.CH40
{
    public class FileUtility
    {
        public void MoveFiles(string srcFolder, string destFolder)
        {
            try
            {
                // 複製 srcFolder 所有檔案到 destFolder
                // 可能發生 IOException
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                // 釋放資源
            }
        }
    }
}
