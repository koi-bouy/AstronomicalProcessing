namespace AT2_30099423
{
    partial class AstronomicalProcessing
    {

        string filePath = "NeutrinoInteractions.txt";

        /// <summary>
        /// 
        /// </summary>
        private void MenuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog
            {
                // title of the dialog box
                Title = "Select File Containing Neutrino Interactions",

                // a warning will be given if a file does not exist
                CheckFileExists = true,
                // a warning will be given if a path does not exist
                CheckPathExists = true,

                // sets the default extension to txt
                DefaultExt = "txt",
                // filter only shows txt files by default, but allows all files.
                Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*",
                FilterIndex = 2,
                // current directory is restored on closing
                RestoreDirectory = true,

                // ReadOnlyChecked property represents whether the read-only checkbox is selected
                // ShowReadOnly property represents whether the read-only checkbox is available or not
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            // Update the title of the form with the opened filename and path
            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set the file path to the selected file
                setPath(loadFileDialog.FileName);
                // Load the file
                LoadFile();
            }
        }



        /// <summary>
        /// The save as option with save file dialog example
        /// </summary>
        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                // title of the dialog box
                Title = "Browse Text Files",

                // a warning will be given if a path does not exist
                CheckPathExists = true,

                // sets the default extension to txt
                DefaultExt = "txt",

                // filter only shows txt files
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,

                // current directory is restored on closing
                RestoreDirectory = true,

            };

            // Update the title of the form with the saved filename and path
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // set the file path to the selected file
                setPath(saveFileDialog.FileName);
                SaveFile();
            }



        }

        /// <summary>
        /// Write Neutrino list to file
        /// </summary>
        public void SaveFile()
        {
            using (StreamWriter file = new StreamWriter(filePath))
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
            using (StreamReader file = new StreamReader(filePath))
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
        private void setPath(string newPath)
        {
            filePath = newPath;
            FilePath.Text = filePath;
            FilePathWrap.Text = filePath;
            FilePath.Height = FilePathWrap.Height + FilePath.Margin.Vertical;
            FilePath.Width = FilePathWrap.Width;
        }
    }
}
