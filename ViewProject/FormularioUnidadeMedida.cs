using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using ControlerProject;

namespace ViewProject
{
    public partial class FormularioUnidadeMedida : Form
    {
        private UnidadeMedidaControle unidadeMedidaControle;
        public FormularioUnidadeMedida()
        {
            InitializeComponent();
            unidadeMedidaControle = new UnidadeMedidaControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<UnidadeMedida> unidadeMedidas = unidadeMedidaControle.GetAllUnidadeMedida();
            dtgrdvwUniMed.DataSource = unidadeMedidas;
        }

        private void bttngravarUniMed_Click(object sender, EventArgs e)
        {
            UnidadeMedida unidadeMedida = new UnidadeMedida();
            unidadeMedida.Descricao = txtbDesUniMed.Text;
            unidadeMedida.ID_produto = int.Parse(txtbidProUniMed.Text);
            AtualizarDtGrdVw();
        }

        private void bttnNovoUniMed_Click(object sender, EventArgs e)
        {
            if (dtgrdvwUniMed.SelectedRows.Count > 0)
            {
                int index = dtgrdvwUniMed.SelectedRows[0].Index;
                UnidadeMedida unidadeMedida = (UnidadeMedida)dtgrdvwUniMed.Rows[index].DataBoundItem;
                unidadeMedida.Descricao = txtbDesUniMed.Text;
                unidadeMedida.ID_produto = int.Parse(txtbidProUniMed.Text);
                unidadeMedidaControle.UpdateUnidadeMedida(unidadeMedida);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverUniMed_Click(object sender, EventArgs e)
        {
            if (dtgrdvwUniMed.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwUniMed.SelectedRows[0];
                int produtoId = Convert.ToInt32(selectedRow.Cells["ID_UnidadeMedida"].Value);
                unidadeMedidaControle.RemoveUnidadeMedida(produtoId);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarUniMed_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
