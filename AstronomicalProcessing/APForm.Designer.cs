// Raphael Fernandes, 30099423, Sprint 2 
// Date: 20/10/2025 
// Version: 2.1 
// Name: Astronomical Processing 
// Simple Windows Forms Application for searching and sorting a list  
// of recorded neutrino interactions.

namespace AstronomicalProcessing
{
    partial class APForm
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
            ListBoxNeutrinos = new ListBox();
            menuStrip1 = new MenuStrip();
            MenuFile = new ToolStripMenuItem();
            MenuSave = new ToolStripMenuItem();
            MenuSaveAs = new ToolStripMenuItem();
            MenuLoad = new ToolStripMenuItem();
            ButtonGen = new Button();
            GrpSortOrder = new GroupBox();
            rdoSortAsc = new RadioButton();
            rdoSortDesc = new RadioButton();
            ButtonSort = new Button();
            TextBoxSearch = new TextBox();
            ButtonBinSearch = new Button();
            TextBoxEditValue = new TextBox();
            ButtonEdit = new Button();
            LabelNewValue = new Label();
            FilePathLabel = new Label();
            FilePathWrap = new Label();
            FilePath = new TextBox();
            saveAsDialog = new SaveFileDialog();
            loadFileDialog = new OpenFileDialog();
            ButtonSequentialSearch = new Button();
            GrpSearch = new GroupBox();
            GrpEdit = new GroupBox();
            GrpCalulations = new GroupBox();
            Frequency = new Label();
            TextBoxRange = new TextBox();
            TextBoxModeFreq = new TextBox();
            TextBoxMode = new TextBox();
            TextBoxAverage = new TextBox();
            TextBoxMidExtreme = new TextBox();
            ButtonRange = new Button();
            ButtonAverage = new Button();
            ButtonMode = new Button();
            ButtonMidExtreme = new Button();
            toolTip1 = new ToolTip(components);
            groupBox1 = new GroupBox();
            TestRange = new Button();
            TestMode = new Button();
            TestMean = new Button();
            TestMid = new Button();
            menuStrip1.SuspendLayout();
            GrpSortOrder.SuspendLayout();
            GrpSearch.SuspendLayout();
            GrpEdit.SuspendLayout();
            GrpCalulations.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxNeutrinos
            // 
            ListBoxNeutrinos.FormattingEnabled = true;
            ListBoxNeutrinos.ItemHeight = 15;
            ListBoxNeutrinos.Location = new Point(12, 28);
            ListBoxNeutrinos.Name = "ListBoxNeutrinos";
            ListBoxNeutrinos.Size = new Size(120, 364);
            ListBoxNeutrinos.TabIndex = 6;
            toolTip1.SetToolTip(ListBoxNeutrinos, "List of neutrino interactions recorded\r\nover the last 24 hours");
            ListBoxNeutrinos.SelectedIndexChanged += SelectedNeutrinoChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(510, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            MenuFile.DropDownItems.AddRange(new ToolStripItem[] { MenuSave, MenuSaveAs, MenuLoad });
            MenuFile.Name = "MenuFile";
            MenuFile.Size = new Size(37, 20);
            MenuFile.Text = "File";
            // 
            // MenuSave
            // 
            MenuSave.Name = "MenuSave";
            MenuSave.Size = new Size(121, 22);
            MenuSave.Text = "Save";
            MenuSave.Click += MenuSave_Click;
            // 
            // MenuSaveAs
            // 
            MenuSaveAs.Name = "MenuSaveAs";
            MenuSaveAs.Size = new Size(121, 22);
            MenuSaveAs.Text = "Save as...";
            MenuSaveAs.Click += MenuSaveAs_Click;
            // 
            // MenuLoad
            // 
            MenuLoad.Name = "MenuLoad";
            MenuLoad.Size = new Size(121, 22);
            MenuLoad.Text = "Load";
            MenuLoad.Click += MenuLoad_Click;
            // 
            // ButtonGen
            // 
            ButtonGen.Location = new Point(138, 28);
            ButtonGen.Name = "ButtonGen";
            ButtonGen.Size = new Size(158, 23);
            ButtonGen.TabIndex = 0;
            ButtonGen.Text = "Record";
            toolTip1.SetToolTip(ButtonGen, "Record new neutrino interactions");
            ButtonGen.UseVisualStyleBackColor = true;
            ButtonGen.Click += ButtonRecord_Click;
            // 
            // GrpSortOrder
            // 
            GrpSortOrder.Controls.Add(rdoSortAsc);
            GrpSortOrder.Controls.Add(rdoSortDesc);
            GrpSortOrder.Location = new Point(138, 57);
            GrpSortOrder.Name = "GrpSortOrder";
            GrpSortOrder.Size = new Size(158, 73);
            GrpSortOrder.TabIndex = 1;
            GrpSortOrder.TabStop = false;
            GrpSortOrder.Text = "Sort Order";
            // 
            // rdoSortAsc
            // 
            rdoSortAsc.AutoSize = true;
            rdoSortAsc.Location = new Point(6, 22);
            rdoSortAsc.Name = "rdoSortAsc";
            rdoSortAsc.Size = new Size(81, 19);
            rdoSortAsc.TabIndex = 1;
            rdoSortAsc.TabStop = true;
            rdoSortAsc.Text = "Ascending";
            toolTip1.SetToolTip(rdoSortAsc, "Select to sort the list in ascending order");
            rdoSortAsc.UseVisualStyleBackColor = true;
            rdoSortAsc.CheckedChanged += SortOrderChanged;
            // 
            // rdoSortDesc
            // 
            rdoSortDesc.AutoSize = true;
            rdoSortDesc.Location = new Point(6, 47);
            rdoSortDesc.Name = "rdoSortDesc";
            rdoSortDesc.Size = new Size(87, 19);
            rdoSortDesc.TabIndex = 2;
            rdoSortDesc.TabStop = true;
            rdoSortDesc.Text = "Descending";
            toolTip1.SetToolTip(rdoSortDesc, "Select to sort the list in Descending order");
            rdoSortDesc.UseVisualStyleBackColor = true;
            rdoSortDesc.CheckedChanged += SortOrderChanged;
            // 
            // ButtonSort
            // 
            ButtonSort.Location = new Point(138, 139);
            ButtonSort.Name = "ButtonSort";
            ButtonSort.Size = new Size(158, 23);
            ButtonSort.TabIndex = 3;
            ButtonSort.Text = "Sort";
            toolTip1.SetToolTip(ButtonSort, "Sorts the list using bubble sort\nSelect the sort order using the Ascending/Descending buttons");
            ButtonSort.UseVisualStyleBackColor = true;
            ButtonSort.Click += ButtonSort_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(6, 18);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(146, 23);
            TextBoxSearch.TabIndex = 1;
            toolTip1.SetToolTip(TextBoxSearch, "Text box for searching the list");
            // 
            // ButtonBinSearch
            // 
            ButtonBinSearch.Location = new Point(6, 43);
            ButtonBinSearch.Name = "ButtonBinSearch";
            ButtonBinSearch.Size = new Size(70, 23);
            ButtonBinSearch.TabIndex = 2;
            ButtonBinSearch.Text = "Binary";
            toolTip1.SetToolTip(ButtonBinSearch, "Searches for the inputted number with Binary Search\nList will be sorted if it isn't already");
            ButtonBinSearch.UseVisualStyleBackColor = true;
            ButtonBinSearch.Click += ButtonSearch_Click;
            // 
            // TextBoxEditValue
            // 
            TextBoxEditValue.Location = new Point(6, 37);
            TextBoxEditValue.Name = "TextBoxEditValue";
            TextBoxEditValue.Size = new Size(146, 23);
            TextBoxEditValue.TabIndex = 7;
            toolTip1.SetToolTip(TextBoxEditValue, "Textbox for editing the selected item");
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new Point(6, 66);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(146, 23);
            ButtonEdit.TabIndex = 8;
            ButtonEdit.Text = "Edit";
            toolTip1.SetToolTip(ButtonEdit, "Replaces the selected number with the number in the search box");
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Location = new Point(6, 19);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(62, 15);
            LabelNewValue.TabIndex = 9;
            LabelNewValue.Text = "New Value";
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(138, 351);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(52, 15);
            FilePathLabel.TabIndex = 12;
            FilePathLabel.Text = "File Path";
            // 
            // FilePathWrap
            // 
            FilePathWrap.AutoSize = true;
            FilePathWrap.Location = new Point(138, 272);
            FilePathWrap.MaximumSize = new Size(212, 0);
            FilePathWrap.Name = "FilePathWrap";
            FilePathWrap.Size = new Size(0, 15);
            FilePathWrap.TabIndex = 0;
            FilePathWrap.Visible = false;
            // 
            // FilePath
            // 
            FilePath.Location = new Point(138, 369);
            FilePath.MaximumSize = new Size(212, int.MaxValue);
            FilePath.Multiline = true;
            FilePath.Name = "FilePath";
            FilePath.ReadOnly = true;
            FilePath.Size = new Size(158, 23);
            FilePath.TabIndex = 12;
            FilePath.TabStop = false;
            toolTip1.SetToolTip(FilePath, "Currently loaded file path\nClick to load a file");
            FilePath.DoubleClick += MenuLoad_Click;
            // 
            // saveAsDialog
            // 
            saveAsDialog.DefaultExt = "txt";
            saveAsDialog.FileName = "Neutrinos.txt";
            saveAsDialog.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveAsDialog.RestoreDirectory = true;
            saveAsDialog.Title = "Save Neutrino interactions";
            saveAsDialog.FileOk += SaveAsSelected;
            // 
            // loadFileDialog
            // 
            loadFileDialog.DefaultExt = "txt";
            loadFileDialog.FileName = "Neutrinos.txt";
            loadFileDialog.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            loadFileDialog.ReadOnlyChecked = true;
            loadFileDialog.RestoreDirectory = true;
            loadFileDialog.ShowReadOnly = true;
            loadFileDialog.Title = "Select File Containing Neutrino Interactions";
            loadFileDialog.FileOk += LoadSelected;
            // 
            // ButtonSequentialSearch
            // 
            ButtonSequentialSearch.Location = new Point(82, 43);
            ButtonSequentialSearch.Name = "ButtonSequentialSearch";
            ButtonSequentialSearch.Size = new Size(70, 23);
            ButtonSequentialSearch.TabIndex = 3;
            ButtonSequentialSearch.Text = "Sequential";
            toolTip1.SetToolTip(ButtonSequentialSearch, "Searches for the inputted number with Sequential Search\nList does not need to be sorted");
            ButtonSequentialSearch.UseVisualStyleBackColor = true;
            ButtonSequentialSearch.Click += ButtonSearch_Click;
            // 
            // GrpSearch
            // 
            GrpSearch.Controls.Add(ButtonBinSearch);
            GrpSearch.Controls.Add(ButtonSequentialSearch);
            GrpSearch.Controls.Add(TextBoxSearch);
            GrpSearch.Location = new Point(138, 168);
            GrpSearch.Name = "GrpSearch";
            GrpSearch.Size = new Size(158, 73);
            GrpSearch.TabIndex = 4;
            GrpSearch.TabStop = false;
            GrpSearch.Text = "Search";
            // 
            // GrpEdit
            // 
            GrpEdit.Controls.Add(TextBoxEditValue);
            GrpEdit.Controls.Add(ButtonEdit);
            GrpEdit.Controls.Add(LabelNewValue);
            GrpEdit.Location = new Point(138, 247);
            GrpEdit.Name = "GrpEdit";
            GrpEdit.Size = new Size(158, 98);
            GrpEdit.TabIndex = 13;
            GrpEdit.TabStop = false;
            GrpEdit.Text = "Edit";
            // 
            // GrpCalulations
            // 
            GrpCalulations.Controls.Add(Frequency);
            GrpCalulations.Controls.Add(TextBoxRange);
            GrpCalulations.Controls.Add(TextBoxModeFreq);
            GrpCalulations.Controls.Add(TextBoxMode);
            GrpCalulations.Controls.Add(TextBoxAverage);
            GrpCalulations.Controls.Add(TextBoxMidExtreme);
            GrpCalulations.Controls.Add(ButtonRange);
            GrpCalulations.Controls.Add(ButtonAverage);
            GrpCalulations.Controls.Add(ButtonMode);
            GrpCalulations.Controls.Add(ButtonMidExtreme);
            GrpCalulations.Location = new Point(302, 28);
            GrpCalulations.Name = "GrpCalulations";
            GrpCalulations.Size = new Size(200, 169);
            GrpCalulations.TabIndex = 14;
            GrpCalulations.TabStop = false;
            GrpCalulations.Text = "Statistical Calculations";
            // 
            // Frequency
            // 
            Frequency.AutoSize = true;
            Frequency.Location = new Point(163, 55);
            Frequency.Name = "Frequency";
            Frequency.Size = new Size(30, 15);
            Frequency.TabIndex = 17;
            Frequency.Text = "Freq";
            // 
            // TextBoxRange
            // 
            TextBoxRange.Location = new Point(93, 137);
            TextBoxRange.Name = "TextBoxRange";
            TextBoxRange.ReadOnly = true;
            TextBoxRange.Size = new Size(100, 23);
            TextBoxRange.TabIndex = 16;
            toolTip1.SetToolTip(TextBoxRange, "Calculated range of list\nUse the button to the left to calculate");
            // 
            // TextBoxModeFreq
            // 
            TextBoxModeFreq.Location = new Point(163, 80);
            TextBoxModeFreq.Name = "TextBoxModeFreq";
            TextBoxModeFreq.ReadOnly = true;
            TextBoxModeFreq.Size = new Size(30, 23);
            TextBoxModeFreq.TabIndex = 15;
            TextBoxModeFreq.TextAlign = HorizontalAlignment.Center;
            toolTip1.SetToolTip(TextBoxModeFreq, "Number of times the Mode was found in the list.\r\nUse the button above to calculate");
            // 
            // TextBoxMode
            // 
            TextBoxMode.Location = new Point(6, 80);
            TextBoxMode.Name = "TextBoxMode";
            TextBoxMode.ReadOnly = true;
            TextBoxMode.Size = new Size(151, 23);
            TextBoxMode.TabIndex = 5;
            TextBoxMode.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(TextBoxMode, "Calculated modes of list\r\nUse the button above to calculate");
            // 
            // TextBoxAverage
            // 
            TextBoxAverage.Location = new Point(93, 109);
            TextBoxAverage.Name = "TextBoxAverage";
            TextBoxAverage.ReadOnly = true;
            TextBoxAverage.Size = new Size(100, 23);
            TextBoxAverage.TabIndex = 15;
            toolTip1.SetToolTip(TextBoxAverage, "Calculated average of list\nUse the button to the left to calculate");
            // 
            // TextBoxMidExtreme
            // 
            TextBoxMidExtreme.Location = new Point(93, 22);
            TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            TextBoxMidExtreme.ReadOnly = true;
            TextBoxMidExtreme.Size = new Size(100, 23);
            TextBoxMidExtreme.TabIndex = 4;
            toolTip1.SetToolTip(TextBoxMidExtreme, "Calculated mid extreme of list\nUse the button to the left to calculate");
            // 
            // ButtonRange
            // 
            ButtonRange.Location = new Point(5, 138);
            ButtonRange.Name = "ButtonRange";
            ButtonRange.Size = new Size(82, 23);
            ButtonRange.TabIndex = 3;
            ButtonRange.Text = "Range";
            toolTip1.SetToolTip(ButtonRange, "Calculates the range of the list and\ndisplays the result in the text box to the right");
            ButtonRange.UseVisualStyleBackColor = true;
            ButtonRange.Click += ButtonRange_Click;
            // 
            // ButtonAverage
            // 
            ButtonAverage.Location = new Point(5, 109);
            ButtonAverage.Name = "ButtonAverage";
            ButtonAverage.Size = new Size(82, 23);
            ButtonAverage.TabIndex = 2;
            ButtonAverage.Text = "Average";
            ButtonAverage.TextAlign = ContentAlignment.TopCenter;
            toolTip1.SetToolTip(ButtonAverage, "Calculates the average of the list and\ndisplays the result in the text box to the right");
            ButtonAverage.UseVisualStyleBackColor = true;
            ButtonAverage.Click += ButtonAverage_Click;
            // 
            // ButtonMode
            // 
            ButtonMode.Location = new Point(6, 51);
            ButtonMode.Name = "ButtonMode";
            ButtonMode.Size = new Size(83, 23);
            ButtonMode.TabIndex = 1;
            ButtonMode.Text = "Mode";
            toolTip1.SetToolTip(ButtonMode, "Calculates the modes of the list and\n displays the results in the text boxes to the right");
            ButtonMode.UseVisualStyleBackColor = true;
            ButtonMode.Click += ButtonMode_Click;
            // 
            // ButtonMidExtreme
            // 
            ButtonMidExtreme.Location = new Point(7, 22);
            ButtonMidExtreme.Name = "ButtonMidExtreme";
            ButtonMidExtreme.Size = new Size(82, 23);
            ButtonMidExtreme.TabIndex = 0;
            ButtonMidExtreme.Text = "Mid Extreme";
            toolTip1.SetToolTip(ButtonMidExtreme, "Calculates the mid extreme of the list and\ndisplays the result in the text box to the right");
            ButtonMidExtreme.UseVisualStyleBackColor = true;
            ButtonMidExtreme.Click += ButtonMidExtreme_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TestRange);
            groupBox1.Controls.Add(TestMode);
            groupBox1.Controls.Add(TestMean);
            groupBox1.Controls.Add(TestMid);
            groupBox1.Location = new Point(302, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 134);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // TestRange
            // 
            TestRange.Location = new Point(11, 98);
            TestRange.Name = "TestRange";
            TestRange.Size = new Size(182, 23);
            TestRange.TabIndex = 0;
            TestRange.Tag = "Range";
            TestRange.Text = "Test Range";
            TestRange.UseVisualStyleBackColor = true;
            // 
            // TestMode
            // 
            TestMode.Location = new Point(11, 47);
            TestMode.Name = "TestMode";
            TestMode.Size = new Size(182, 23);
            TestMode.TabIndex = 0;
            TestMode.Tag = "Mode";
            TestMode.Text = "Test Mode";
            TestMode.UseVisualStyleBackColor = true;
            // 
            // TestMean
            // 
            TestMean.Location = new Point(11, 72);
            TestMean.Name = "TestMean";
            TestMean.Size = new Size(182, 23);
            TestMean.TabIndex = 0;
            TestMean.Tag = "Mean";
            TestMean.Text = "Test Mean";
            TestMean.UseVisualStyleBackColor = true;
            // 
            // TestMid
            // 
            TestMid.Location = new Point(11, 22);
            TestMid.Name = "TestMid";
            TestMid.Size = new Size(182, 23);
            TestMid.TabIndex = 0;
            TestMid.Tag = "Mid";
            TestMid.Text = "Test Mid";
            TestMid.UseVisualStyleBackColor = true;
            TestMid.Click += TestCalculation;
            TestMode.Click += TestCalculation;
            TestMean.Click += TestCalculation;
            TestRange.Click += TestCalculation;
            // 
            // APForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(510, 398);
            Controls.Add(groupBox1);
            Controls.Add(GrpCalulations);
            Controls.Add(GrpEdit);
            Controls.Add(GrpSearch);
            Controls.Add(FilePath);
            Controls.Add(FilePathWrap);
            Controls.Add(FilePathLabel);
            Controls.Add(GrpSortOrder);
            Controls.Add(ButtonGen);
            Controls.Add(ButtonSort);
            Controls.Add(ListBoxNeutrinos);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "APForm";
            RightToLeft = RightToLeft.No;
            Text = "Astronomical Processing";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            GrpSortOrder.ResumeLayout(false);
            GrpSortOrder.PerformLayout();
            GrpSearch.ResumeLayout(false);
            GrpSearch.PerformLayout();
            GrpEdit.ResumeLayout(false);
            GrpEdit.PerformLayout();
            GrpCalulations.ResumeLayout(false);
            GrpCalulations.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxNeutrinos;
        private TextBox TextBoxSearch;
        private TextBox TextBoxEditValue;
        private Label LabelNewValue;
        private Button ButtonBinSearch;
        private Button ButtonEdit;

        private Button ButtonGen;
        private Button ButtonSort;
        private GroupBox GrpSortOrder;
        private RadioButton rdoSortAsc;
        private RadioButton rdoSortDesc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuFile;
        private ToolStripMenuItem MenuSave;
        private ToolStripMenuItem MenuLoad;
        private ToolStripMenuItem MenuSaveAs;
        private Label FilePathLabel;
        private Label FilePathWrap;
        private TextBox FilePath;
        private SaveFileDialog saveAsDialog;
        private OpenFileDialog loadFileDialog;
        private Button ButtonSequentialSearch;
        private GroupBox GrpSearch;
        private GroupBox GrpEdit;
        private GroupBox GrpCalulations;
        private Button ButtonAverage;
        private Button ButtonMode;
        private Button ButtonMidExtreme;
        private Button ButtonRange;
        private TextBox TextBoxRange;
        private TextBox TextBoxMode;
        private TextBox TextBoxAverage;
        private TextBox TextBoxMidExtreme;
        private ToolTip toolTip1;
        private Label Frequency;
        private TextBox TextBoxModeFreq;
        private GroupBox groupBox1;
        private Button TestRange;
        private Button TestMode;
        private Button TestMean;
        private Button TestMid;
    }
}
