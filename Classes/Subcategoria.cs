using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Subcategoria
    {
        public int ID_Subcategoria { get; set; }
        public string Descricao { get; set; }
        public int ID_categoria { get; set; }
    }
}
