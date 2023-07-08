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
    public partial class FormularioDepartamento : Form
    {
        private DepartamentoControle departamentoControle;
        public FormularioDepartamento()
        {
            InitializeComponent();
            departamentoControle = new DepartamentoControle();
            AtualizarDtGrdVw();
        }
        private void AtualizarDtGrdVw()
        {
            List<Departamento> departamentos = departamentoControle.GetAllDepartamento();
            dtgrdvwDep.DataSource = departamentos;
        }

        private void bttnGravarDep_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();
            departamento.Descricao = txtbDesDep.Text;
            departamentoControle.InsertDepartamento(departamento);
            AtualizarDtGrdVw();
        }

        private void bttnNovoDep_Click(object sender, EventArgs e)
        {
            if (dtgrdvwDep.SelectedRows.Count > 0)
            {
                int index = dtgrdvwDep.SelectedRows[0].Index;
                Departamento departamento = (Departamento)dtgrdvwDep.Rows[index].DataBoundItem;
                departamento.Descricao = dtgrdvwDep.Text;            
                departamentoControle.UpdateDepartamento(departamento);
                AtualizarDtGrdVw();
            }
        }

        private void bttnRemoverDep_Click(object sender, EventArgs e)
        {
            if (dtgrdvwDep.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgrdvwDep.SelectedRows[0];
                int departamentoId = Convert.ToInt32(selectedRow.Cells["ID_Departamento"].Value);
                departamentoControle.RemoveDepartamento(departamentoId);
                AtualizarDtGrdVw();
            }
        }

        private void bttnVoltarDep_Click(object sender, EventArgs e)
        {
            FormularioTelaInicial formularioTelaInicial = new FormularioTelaInicial();
            formularioTelaInicial.Show();
            this.Hide();
        }
    }
}
