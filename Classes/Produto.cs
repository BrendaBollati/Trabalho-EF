using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Produto
    {
        public int ID_Produto { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Id_subcategoria { get; set; }
        public int ID_marca { get; set; }
        public int Id_unidade_medida { get; set; }
        public string EspecificacaoTecnica { get; set; }
        public string Statous { get; set; }
        public float PesoBruto { get; set; }
        public float PesoLiquido { get; set; }
        public int Qtd_Mult { get; set; }
        public int Qtd_Min { get; set; }
        public int Cod_Barras { get; set; }
    }
}
