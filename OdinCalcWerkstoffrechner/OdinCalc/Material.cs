using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinCalc
{
    public class Material
    {
        public string name { get;  }
        public string werkstoffklasse { get;  }
        public double dichte { get;  }

        public Material(string name, string werkstoffklasse, double dichte)
        {
            this.name = name;
            this.werkstoffklasse = werkstoffklasse;
            this.dichte = dichte;
        }
    }
}
