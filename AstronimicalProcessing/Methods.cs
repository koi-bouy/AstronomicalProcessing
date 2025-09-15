namespace AT2_30099423;
partial class AstronomicalProcessing
{
    /// <summary>
    /// Load the file and initialise variables
    /// </summary>
    protected override void OnLoad(EventArgs e)
    {
        if (File.Exists(filePath))
        {
            LoadFile();
        }
        FilePath.Text = filePath;
        neutrinoList = GenerateNeutrinos();
        UpdateList();
        rdoSortAsc.Checked = true;
    }

    /// <summary>
    /// Save to file on close
    /// </summary>
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        SaveFile();
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
    /// 
    /// </summary>
    private void UpdateList()
    {
        ListBoxNeutrinos.Items.Clear();
        foreach (int interaction in neutrinoList)
        {
            ListBoxNeutrinos.Items.Add(interaction);
        }
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


}