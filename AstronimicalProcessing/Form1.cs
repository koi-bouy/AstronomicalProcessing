namespace AstronimicalProcessing
{
    public partial class AstronomicalProcessing : Form
    {
        List<int> neutrinoList = new List<int>();
        bool asc = true;
        bool sorted = false;
        public AstronomicalProcessing()
        {
            InitializeComponent();
        }


        

        #region Controls
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            asc = rdoSortAsc.Checked;
            Algorithms.BubbleSort(neutrinoList, asc);
            Display();
        }
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            neutrinoList = GenerateNeutrinos();
            sorted = false;
            Display();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int input = int.Parse(TextBoxSearch.Text);
            if (!sorted)
                Algorithms.BubbleSort(neutrinoList, asc);
            int index = Algorithms.BinarySearch(neutrinoList, input);
            Display();
            if (index != -1)
            {
                TextBoxSearch.Clear();
                MessageBox.Show($"{input} found at index: {index}!", "Search Success");
                ListBoxNeutrinos.SelectedIndex = index;
            }
            else
            {
                ShowError($"Could not find {input}");
            }
        }

        /// <summary>
        /// Puts the Selected item in the list box into the Edit text box
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
            Display();
        }
        #endregion
    }
}
