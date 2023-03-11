using GUIFM;
using System.IO;

namespace RenameF
{
    public class Rename : Command, ICommand
    {
        public string CommandText { get => "Переименовать";}

        public string CommandKey { get => "lbvfdj4tdfgsd"; }

        public void Load()
        {
            string path = this.GetSaveData("path").Value;

            if (path == string.Empty)
                throw new CommandException("Нельзя удалять диск!");

            ViewDataHelper.Data = this.SaveData;

            RenameWindow renameWindow = new RenameWindow();
            renameWindow.Show();
        }

        public void RenameFD()
        {
            string path = this.GetSaveData("path").Value;
            string selectItem = this.GetSaveData("selectedItem").Value;
            string newName = ViewDataHelper.GetData("new-name").Value.Trim();

            if (newName is null)
                throw new CommandException("Укажите имя!");

            if (File.Exists(path + "/" + selectItem))
            {
                File.Move(path + "/" + selectItem, path + "/" + newName);
            }
        }
    }
}