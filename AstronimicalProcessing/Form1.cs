namespace _30099423_AT2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            ListBoxNeutrinos.Items.Clear();
            for (int i = 1; i <= 24; i++)
                ListBoxNeutrinos.Items.Add(rand.Next(10, 91).ToString());
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
        }
    }
}
