using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlerProject;
using Classes;

namespace ViewProject
{
    public partial class FormularioCategoria : Form
    {
        private CategoriaControle categoriaControle;

        public FormularioCategoria()
        {
            InitializeComponent();
            categoriaControle = new CategoriaControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<Categoria> categorias = categoriaControle.GetAllCategoria();
            dtgrdvwCat.DataSource = categorias;
        }

        private void bttnGravarCat_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Descricao = txtbDesCat.Text;
            categoria.ID_departamento = int.Parse(txtbidDepCat.Text);
            categoriaControle.InsertCategoria(categoria);
            AtualizarDtGrdVw();
        }

        private void bttnNovoCat_Click(object sender, EventArgs e)
        {
            if (dtgrdvwCat.SelectedRows.Count > 0)
            {
                int index = dtgrdvwCat.SelectedRows[0].Index;
                Categoria categoria = (Categoria)dtgrdvwCat.Rows[index].DataBoundItem;
                categoria.Descricao = txtbDesCat.Text;
                categoria.ID_departamento = int.Parse(txtbidDepCat.Text);

                categoriaControle.UpdateCategoria(categoria);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverCat_Click(object sender, EventArgs e)
        {
            if (dtgrdvwCat.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwCat.SelectedRows[0];
                int categoriaID = Convert.ToInt32(selectedRow.Cells["ID_Categoria"].Value);
                categoriaControle.RemoveCategoria(categoriaID);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarCat_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
