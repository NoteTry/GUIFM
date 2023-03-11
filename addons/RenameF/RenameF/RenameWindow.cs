using GUIFM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameF
{
    public partial class RenameWindow : Form
    {
        public RenameWindow()
        {
            InitializeComponent();
        }

        private void NotRenameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RenameWindow_Load(object sender, EventArgs e)
        {
            textBox1.Text = ViewDataHelper.GetData("selectedItem").Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = ViewDataHelper.GetData("path").Value;
                string selectItem = ViewDataHelper.GetData("selectedItem").Value;
                string newName = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(newName))
                    throw new CommandException("Укажите имя!");

                if (File.Exists(path + "/" + selectItem))
                {
                    File.Move(path + "/" + selectItem, path + "/" + newName);
                }

                if (Directory.Exists(path + "/" + selectItem))
                {
                    Directory.Move(path + "/" + selectItem, path + "/" + newName);
                }

                MessageBox.Show("Переименовано!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
