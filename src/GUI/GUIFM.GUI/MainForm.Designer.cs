namespace GUIFM.GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DirectoryPathTextBox = new TextBox();
            ListDirectory = new ListView();
            IconList = new ImageList(components);
            GoButton = new Button();
            parameterBindingSource = new BindingSource(components);
            parameterBindingSource1 = new BindingSource(components);
            CommboCommand = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)parameterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)parameterBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // DirectoryPathTextBox
            // 
            DirectoryPathTextBox.Location = new Point(150, 8);
            DirectoryPathTextBox.Name = "DirectoryPathTextBox";
            DirectoryPathTextBox.Size = new Size(582, 23);
            DirectoryPathTextBox.TabIndex = 1;
            // 
            // ListDirectory
            // 
            ListDirectory.LargeImageList = IconList;
            ListDirectory.Location = new Point(9, 58);
            ListDirectory.Margin = new Padding(0);
            ListDirectory.Name = "ListDirectory";
            ListDirectory.Size = new Size(782, 383);
            ListDirectory.SmallImageList = IconList;
            ListDirectory.TabIndex = 4;
            ListDirectory.UseCompatibleStateImageBehavior = false;
            ListDirectory.ItemSelectionChanged += ListDirectory_ItemSelectionChanged;
            ListDirectory.SelectedIndexChanged += listView1_SelectedIndexChanged;
            ListDirectory.MouseDoubleClick += ListDirectory_MouseDoubleClick;
            // 
            // IconList
            // 
            IconList.ColorDepth = ColorDepth.Depth32Bit;
            IconList.ImageSize = new Size(48, 48);
            IconList.TransparentColor = Color.Transparent;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(746, 7);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(45, 23);
            GoButton.TabIndex = 5;
            GoButton.Text = "Go";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // parameterBindingSource
            // 
            parameterBindingSource.DataSource = typeof(Parameter);
            // 
            // parameterBindingSource1
            // 
            parameterBindingSource1.DataSource = typeof(Parameter);
            // 
            // CommboCommand
            // 
            CommboCommand.DropDownStyle = ComboBoxStyle.DropDownList;
            CommboCommand.FormattingEnabled = true;
            CommboCommand.Location = new Point(12, 7);
            CommboCommand.Name = "CommboCommand";
            CommboCommand.Size = new Size(132, 23);
            CommboCommand.TabIndex = 6;
            CommboCommand.SelectionChangeCommitted += CommboCommand_SelectionChangeCommitted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CommboCommand);
            Controls.Add(GoButton);
            Controls.Add(ListDirectory);
            Controls.Add(DirectoryPathTextBox);
            Name = "MainForm";
            Text = "GUIFM";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)parameterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)parameterBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DirectoryPathTextBox;
        private ListView ListDirectory;
        private ImageList IconList;
        private Button GoButton;
        private BindingSource parameterBindingSource;
        private BindingSource parameterBindingSource1;
        private ComboBox CommboCommand;
    }
}