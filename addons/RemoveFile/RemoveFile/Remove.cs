using GUIFM;

namespace RemoveFile
{
    public class Remove : Command, ICommand
    {
        public string CommandText { get => "Удалить"; }

        public string CommandKey { get => "kgf63ogekg53s4"; }

        public void Load()
        {
            string selectItem = this.GetSaveData("selectedItem").Value;
            string path = this.GetSaveData("path").Value;

            if (path == string.Empty)
                throw new CommandException("Нельзя удалять диск!");

            try
            {
                if (Directory.Exists(path + "\\" + selectItem))
                {
                    Directory.Delete(path + "\\" + selectItem, true);
                }

                if (File.Exists(path + "\\" + selectItem))
                {
                    File.Delete(path + "\\" + selectItem);
                }
            }
            catch (Exception ex) 
            {
                throw new CommandException(ex.Message, ex);
            }

        }
    }
}