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
    public partial class FormularioMarca : Form
    {
        private MarcaControle marcaControle;
        public FormularioMarca()
        {
            InitializeComponent();
            marcaControle = new MarcaControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<Marca> marcas = marcaControle.GetAllMarca();
            dtgrdvwMar.DataSource = marcas;
        }

        private void bttnGravarMar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Descricao = txtbDesMar.Text;
            marcaControle.InsertMarca(marca);
            AtualizarDtGrdVw();
        }

        private void bttnNovoMar_Click(object sender, EventArgs e)
        {
            if (dtgrdvwMar.SelectedRows.Count > 0)
            {
                int index = dtgrdvwMar.SelectedRows[0].Index;
                Marca marca = (Marca)dtgrdvwMar.Rows[index].DataBoundItem;
                marca.Descricao = dtgrdvwMar.Text;
                marcaControle.UpdateMarca(marca);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverMar_Click(object sender, EventArgs e)
        {
            if (dtgrdvwMar.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwMar.SelectedRows[0];
                int marcaID = Convert.ToInt32(selectedRow.Cells["ID_Marca"].Value);
                marcaControle.RemoveMarca(marcaID);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarMar_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
