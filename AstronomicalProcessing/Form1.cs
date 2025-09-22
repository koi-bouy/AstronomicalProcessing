namespace AT2_30099423
{
    public partial class AstronomicalProcessing : Form
    {
        private List<int> neutrinoList = new List<int>();
        private bool unsorted = true;
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

                //sort the list if it isn't already
                bool asc = rdoSortAsc.Checked;
                if (unsorted)
                {
                    Algorithms.BubbleSort(neutrinoList, asc);
                    unsorted = false;
                }

                //Use binary search method to get index. Will be -1 if the item can't be found.
                int index = Algorithms.BinarySearch(neutrinoList, input, asc);
                SyncList();

                //Select the number if it was found, otherwise 
                if (index != -1)
                {
                    TextBoxSearch.Clear();
                    MessageBox.Show($"{input} found at index: {index}", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListBoxNeutrinos.SelectedIndex = index;
                }
                else
                {
                    ShowError($"Could not find {input}", errorType: "Search");
                }
            }
            else
            {
                ShowError("Not an integer", "Input");
            }
        }

        /// <summary>
        /// Generate new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (ListBoxNeutrinos.SelectedItem != null)
                {

                    neutrinoList[ListBoxNeutrinos.SelectedIndex] = newVal;

                }
                else
                {
                    ShowError("No item selected");
                }
            }
            else
            {
                ShowError("Not an integer", "Input");
            }

            unsorted = true;
            SyncList();
        }



        #region FileManagement
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (FilePath.Text != "No file loaded.")
            {
                SaveFile();
            }
            else
            {
                saveAsDialog.ShowDialog();
            }
        }

        /// <summary>
        /// load
        /// </summary>
        private void MenuLoad_Click(object sender, EventArgs e)
        {
            loadFileDialog.ShowDialog();

        }



        /// <summary>
        /// Save as button in menu strip
        /// </summary>
        private void MenuSaveAs_Click(object sender, EventArgs e)
        {

            // Update the title of the form with the saved filename and path
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
            neutrinoList.Clear();
            using (StreamReader file = new StreamReader(FilePath.Text))
            {
                for (string? line = file.ReadLine(); line != null; line = file.ReadLine())
                {
                    if (int.TryParse(line, out int interaction))
                    {
                        neutrinoList.Add(interaction);
                    }
                    else
                    {
                        ShowError($"Error parsing file\nline: {line} is not an integer");
                        //reset neutrino list to what's in the list box.
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
        /// Load the file and initialise variables
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //set documents folder as default save path
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveAsDialog.InitialDirectory = documents;
            loadFileDialog.InitialDirectory = documents;
            SetPath(documents + "\\" + loadFileDialog.FileName);
            if (File.Exists(FilePath.Text))
            {
                LoadFile();
            }
            else
            {
                SetPath("No file loaded.");
                neutrinoList = GenerateNeutrinos();
            }
            SyncList();
            rdoSortAsc.Checked = true;
        }



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
        /// Updates listbox to reflect list.
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


        private void SaveAsSelected(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetPath(saveAsDialog.FileName);
            SaveFile();

        }

        private void LoadSelected(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetPath(loadFileDialog.FileName);
            LoadFile();

        }


        private void rdoSortAsc_CheckedChanged(object sender, EventArgs e)
        {
            unsorted = true;
        }
    }
}
