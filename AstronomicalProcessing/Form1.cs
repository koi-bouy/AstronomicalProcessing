// Raphael Fernandes, 30099423, Sprint 2 
// Date: 6/10/2025 
// Version: 1.0 
// Name: Astronomical Processing 
// Simple Windows Forms Application for searching and sorting a list  
// of recorded neutrino interactions.

namespace AT2_30099423
{

    /// <summary>
    /// Main form
    /// </summary>
    public partial class AstronomicalProcessing : Form
    {
        private List<int> neutrinoList = new List<int>();
        private bool unsorted = true;

        /// <summary>
        /// Runs setup code from Form1.designer.cs
        /// </summary>
        public AstronomicalProcessing()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Sorts the neutrino list ascending or descending based on the radio buttons.
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            if (unsorted)
            {
                Algorithms.BubbleSort(neutrinoList, rdoSortAsc.Checked);
                unsorted = false;
                SyncList();
            }
        }

        /// <summary>
        /// Search the list, sorting if the list isn't sorted already.
        /// </summary>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                //Clear any whitespace
                TextBoxSearch.Clear();
                ShowError("Nothing entered.", "Input");
            }

            else if (int.TryParse(TextBoxSearch.Text, out int input))
            {

                int index;
                if (!unsorted)
                {
                    bool asc = rdoSortAsc.Checked;
                    //sort the list if it isn't already
                    //if (unsorted)
                    //{
                    //    Algorithms.BubbleSort(neutrinoList, asc);
                    //    unsorted = false;
                    //}

                    //Use binary search method to get index. Will be -1 if the item can't be found.
                    index = Algorithms.BinarySearch(neutrinoList, input, asc);
                }
                else
                {
                    index = Algorithms.SequentialSearch(neutrinoList, input);
                }
                SyncList();

                //Select the number if it was found, otherwise 
                if (index != -1)
                {
                    TextBoxSearch.Clear();
                    MessageBox.Show($"{input} found at index: {index}", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListBoxNeutrinos.SelectedIndex = index;
                }
                else
                    ShowError($"Could not find {input}", errorType: "Search");

            }
            else
                ShowError("Not an integer", "Input");

        }

        /// <summary>
        /// Generate new list of neutrino interactions
        /// </summary>
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            neutrinoList = GenerateNeutrinos();
            unsorted = true;
            SyncList();
        }

        /// <summary>
        /// Puts the Selected list box item into the Edit text box
        /// </summary>
        private void SelectedNeutrinoChanged(object sender, EventArgs e)
        {
            TextBoxEditValue.Text = (ListBoxNeutrinos.SelectedItem ?? "Error").ToString();
        }

        /// <summary>
        /// Edit selected item
        /// </summary>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(TextBoxEditValue.Text))
            {
                //Clear any whitespace
                TextBoxEditValue.Clear();
                ShowError("Nothing entered.", "Input");
            }
            else if (int.TryParse(TextBoxEditValue.Text, out int newVal))
            {
                // Replace the selected item with the edit value
                if (ListBoxNeutrinos.SelectedItem != null)
                {
                    neutrinoList[ListBoxNeutrinos.SelectedIndex] = newVal;
                    unsorted = true;
                    SyncList();

                }
                else
                    ShowError("No item selected");

            }
            else
                ShowError("Not an integer", "Input");





        }



        #region FileManagement

        //good ol' scope creep

        /// <summary>
        /// Called on conformation of SaveAs dialog box
        /// </summary>
        private void SaveAsSelected(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetPath(saveAsDialog.FileName);
            SaveFile();

        }

        /// <summary>
        /// Called on conformation of Load file dialog box
        /// </summary>
        private void LoadSelected(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetPath(loadFileDialog.FileName);
            LoadFile();

        }

        /// <summary>
        /// Saves to currently loaded file,
        /// or calls SaveAs if no file is loaded
        /// </summary>
        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (FilePath.Text != "No file loaded.")
                SaveFile();
            else
                saveAsDialog.ShowDialog();

        }

        /// <summary>
        /// Load file menu strip button
        /// </summary>
        private void MenuLoad_Click(object sender, EventArgs e)
        {
            loadFileDialog.ShowDialog();

        }



        /// <summary>
        /// Save as menu strip button
        /// </summary>
        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            saveAsDialog.ShowDialog();
        }

        /// <summary>
        /// Write Neutrino list to file
        /// </summary>
        public void SaveFile()
        {
            using (StreamWriter file = new StreamWriter(FilePath.Text))
            {
                foreach (int interaction in neutrinoList)
                {
                    file.WriteLine(interaction);
                }
            }
        }

        /// <summary>
        /// Load file from file path to the neutrino list
        /// </summary>
        private void LoadFile()
        {

            // Clear neutrino list to write file contents
            neutrinoList.Clear();
            using (StreamReader file = new StreamReader(FilePath.Text))
            {

                // Read lines from file until the end is reached
                for (string? line = file.ReadLine(); line != null; line = file.ReadLine())
                {
                    if (int.TryParse(line, out int interaction))
                    {
                        neutrinoList.Add(interaction);
                    }
                    else
                    {
                        // Show error and reset neutrino list to what's in the list box.
                        ShowError($"Error parsing file\nline: {line} is not an integer");
                        neutrinoList.Clear();
                        foreach (int item in ListBoxNeutrinos.Items)
                            neutrinoList.Add(item);
                        return;
                    }
                }
            }

        }

        /// <summary>
        /// Set File path and auto-size using a label
        /// as text boxes cannot autosize on their own.
        /// </summary>
        /// <param name="newPath">New file path</param>
        private void SetPath(string newPath)
        {
            FilePath.Text = newPath;
            FilePathWrap.Text = FilePath.Text;
            FilePath.Height = FilePathWrap.Height + FilePath.Margin.Vertical;
            FilePath.Width = FilePathWrap.Width + FilePath.Margin.Horizontal;
        }
        #endregion

        /// <summary>
        /// Initialise variables
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //set documents folder as default save path
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveAsDialog.InitialDirectory = documents;
            loadFileDialog.InitialDirectory = documents;

            // Set the File Path TextBox to 
            SetPath("No file loaded.");
            neutrinoList = GenerateNeutrinos();
            SyncList();
            rdoSortAsc.Checked = true;
        }


        /// <summary>
        /// Generates a new list of 24 random integers
        /// between 10 and 90
        /// </summary>
        /// <returns>Generated list</returns>
        private static List<int> GenerateNeutrinos()
        {
            Random rand = new Random();
            var list = new List<int>();
            for (int i = 1; i <= 24; i++)
            {
                list.Add(rand.Next(10, 91));
            }
            return list;
        }

        /// <summary>
        /// Copies the neutrino interaction list to the ListBox
        /// </summary>
        private void SyncList()
        {
            int selIndx = ListBoxNeutrinos.SelectedIndex;

            ListBoxNeutrinos.Items.Clear();
            foreach (int neutrino in neutrinoList)
                ListBoxNeutrinos.Items.Add(neutrino);

            //restore selected item
            ListBoxNeutrinos.SelectedIndex = selIndx;
        }

        /// <summary>
        /// Displays an error message.
        /// </summary>
        /// <param name="message">Error message to display</param>
        /// <param name="errorType">Error prefix</param>
        private void ShowError(string message, string errorType = "")
        {
            string errorCaption = errorType + (string.IsNullOrEmpty(errorType) ? "Error" : " Error");
            MessageBox.Show(message, caption: errorCaption, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
        }

        /// <summary>
        /// Called whenever one of the sort order radio buttons are clicked.
        /// Sets the flag for the list to be resorted.
        /// </summary>
        private void SortOrderChanged(object sender, EventArgs e)
        {
            unsorted = true;
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
