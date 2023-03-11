namespace RenameF
{
    partial class RenameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RenameButton = new Button();
            NotRenameButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // RenameButton
            // 
            RenameButton.Location = new Point(324, 73);
            RenameButton.Name = "RenameButton";
            RenameButton.Size = new Size(75, 23);
            RenameButton.TabIndex = 0;
            RenameButton.Text = "Да";
            RenameButton.UseVisualStyleBackColor = true;
            RenameButton.Click += RenameButton_Click;
            // 
            // NotRenameButton
            // 
            NotRenameButton.Location = new Point(405, 73);
            NotRenameButton.Name = "NotRenameButton";
            NotRenameButton.Size = new Size(75, 23);
            NotRenameButton.TabIndex = 1;
            NotRenameButton.Text = "Нет";
            NotRenameButton.UseVisualStyleBackColor = true;
            NotRenameButton.Click += NotRenameButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(468, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RenameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 101);
            Controls.Add(textBox1);
            Controls.Add(NotRenameButton);
            Controls.Add(RenameButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RenameWindow";
            Text = "Периеменовать";
            Load += RenameWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RenameButton;
        private Button NotRenameButton;
        private TextBox textBox1;
    }
}