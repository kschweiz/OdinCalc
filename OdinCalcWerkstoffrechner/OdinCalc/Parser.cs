using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdinCalc
{
    static class Parser
    {
        public static Dictionary<string, double> Pars(string dichte, string volumen, string masse)
        {
            Dictionary<string, double> werte = new Dictionary<string, double>();
            try
            {
                if (dichte == "")
                {
                    werte["dichte"] = 0.0;
                    werte["volumen"] = Double.Parse(volumen);
                    werte["masse"] = Double.Parse(masse);
                }
                if (volumen == "")
                {
                    werte["volumen"] = 0.0;
                    werte["dichte"] = Double.Parse(dichte);
                    werte["masse"] = Double.Parse(masse);
                }
                if (masse == "")
                {
                    werte["masse"] = 0.0;
                    werte["dichte"] = Double.Parse(dichte);
                    werte["volumen"] = Double.Parse(volumen);
                }

                return werte;
            }
            catch
            {
                MessageBox.Show("Falsche Angaben! Geben Sie Zahlen ein!", "Falsche Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            
        }

        public static Dictionary<string, double> Pars(double dichte, string volumen, string masse)
        {
            Dictionary<string, double> werte = new Dictionary<string, double>();
            try
            {
                if (volumen == "")
                {
                    werte["volumen"] = 0.0;
                    werte["dichte"] = dichte;
                    werte["masse"] = Double.Parse(masse);
                }
                if (masse == "")
                {
                    werte["masse"] = 0.0;
                    werte["dichte"] = dichte;
                    werte["volumen"] = Double.Parse(volumen);
                }
            }
            catch
            {
                MessageBox.Show("Falsche Angaben! Geben Sie Zahlen ein!", "Falsche Angaben", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return werte;
        }
    }
}
