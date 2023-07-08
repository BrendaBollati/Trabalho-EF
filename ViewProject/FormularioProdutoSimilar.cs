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
    public partial class FormularioProdutoSimilar : Form
    {
        private ProdutoSimilarControle produtoSimilarControle;
        public FormularioProdutoSimilar()
        {
            InitializeComponent();
            produtoSimilarControle = new ProdutoSimilarControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<ProdutoSimilar> produtoSimilares = produtoSimilarControle.GetAllProdutoSimilar();
            dtgrdvwProSim.DataSource = produtoSimilares;
        }

        private void bttnGravarProSim_Click(object sender, EventArgs e)
        {
            ProdutoSimilar produtoSimilar = new ProdutoSimilar();
            produtoSimilar.ID_Produto = int.Parse(txtbidProProSim.Text);
            produtoSimilar.ID_produto_similar = int.Parse(txtbProSim.Text);
            AtualizarDtGrdVw();
        }

        private void bttnNovoProSim_Click(object sender, EventArgs e)
        {
            if (dtgrdvwProSim.SelectedRows.Count > 0)
            {
                int index = dtgrdvwProSim.SelectedRows[0].Index;
                ProdutoSimilar produtoSimilar = (ProdutoSimilar)dtgrdvwProSim.Rows[index].DataBoundItem;
                produtoSimilar.ID_produto_similar = int.Parse(txtbProSim.Text);
                produtoSimilarControle.UpdateProdutoSimilar(produtoSimilar);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverProSim_Click(object sender, EventArgs e)
        {
            if (dtgrdvwProSim.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwProSim.SelectedRows[0];
                int produtoSimilarID = Convert.ToInt32(selectedRow.Cells["ID_ProdutoSimilar"].Value);
                produtoSimilarControle.RemoveProdutoSimilar(produtoSimilarID);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarProSim_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
