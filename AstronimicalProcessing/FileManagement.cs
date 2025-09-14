using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronimicalProcessing
{
    internal class FileManager
    {

        string Path { get; set; }
        #region File
        private void SaveFile(List<int> neutrinoList
            )
        {
            using (StreamWriter file = new StreamWriter(Path))
            {
                foreach (int interaction in neutrinoList)
                {
                    file.WriteLine(interaction);
                }
            }
        }

        private  void LoadFile()
        {
            using (StreamReader file = new StreamReader(Path))
            {
                for (string? line = file.ReadLine(); line != null; line = file.ReadLine())
                    neutrinoList.Add(int.Parse(line.Trim()));
            }
        }
        #endregion
    }
}
