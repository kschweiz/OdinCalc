using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdinCalc
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Material> materialListe;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonMaterialListe.Checked = true;
            lb_material.Enabled = true;

            this.materialListe = ReadMaterialien.GetAllMaterialien();
            FillList(materialListe);
            
        }

        /// <summary>
        /// Fill MaterialList on GUI
        /// </summary>
        /// <param name="materialListe"></param>
        private void FillList(Dictionary<string, Material> materialListe)
        {
            lv_materialListe.Items.Clear();
            lb_material.Items.Clear();
            lb_material.Text = "";
            foreach(KeyValuePair<string, Material> pair in materialListe)
            {
                ListViewItem item = new ListViewItem(pair.Key);
                item.SubItems.Add(pair.Value.dichte.ToString());
                item.SubItems.Add(pair.Value.werkstoffklasse);

                lv_materialListe.Items.Add(item);

                lb_material.Items.Add(pair.Key);
            }
        }

        public void BerechnungMitListe()
        {
            if(lb_material.SelectedItem != null && (tb_gewicht.Text != "" || tb_volumen.Text != ""))
            {
                Dictionary<string, double> werte = Parser.Pars(materialListe[lb_material.SelectedItem.ToString()].dichte, tb_volumen.Text, tb_gewicht.Text);
                Rechnung rechnung = new Rechnung(werte["dichte"], werte["volumen"], werte["masse"]);
                Calculator calc = new Calculator(this);
                calc.CreateCalcVorgabe(rechnung);
            }
            else
            {
                MessageBox.Show("Ein Material sowie das Volumen oder die Masse müssen angegeben werden!", "Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
        public void BerechnungManuel()
        {
            if(!tb_dichte.Enabled || !tb_gewicht.Enabled || !tb_volumen.Enabled)
            {
                Dictionary<string, double> werte = Parser.Pars(tb_dichte.Text, tb_volumen.Text, tb_gewicht.Text);
                if(werte != null)
                {
                    Rechnung rechnung = new Rechnung(werte["dichte"], werte["volumen"], werte["masse"]);
                    Calculator calc = new Calculator(this);
                    calc.CreateCalcManuel(rechnung);
                }
                else
                {
                    MessageBox.Show("Falsches Format!", "Falsche Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Minedestens zwei Angaben müssen gemacht werden!", "Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tb_dichte_TextChanged(object sender, EventArgs e)
        {
            //Disable TB's
            if(tb_dichte.Text != "" && tb_volumen.Text != "" && tb_dichte.Enabled)
            {
                tb_gewicht.Enabled = false;
            }
            if (tb_dichte.Text != "" && tb_gewicht.Text != "" && tb_dichte.Enabled)
            {
                tb_volumen.Enabled = false;
            }
            if(tb_dichte.Text == "" && tb_volumen.Text != "" && tb_gewicht.Text != "" && tb_dichte.Enabled)
            {
                tb_dichte.Enabled = false;
            }

            //Enable TB's
            if(tb_dichte.Text == "" && tb_volumen.Text != "")
            {
                tb_gewicht.Enabled = true;
            }
            if (tb_dichte.Text == "" && tb_gewicht.Text != "")
            {
                tb_volumen.Enabled = true;
            }
        }

        private void tb_volumen_TextChanged(object sender, EventArgs e)
        {
            //Disable TB's
            if ((tb_volumen.Text != "" && tb_dichte.Text != "" && tb_volumen.Enabled) || (tb_volumen.Text != "" && radioButtonMaterialListe.Checked == true && tb_gewicht.Text == ""))
            {
                tb_gewicht.Enabled = false;
            }
            if (tb_volumen.Text != "" && tb_gewicht.Text != "" && tb_volumen.Enabled)
            {
                tb_dichte.Enabled = false;
            }
            if (tb_volumen.Text == "" && tb_dichte.Text != "" && tb_gewicht.Text != "" && tb_volumen.Enabled)
            {
                tb_volumen.Enabled = false;
            }

            //Enable TB's
            if (tb_volumen.Text == "" && tb_dichte.Text != "")
            {
                tb_gewicht.Enabled = true;
            }
            if (tb_volumen.Text == "" && tb_gewicht.Text != "" && radioButtonMaterialListe.Checked == false)
            {
                tb_dichte.Enabled = true;
            }
        }

        private void tb_gewicht_TextChanged(object sender, EventArgs e)
        {
            //Disable TB's
            if (tb_gewicht.Text != "" && tb_volumen.Text != "" && tb_gewicht.Enabled)
            {
                tb_dichte.Enabled = false;
            }
            if ((tb_gewicht.Text != "" && tb_dichte.Text != "" && tb_gewicht.Enabled) || (tb_gewicht.Text != "" && radioButtonMaterialListe.Checked == true && tb_volumen.Text == ""))
            {
                tb_volumen.Enabled = false;
            }
            if (tb_gewicht.Text == "" && tb_dichte.Text != "" && tb_volumen.Text != "" && tb_gewicht.Enabled)
            {
                tb_gewicht.Enabled = false;
            }

            //Enable TB's
            if (tb_gewicht.Text == "" && tb_volumen.Text != "" && radioButtonMaterialListe.Checked == false)
            {
                tb_dichte.Enabled = true;
            }
            if (tb_gewicht.Text == "" && tb_dichte.Text != "")
            {
                tb_volumen.Enabled = true;
            }
        }

        private void radioButtonMaterialListe_CheckedChanged(object sender, EventArgs e)
        {
            tb_dichte.Clear();
            tb_gewicht.Clear();
            tb_volumen.Clear();
            tb_dichte.Enabled = false;
            tb_volumen.Enabled = true;
            tb_gewicht.Enabled = true;
            lb_material.Enabled = true;
            
        }

        private void radioButtonManuel_CheckedChanged(object sender, EventArgs e)
        {
            tb_dichte.Clear();
            tb_gewicht.Clear();
            tb_volumen.Clear();
            tb_dichte.Enabled = true;
            tb_volumen.Enabled = true;
            tb_gewicht.Enabled = true;

            lb_material.Enabled = false;
        }


        /// <summary>
        /// Calculate 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_calculate_Click(object sender, EventArgs e)
        {
            if(tb_dichte.Text != "" && tb_volumen.Text != "" && tb_gewicht.Text != "")
            {
                MessageBox.Show("Mindestens ein Feld muss leer sein!", "Rechnung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (radioButtonManuel.Checked == true)
                {
                    BerechnungManuel();
                }
                else
                {
                    BerechnungMitListe();
                }
            }
        }

        /// <summary>
        /// Clear List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearList_Click(object sender, EventArgs e)
        {
            lv_Materialien.Items.Clear();
        }


        /// <summary>
        /// Write Dichte from Selected Item to tb_dichte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_dichte.Text = materialListe[lb_material.SelectedItem.ToString()].dichte.ToString();
        }

        /// <summary>
        /// Clear all --> Liste & Felder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_clearAll_Click(object sender, EventArgs e)
        {
            lv_Materialien.Items.Clear();
            tb_dichte.Clear();
            tb_gewicht.Clear();
            tb_volumen.Clear();
        }

        /// <summary>
        /// Create New Material
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_newMaterial_Click(object sender, EventArgs e)
        {
            double testDouble;
            if(tb_erstellenDichte.Text != "" && tb_erstellenMaterialName.Text != "" && tb_erstellenWerkstoffklasse.Text != "" && Double.TryParse(tb_erstellenDichte.Text, out testDouble) && !materialListe.ContainsKey(tb_erstellenMaterialName.Text))
            {
                Material material = new Material(tb_erstellenMaterialName.Text, tb_erstellenWerkstoffklasse.Text, Double.Parse(tb_erstellenDichte.Text));
                materialListe.Add(material.name, material);
                WriteMaterialien.WriteMaterialList(materialListe);
                FillList(materialListe);

                tb_erstellenDichte.Clear();
                tb_erstellenMaterialName.Clear();
                tb_erstellenWerkstoffklasse.Clear();
            }
            else
            {
                MessageBox.Show("Materialname schon vorhanden oder falsches Format!", "Falsche Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Delete Material
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deleteMaterial_Click(object sender, EventArgs e)
        {
            if(lv_materialListe.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wählen Sie ein Material aus!", "Delete Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListViewItem item = lv_materialListe.SelectedItems[0];
                Material material = new Material(item.SubItems[0].Text, item.SubItems[2].Text, Double.Parse(item.SubItems[1].Text));
                materialListe.Remove(material.name);
                DeleteMaterialien.Delete(materialListe);
                FillList(materialListe);
            }
        }
    }
}
