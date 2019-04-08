using System;

namespace ExceptionSample.CH40
{
    public class FileUtility
    {
        public void MoveFiles(string srcFolder, string destFolder)
        {
            var folderCheckPoint = new FolderCheckPoint();
            try
            {
                folderCheckPoint.Establish(srcFolder);
                // 複製 srcFolder 所有檔案到 destFolder
                // 可能發生 IOException
            }
            catch (Exception e)
            {
                folderCheckPoint.Restore();
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                // 釋放資源
                folderCheckPoint.Drop();
            }
        }
    }
}
