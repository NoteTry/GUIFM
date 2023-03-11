namespace GUIFM.GUI
{
    public class Command
    {
        private List<Parameter> parameters = new List<Parameter>();
        public Addon Addon = new Addon();

        #region Construcor
        public Command()
        {
            this.AddParametr("disk", this.GetDisk(0).ToString());
            this.AddParametr("path", "");
            this.AddParametr("selectedItem", "");
        }
        #endregion

        #region Publuc Methods

        public void LoadAddon(string key)
        {
            ICommand Addon = this.GetAddon(key);

            if (Addon == null)
                return;

            try
            {
                Addon.SaveData = this.parameters;

                Addon.Load();

                this.parameters = Addon.SaveData;

            }
            catch (CommandException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddParametr(string name, string value)
        {
            if (this.parameters.Exists(x => x.Name == name))
            {
                this.parameters.FindAll(s => s.Name == name).ForEach(x => x.Value = value);
                return;
            }

            parameters.Add(new Parameter(name, value));
        }

        public Parameter GetParameter(string name)
        {
            if (parameters == null)
                return new Parameter(name, "");

            foreach (Parameter parameter in this.parameters)
            {
                if (parameter.Name == name)
                    return parameter;
            }

            return new Parameter(name, "");
        }

        public string GetDisk(int index)
        {
            DriveInfo[] allDrives = GetDrive();
            return allDrives[index].Name;
        }

        public DriveInfo[] GetDrive()
        {
            return DriveInfo.GetDrives();
        }

        public void LoadResurse(ListView listView)
        {
            DirectoryInfo fileList;

            try
            {
                fileList = new DirectoryInfo(this.GetParameter("path").Value);
                FileInfo[] files = fileList.GetFiles();
                DirectoryInfo[] dir = fileList.GetDirectories();

                listView.Items.Clear();

                for (int i = 0; i < files.Length; i++)
                {
                    listView.Items.Add(files[i].Name);
                }

                for (int i = 0; i <  dir.Length; i++) 
                {
                    listView.Items.Add(dir[i].Name);
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Private Methods
        private ICommand GetAddon(string keyCommand)
        {
            ICommand Addon;
            foreach (Type t in this.Addon.AddonTypes)
            {
                Addon = (ICommand)Activator.CreateInstance(t);
                if (Addon.CommandKey == keyCommand)
                {
                    return Addon;
                }
            }

            Console.WriteLine($"Не существует данной '{keyCommand}-' команды!");
            return null;
        }
        #endregion
    }
}
