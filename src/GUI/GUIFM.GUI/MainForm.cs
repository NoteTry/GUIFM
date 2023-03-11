using System.IO;

namespace GUIFM.GUI
{
    public partial class MainForm : Form
    {
        public Command Command;

        public MainForm()
        {
            InitializeComponent();
            Command = new Command();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Command.Addon.Load();
            List<Parameter> ListAddons = new List<Parameter>();
            ICommand addon;

            foreach (Type t in Command.Addon.AddonTypes)
            {
                addon = (ICommand)Activator.CreateInstance(t);
                ListAddons.Add(new Parameter(addon.CommandKey, addon.CommandText));
            }

            CommboCommand.DataSource = ListAddons;
            CommboCommand.ValueMember = "Name";
            CommboCommand.DisplayMember = "Value";

            foreach (DriveInfo disk in Command.GetDrive())
            {
                ListDirectory.Items.Add(disk.Name);
            }
        }

        private void ListDirectory_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Command.AddParametr("selectedItem", e.Item.Text);
            try
            {
                FileAttributes fileAttr = File.GetAttributes(Command.GetParameter("path").Value + Command.GetParameter("selectedItem").Value + "\\");

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    DirectoryPathTextBox.Text = Command.GetParameter("path").Value + Command.GetParameter("selectedItem").Value + "\\";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ListDirectory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Command.AddParametr("path", DirectoryPathTextBox.Text);
            Command.LoadResurse(ListDirectory);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (Command.GetParameter("path").Value == string.Empty || DirectoryPathTextBox.Text == string.Empty)
            {
                Command.AddParametr("path", "");
                ListDirectory.Items.Clear();
                foreach (DriveInfo disk in Command.GetDrive())
                    ListDirectory.Items.Add(disk.Name);
                return;
            }

            Command.AddParametr("path", DirectoryPathTextBox.Text);
            Command.LoadResurse(ListDirectory);
        }

        private void CommboCommand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Parameter? obj = CommboCommand.SelectedItem as Parameter;

            if (ListDirectory.FocusedItem is null) 
            {
                MessageBox.Show("Укажите объект!");
                return;
            }

            string? selectedItem = ListDirectory.FocusedItem is null ? "" : ListDirectory.FocusedItem.Text;

            if (obj != null)
            {
                Command.AddParametr("selectedItem", selectedItem);
                Command.LoadAddon(obj.Name);
            }
        }
    }
}