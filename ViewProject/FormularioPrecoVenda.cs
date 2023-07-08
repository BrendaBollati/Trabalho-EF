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
    public partial class FormularioPrecoVenda : Form
    {
        private PrecoVendaControle precoVendaControle;
        public FormularioPrecoVenda()
        {
            InitializeComponent();
            precoVendaControle = new PrecoVendaControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<PrecoVenda> precoVendas = precoVendaControle.GetAllPrecoVenda();
            dtgrdvwPreVen.DataSource = precoVendas;
        }

        private void bttnGravarPreVen_Click(object sender, EventArgs e)
        {
            PrecoVenda precoVenda = new PrecoVenda();
            precoVenda.ID_produto = int.Parse(txtbidProPreVen.Text);
            precoVenda.preco_venda = float.Parse(txtbPreVen.Text);
            precoVenda.data_validade_inicial = int.Parse(txtbValIniPreVen.Text);
            precoVenda.data_validade_final = int.Parse(txtbValFinPreVen.Text);
            precoVendaControle.InsertPrecoVenda(precoVenda);
            AtualizarDtGrdVw();
        }

        private void bttnNovoPreVen_Click(object sender, EventArgs e)
        {
            if (dtgrdvwPreVen.SelectedRows.Count > 0)
            {
                int index = dtgrdvwPreVen.SelectedRows[0].Index;
                PrecoVenda precoVenda = (PrecoVenda)dtgrdvwPreVen.Rows[index].DataBoundItem;
                precoVenda.ID_produto = int.Parse(txtbidProPreVen.Text);
                precoVenda.preco_venda = float.Parse(txtbPreVen.Text);
                precoVenda.data_validade_inicial = int.Parse(txtbValIniPreVen.Text);
                precoVenda.data_validade_final = int.Parse(txtbValFinPreVen.Text);
                precoVendaControle.UpdatePrecoVenda(precoVenda);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverPreVen_Click(object sender, EventArgs e)
        {
            if (dtgrdvwPreVen.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwPreVen.SelectedRows[0];
                int precoVendaID = Convert.ToInt32(selectedRow.Cells["ID_PrecoVenda"].Value);
                precoVendaControle.RemovePrecoVenda(precoVendaID);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarPreVen_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
