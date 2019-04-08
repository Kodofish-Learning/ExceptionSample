namespace ExceptionSample.CH40
{
    public class FolderCheckPoint
    {
        public void Establish(string backupFolder)
        {
            // 備份 backupFolder 所包含的全部檔案，包含子目錄的檔案
        }

        public void Restore()
        {
            // 將備份資料還原
        }

        public void Drop()
        {
            // 刪除所有備份資料
        }
    }
}
