using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdinCalc
{
    /// <summary>
    /// Write new Material to CSV File
    /// </summary>
    static class WriteMaterialien
    {
        public static void WriteMaterialList(Dictionary<string, Material> materialListe)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("Materialien.csv");
                
                foreach(KeyValuePair<string, Material> pair in materialListe)
                {
                    string newRow = $"{pair.Value.name};{pair.Value.dichte};{pair.Value.werkstoffklasse}";
                    streamWriter.WriteLine(newRow);
                }

                streamWriter.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Neues Material konnte NICHT gespeichert werden!\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
