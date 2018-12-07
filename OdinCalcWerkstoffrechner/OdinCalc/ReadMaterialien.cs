using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdinCalc
{
    static class ReadMaterialien
    {
        /// <summary>
        /// Read Materialien from CSV file to Dictionary
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Material> GetAllMaterialien()
        {
            Dictionary<string, Material> materialListe = new Dictionary<string, Material>();
            StreamReader streamReader = new StreamReader("Materialien.csv");

            string rowValue;
            string[] cellValue;
            try
            {
                while (streamReader.Peek() != -1)
                {
                    rowValue = streamReader.ReadLine();
                    cellValue = rowValue.Split(';');

                    Material material = new Material(cellValue[0], cellValue[2], Double.Parse(cellValue[1]));
                    materialListe.Add(material.name, material);
                }
            }
            catch(Exception ex)
            {
                streamReader.Close();
                MessageBox.Show("Materialliste konnte nicht gelesen werden!\n"+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            streamReader.Close();
            return materialListe;           
        }
    }
}
