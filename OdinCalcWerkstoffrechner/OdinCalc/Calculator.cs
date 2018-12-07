using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdinCalc
{
    class Calculator
    {
        Form1 form;
        public Calculator(Form1 form)
        {
            this.form = form;
        }

        public void CreateCalcManuel(Rechnung rechnung)
        {
            if(rechnung.dichte == 0.0)
            {
                rechnung.dichte = rechnung.GetDichte();
                form.tb_dichte.Text = rechnung.dichte.ToString();
            }else if(rechnung.volumen == 0.0)
            {
                rechnung.volumen = rechnung.GetVolumen();
                form.tb_volumen.Text = rechnung.volumen.ToString();
            }else if(rechnung.masse == 0.0)
            {
                rechnung.masse = rechnung.GetMasse();
                form.tb_gewicht.Text = rechnung.masse.ToString();
            }

            PrePostMaterialien(rechnung.dichte);
        }

        public void CreateCalcVorgabe(Rechnung rechnung)
        {
            form.tb_dichte.Text = rechnung.dichte.ToString();
            if(rechnung.volumen == 0.0)
            {
                form.tb_volumen.Text = rechnung.GetVolumen().ToString();
            }else if(rechnung.masse == 0.0)
            {
                form.tb_gewicht.Text = rechnung.GetMasse().ToString();
            }

            PrePostMaterialien(rechnung.dichte);
        }


        private void PrePostMaterialien(double dichte)
        {
            List<KeyValuePair<string, double>> sortedList = new List<KeyValuePair<string, double>>();
            Material[] prepostlist = new Material[3];

            foreach (KeyValuePair<string, Material> pair in form.materialListe)
            {
                sortedList.Add(new KeyValuePair<string, double>(pair.Value.name, pair.Value.dichte));
            }

            sortedList.Sort(delegate (KeyValuePair<string, double> pair1, KeyValuePair<string, double> pair2)
            {
                return pair1.Value.CompareTo(pair2.Value);
            });

            KeyValuePair<string, double> temp;
            double[] difList = GetDifList(sortedList, dichte);
            int index = GetMinDifIndex(difList);



            if (sortedList.Count > 1)
            {
                if (index > 0 && index < sortedList.Count - 1)
                {
                    prepostlist[0] = form.materialListe[sortedList[index - 1].Key];
                    prepostlist[1] = form.materialListe[sortedList[index].Key];
                    prepostlist[2] = form.materialListe[sortedList[index + 1].Key];
                }
                else if (index == 0)
                {
                    prepostlist[0] = new Material("---", "---", 0);
                    prepostlist[1] = form.materialListe[sortedList[index].Key];
                    prepostlist[2] = form.materialListe[sortedList[index + 1].Key];
                }
                else if (index == sortedList.Count - 1)
                {
                    prepostlist[0] = form.materialListe[sortedList[index - 1].Key];
                    prepostlist[1] = form.materialListe[sortedList[index].Key];
                    prepostlist[2] = new Material("---", "---", 0);
                }else if (index > sortedList.Count - 1)
                {
                    prepostlist[0] = form.materialListe[sortedList[index - 2].Key];
                    prepostlist[1] = form.materialListe[sortedList[index - 1].Key];
                    prepostlist[2] = new Material("---", "---", 0);
                }

                FillPrePostList(prepostlist);
            }                  
        }

        /// <summary>
        /// Get the difference from the value and the "dichte"
        /// </summary>
        /// <param name="sortedList"></param>
        /// <param name="dichte"></param>
        /// <returns></returns>
        private double[] GetDifList(List<KeyValuePair<string, double>> sortedList, double dichte)
        {
            double[] difList = new double[sortedList.Count];
            int counter = 0;
            foreach(KeyValuePair<string, double> pair in sortedList)
            {
                difList[counter] = System.Math.Abs(pair.Value - dichte);
                counter++;
            }
            return difList;
        }

        /// <summary>
        /// Get Min Value from de difList
        /// </summary>
        /// <param name="difList"></param>
        /// <returns></returns>
        private int GetMinDifIndex(double[] difList)
        {
            double min = difList.Min();
            for(int i = 0; i < difList.Length; i++)
            {
                if(min == difList[i])
                {
                    return i;
                }
            }
            return 0;
        }

        /// <summary>
        /// Fill PrePostList in UI
        /// </summary>
        /// <param name="prepostlist"></param>
        private void FillPrePostList(Material[] prepostlist)
        {
            form.lv_Materialien.Items.Clear();
            foreach(Material material in prepostlist)
            {
                ListViewItem item = new ListViewItem(material.name);
                item.SubItems.Add(material.dichte.ToString());
                item.SubItems.Add(material.werkstoffklasse);

                form.lv_Materialien.Items.Add(item);
            }
        }
    }
}
