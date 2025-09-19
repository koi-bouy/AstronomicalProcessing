namespace AT2_30099423
{
    public partial class AstronomicalProcessing : Form
    {
        private List<int> neutrinoList = new List<int>();
        private bool sorted = false;
        public AstronomicalProcessing()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Sorts the neutrino list ascending or descending based on the radio buttons.
        /// </summary>
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Algorithms.BubbleSort(neutrinoList, rdoSortAsc.Checked);
            UpdateList();
        }

        /// <summary>
        /// Search the list, sorting if the list isn't sorted already.
        /// </summary>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {



            int input = int.Parse(TextBoxSearch.Text);

            //sort the list if it isn't already
            bool asc = rdoSortAsc.Checked;
            if (!sorted)
                Algorithms.BubbleSort(neutrinoList, asc);

            //Use binary search method to get index. Will be -1 if the item can't be found.
            int index = Algorithms.BinarySearch(neutrinoList, input, asc);
            UpdateList();

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

        /// <summary>
        /// Generate new
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            neutrinoList = GenerateNeutrinos();
            sorted = false;
            UpdateList();
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
            if (TextBoxEditValue.Text.Trim() == "")
            {
                MessageBox.Show("Enter");
            }
            neutrinoList[ListBoxNeutrinos.SelectedIndex] = int.Parse(TextBoxEditValue.Text);
            sorted = false;
            UpdateList();
        }

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
                MenuSaveAs_Click(sender, e); 
            }
        }


    }
}
