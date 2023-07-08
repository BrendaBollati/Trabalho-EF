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
    public partial class FormularioSubcategoria : Form
    {
        private SubcategoriaControle subcategoriaControle;
        public FormularioSubcategoria()
        {
            InitializeComponent();
            subcategoriaControle = new SubcategoriaControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<Subcategoria> subcategorias = subcategoriaControle.GetAllSubcategoria();
            dtgrdvwSub.DataSource = subcategorias;
        }

        private void bttnGravarSub_Click(object sender, EventArgs e)
        {
            Subcategoria subcategoria = new Subcategoria();
            subcategoria.Descricao = txtbDesSub.Text;
            subcategoria.ID_categoria = int.Parse(txtbidCatSub.Text);
            AtualizarDtGrdVw();
        }

        private void bttnNovoSub_Click(object sender, EventArgs e)
        {
            if (dtgrdvwSub.SelectedRows.Count > 0)
            {
                int index = dtgrdvwSub.SelectedRows[0].Index;
                Subcategoria subcategoria = (Subcategoria)dtgrdvwSub.Rows[index].DataBoundItem;
                subcategoria.Descricao = txtbDesSub.Text;
                subcategoria.ID_categoria = int.Parse(txtbidCatSub.Text);
                subcategoriaControle.UpdateSubcategoria(subcategoria);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverSub_Click(object sender, EventArgs e)
        {
            if (dtgrdvwSub.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwSub.SelectedRows[0];
                int subcategoriaID = Convert.ToInt32(selectedRow.Cells["ID_Subcategoria"].Value);
                subcategoriaControle.RemoveSubcategoria(subcategoriaID);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarSub_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
