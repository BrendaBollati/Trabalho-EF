using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class PrecoVenda
    {
        public int ID_PrecoVenda { get; set; }
        public int ID_produto { get; set; }
        public float preco_venda { get; set; }
        public int data_validade_inicial { get; set; }
        public int data_validade_final { get; set; }
    }
}
