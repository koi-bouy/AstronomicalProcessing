namespace AT2_30099423
{
    partial class AstronomicalProcessing
    {

        /// <summary>
        /// load
        /// </summary>
        private void MenuLoad_Click(object sender, EventArgs e)
        {
            // Update the title of the form with the opened filename and path
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set the file path to the selected file
                SetPath(loadFileDialog.FileName);
                // Load the file
                LoadFile();
            }
        }



        /// <summary>
        /// Save as button in menu strip
        /// </summary>
        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            
            // Update the title of the form with the saved filename and path
            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                // set the file path to the selected file
                SetPath(saveAsDialog.FileName);
                SaveFile();
            }



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
    }
}
