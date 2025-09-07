namespace _30099423_AT2
{
    partial class Form1
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
            ListBoxNeutrinos = new ListBox();
            TextBoxSearch = new TextBox();
            TextBoxEditValue = new TextBox();
            LabelNewValue = new Label();
            ButtonSearch = new Button();
            ButtonEdit = new Button();
            ButtonLoad = new Button();
            ButtonSort = new Button();
            ButtonGenerate = new Button();
            SuspendLayout();
            // 
            // ListBoxNeutrinos
            // 
            ListBoxNeutrinos.FormattingEnabled = true;
            ListBoxNeutrinos.Location = new Point(8, 7);
            ListBoxNeutrinos.Name = "ListBoxNeutrinos";
            ListBoxNeutrinos.Size = new Size(120, 364);
            ListBoxNeutrinos.TabIndex = 0;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(134, 12);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(149, 23);
            TextBoxSearch.TabIndex = 1;
            // 
            // TextBoxEditValue
            // 
            TextBoxEditValue.Location = new Point(134, 76);
            TextBoxEditValue.Name = "TextBoxEditValue";
            TextBoxEditValue.Size = new Size(149, 23);
            TextBoxEditValue.TabIndex = 1;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Location = new Point(134, 58);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(62, 15);
            LabelNewValue.TabIndex = 3;
            LabelNewValue.Text = "New Value";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(289, 12);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(57, 23);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(289, 76);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(57, 23);
            ButtonEdit.TabIndex = 6;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonLoad
            // 
            ButtonLoad.Location = new Point(134, 348);
            ButtonLoad.Name = "ButtonLoad";
            ButtonLoad.Size = new Size(212, 23);
            ButtonLoad.TabIndex = 7;
            ButtonLoad.Text = "Load";
            ButtonLoad.UseVisualStyleBackColor = true;
            ButtonLoad.Click += ButtonLoad_Click;
            // 
            // ButtonSort
            // 
            ButtonSort.Location = new Point(134, 319);
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(212, 23);
            ButtonSort.TabIndex = 7;
            ButtonSort.Text = "Sort";
            ButtonSort.UseVisualStyleBackColor = true;
            ButtonSort.Click += ButtonSort_Click;
            // 
            // ButtonGenerate
            // 
            ButtonGenerate.Location = new Point(134, 264);
            ButtonGenerate.Name = "ButtonGenerate";
            ButtonGenerate.Size = new Size(75, 23);
            ButtonGenerate.TabIndex = 8;
            ButtonGenerate.Text = "Record";
            ButtonGenerate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 384);
            Controls.Add(ButtonGenerate);
            Controls.Add(ButtonSort);
            Controls.Add(ButtonLoad);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonSearch);
            Controls.Add(LabelNewValue);
            Controls.Add(TextBoxEditValue);
            Controls.Add(TextBoxSearch);
            Controls.Add(ListBoxNeutrinos);
            Name = "Form1";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxNeutrinos;
        private TextBox TextBoxSearch;
        private TextBox TextBoxEditValue;
        private Label LabelNewValue;
        private Button ButtonSearch;
        private Button ButtonEdit;
        private Button ButtonLoad;
        private Button ButtonSort;
        private Button ButtonGenerate;
    }
}
