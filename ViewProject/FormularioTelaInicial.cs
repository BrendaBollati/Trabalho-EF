using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormularioTelaInicial : Form
    {
        public FormularioTelaInicial()
        {
            InitializeComponent();
            radiobttnCat.AutoCheck = false;
            radiobttnDep.AutoCheck = false;
            radiobttnMar.AutoCheck = false;
            radiobttnPecVen.AutoCheck = false;
            radiobttnPro.AutoCheck = false;
            radiobttnProSim.AutoCheck = false;
            radiobttnSub.AutoCheck = false;
            radiobttnUniMed.AutoCheck = false;
        }

        private void radiobttnCat_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnCat.Checked)
            {
                FormularioCategoria formularioCategoria = new FormularioCategoria();
                formularioCategoria.Show();
                this.Hide();
            }
        }

        private void radiobttnDep_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnDep.Checked)
            {
                FormularioDepartamento formularioDepartamento = new FormularioDepartamento();
                formularioDepartamento.Show();
                this.Hide();
            }
        }

        private void radiobttnMar_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnMar.Checked)
            {
                FormularioMarca formularioMarca = new FormularioMarca();
                formularioMarca.Show();
                this.Hide();
            }
        }

        private void radiobttnPecVen_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnPecVen.Checked)
            {
                FormularioPrecoVenda formularioPrecoVenda = new FormularioPrecoVenda();
                formularioPrecoVenda.Show();
                this.Hide();
            }
        }

        private void radiobttnPro_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnPro.Checked)
            {
                FormularioProduto formularioProduto = new FormularioProduto();
                formularioProduto.Show();
                this.Hide();
            }
        }

        private void radiobttnProSim_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnProSim.Checked)
            {
                FormularioProdutoSimilar formularioProdutoSimilar = new FormularioProdutoSimilar();
                formularioProdutoSimilar.Show();
                this.Hide();
            }
        }

        private void radiobttnSub_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnSub.Checked)
            {
                FormularioSubcategoria formularioSubcategoria = new FormularioSubcategoria();
                formularioSubcategoria.Show();
                this.Hide();
            }
        }

        private void radiobttnUniMed_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobttnUniMed.Checked)
            {
                FormularioUnidadeMedida formularioUnidadeMedida = new FormularioUnidadeMedida();
                formularioUnidadeMedida.Show();
                this.Hide();
            }
        }

        private void FormularioTelaInicial_Load(object sender, EventArgs e)
        {
            radiobttnCat.AutoCheck = true;
            radiobttnDep.AutoCheck = true;
            radiobttnMar.AutoCheck = true;
            radiobttnPecVen.AutoCheck = true;
            radiobttnPro.AutoCheck = true;
            radiobttnProSim.AutoCheck = true;
            radiobttnSub.AutoCheck = true;
            radiobttnUniMed.AutoCheck = true;
        }
    }
}
