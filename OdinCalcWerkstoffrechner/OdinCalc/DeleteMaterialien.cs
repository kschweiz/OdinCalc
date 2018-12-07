using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinCalc
{
    //Diese Klasse löscht ein Material
    static class DeleteMaterialien
    {
        public static void Delete(Dictionary<string, Material> materialListe)
        {
            WriteMaterialien.WriteMaterialList(materialListe);
        }
    }
}
