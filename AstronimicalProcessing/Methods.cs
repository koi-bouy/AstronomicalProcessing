
namespace AstronimicalProcessing;
partial class AstronomicalProcessing
{

    protected override void OnLoad(EventArgs e)
    {
        neutrinoList = GenerateNeutrinos();
        Display();
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


}