
﻿namespace AstronimicalProcessing
{
    partial class AstronomicalProcessing
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
            ButtonGen = new Button();
            ButtonEdit = new Button();
            ButtonSort = new Button();
            GrpSortOrder = new GroupBox();
            rdoSortAsc = new RadioButton();
            rdoSortDesc = new RadioButton();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            GrpSortOrder.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxNeutrinos
            // 
            ListBoxNeutrinos.FormattingEnabled = true;
            ListBoxNeutrinos.Location = new Point(12, 28);
            ListBoxNeutrinos.Name = "ListBoxNeutrinos";
            ListBoxNeutrinos.Size = new Size(120, 364);
            ListBoxNeutrinos.TabIndex = 0;
            ListBoxNeutrinos.SelectedIndexChanged += SelectedNeutrinoChanged;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(138, 183);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(149, 23);
            TextBoxSearch.TabIndex = 1;
            // 
            // TextBoxEditValue
            // 
            TextBoxEditValue.Location = new Point(138, 228);
            TextBoxEditValue.Name = "TextBoxEditValue";
            TextBoxEditValue.Size = new Size(149, 23);
            TextBoxEditValue.TabIndex = 1;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Location = new Point(138, 210);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(62, 15);
            LabelNewValue.TabIndex = 3;
            LabelNewValue.Text = "New Value";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(293, 183);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(57, 23);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;

            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // ButtonGen
            // 
            ButtonGen.Location = new Point(138, 28);
            ButtonGen.Name = "ButtonGen";
            ButtonGen.Size = new Size(212, 23);
            ButtonGen.TabIndex = 8;
            ButtonGen.Text = "Record";
            ButtonGen.UseVisualStyleBackColor = true;
            ButtonGen.Click += ButtonRecord_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(293, 228);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(57, 23);
            ButtonEdit.TabIndex = 6;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;

            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonSort
            // 
            ButtonSort.Location = new Point(138, 57);
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(120, 23);
            ButtonSort.TabIndex = 7;
            ButtonSort.Text = "Sort";
            ButtonSort.UseVisualStyleBackColor = true;
            ButtonSort.Click += ButtonSort_Click;
            // 

            // GrpSortOrder
            // 
            GrpSortOrder.Controls.Add(rdoSortAsc);
            GrpSortOrder.Controls.Add(rdoSortDesc);
            GrpSortOrder.Location = new Point(138, 86);
            GrpSortOrder.Name = "GrpSortOrder";
            GrpSortOrder.Size = new Size(120, 73);
            GrpSortOrder.TabIndex = 9;
            GrpSortOrder.TabStop = false;
            GrpSortOrder.Text = "Sort Order";
            // 
            // rdoSortAsc
            // 
            rdoSortAsc.AutoSize = true;
            rdoSortAsc.Location = new Point(6, 22);
            rdoSortAsc.Name = "rdoSortAsc";
            rdoSortAsc.Size = new Size(81, 19);
            rdoSortAsc.TabIndex = 10;
            rdoSortAsc.TabStop = true;
            rdoSortAsc.Text = "Ascending";
            rdoSortAsc.UseVisualStyleBackColor = true;
            // 
            // rdoSortDesc
            // 
            rdoSortDesc.AutoSize = true;
            rdoSortDesc.Location = new Point(6, 47);
            rdoSortDesc.Name = "rdoSortDesc";
            rdoSortDesc.Size = new Size(87, 19);
            rdoSortDesc.TabIndex = 0;
            rdoSortDesc.TabStop = true;
            rdoSortDesc.Text = "Descending";
            rdoSortDesc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 165);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 10;
            label1.Text = "Search Item";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(355, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem1, saveAsToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(114, 22);
            saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(114, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // AstronomicalProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 399);
            Controls.Add(label1);
            Controls.Add(GrpSortOrder);
            Controls.Add(ButtonGen);
            Controls.Add(ButtonSort);
            Controls.Add(ButtonEdit);
            Controls.Add(ButtonSearch);
            Controls.Add(LabelNewValue);
            Controls.Add(TextBoxEditValue);
            Controls.Add(TextBoxSearch);
            Controls.Add(ListBoxNeutrinos);

            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AstronomicalProcessing";
            Text = "Astronomical Processing";
            GrpSortOrder.ResumeLayout(false);
            GrpSortOrder.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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

        private Button ButtonGen;
        private Button ButtonSort;
        private GroupBox GrpSortOrder;
        private RadioButton rdoSortAsc;
        private RadioButton rdoSortDesc;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}
