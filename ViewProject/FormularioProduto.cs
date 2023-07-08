using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Classes;
using ControlerProject;

namespace ViewProject
{
    public partial class FormularioProduto : Form
    {
        private ProdutoControle produtoControle;

        public FormularioProduto()
        {
            InitializeComponent();
            produtoControle = new ProdutoControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<Produto> produtos = produtoControle.GetAllProduto();
            dtgrdvwPro.DataSource = produtos;
        }

        private void bttnGravar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Codigo = int.Parse(txtbprodCod.Text);
            produto.Descricao = txtbprodDes.Text;
            produto.Id_subcategoria = int.Parse(txtbprodSubID.Text);
            produto.ID_marca = int.Parse(txtbprodMar.Text);
            produto.Id_unidade_medida = int.Parse(txtbprodUniMed.Text);
            produto.EspecificacaoTecnica= txtbprodEspTec.Text;
            produto.Statous = txtbprodStatus.Text;
            produto.PesoBruto = float.Parse(txtbPesBru.Text);
            produto.PesoLiquido = float.Parse(txtbprodPesLiq.Text);
            produto.Qtd_Mult = int.Parse(txtbprodQtdMult.Text);
            produto.Qtd_Min = int.Parse(txtbprodQtdMin.Text);
            produto.Cod_Barras = int.Parse(txtbprodCodBar.Text);
            AtualizarDtGrdVw();
        }

        private void bttnNovo_Click(object sender, EventArgs e)
        {
            if (dtgrdvwPro.SelectedRows.Count > 0)
            {
                int index = dtgrdvwPro.SelectedRows[0].Index;
                Produto produto = (Produto)dtgrdvwPro.Rows[index].DataBoundItem;
                produto.Codigo = int.Parse(txtbprodCod.Text);
                produto.Descricao = txtbprodDes.Text;
                produto.Id_subcategoria = int.Parse(txtbprodSubID.Text);
                produto.ID_marca = int.Parse(txtbprodMar.Text);
                produto.Id_unidade_medida = int.Parse(txtbprodUniMed.Text);
                produto.EspecificacaoTecnica = txtbprodEspTec.Text;
                produto.Statous = txtbprodStatus.Text;
                produto.PesoBruto = float.Parse(txtbPesBru.Text);
                produto.PesoLiquido = float.Parse(txtbprodPesLiq.Text);
                produto.Qtd_Mult = int.Parse(txtbprodQtdMult.Text);
                produto.Qtd_Min = int.Parse(txtbprodQtdMin.Text);
                produto.Cod_Barras = int.Parse(txtbprodCodBar.Text);
                produtoControle.UpdateProduto(produto);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemover_Click(object sender, EventArgs e)
        {
            if (dtgrdvwPro.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwPro.SelectedRows[0];
                int produtoID = Convert.ToInt32(selectedRow.Cells["ID_Produto"].Value);
                produtoControle.RemoveProduto(produtoID);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarPro_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
