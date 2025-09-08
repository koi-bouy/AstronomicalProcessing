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

        protected override void OnLoad(EventArgs e)
        {
            Display();
            rdoSortAsc.Checked = true;
        }

        #region Algorthims
        private void BubbleSort(List<int> list, bool asc = true)
        {
            int max = list.Count;
            int temp;
            for (int end = max; end > 0; end--)
            {
                for (int i = 0, j = 1; j < max; i++, j++)
                {
                    if (asc ? list[i] > list[j] : list[i] < list[j])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
        private int BinarySearch(List<int> list, int search)
        {
            if (!sorted)
            {
                BubbleSort(list, asc);
            }

            int start = 0, end = list.Count() - 1;
            int maxLoops = end > 0 ? (int)Math.Ceiling(Math.Log2(list.Count())) : 0;
            for (int i = 0; i < maxLoops; i++)
            {
                int middle = (start + end) / 2;
                if (asc ? list[middle] > search : list[middle] < search)
                {
                    end = middle + 1;
                }
                else if (asc ? list[middle] < search : list[middle] > search)
                {
                    start = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
        #endregion

        #region Controls
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            asc = rdoSortAsc.Checked;
            BubbleSort(this.neutrinoList, asc);
            Display();
        }
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            neutrinoList.Clear();
            for (int i = 1; i <= 24; i++)
            {
                this.neutrinoList.Add(rand.Next(10, 91));
            }
            sorted = false;
            Display();
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int input = int.Parse(TextBoxSearch.Text);
            int index = BinarySearch(neutrinoList, input);
            Display();
            if (index != -1)
            {
                TextBoxSearch.Clear();
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
        private void SelectNeutrino(object sender, EventArgs e)
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

        private void Display()
        {
            ListBoxNeutrinos.Items.Clear();
            foreach (int interaction in neutrinoList)
            {
                ListBoxNeutrinos.Items.Add(interaction);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error");
        }

        #region File
        private void SaveFile(string path)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                foreach (int interaction in neutrinoList)
                {
                    file.WriteLine(interaction);
                }
            }
        }

        private void LoadFile(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                for (string? line = file.ReadLine(); line != null; line = file.ReadLine())
                    neutrinoList.Add(int.Parse(line.Trim()));
            }
        }
        #endregion
    }
}
