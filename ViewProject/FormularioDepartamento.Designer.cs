
namespace ViewProject
{
    partial class FormularioDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloDep = new System.Windows.Forms.Label();
            this.lblDesDep = new System.Windows.Forms.Label();
            this.lblidDep = new System.Windows.Forms.Label();
            this.txtbidDep = new System.Windows.Forms.TextBox();
            this.txtbDesDep = new System.Windows.Forms.TextBox();
            this.bttnGravarDep = new System.Windows.Forms.Button();
            this.bttnVoltarDep = new System.Windows.Forms.Button();
            this.bttnNovoDep = new System.Windows.Forms.Button();
            this.bttnRemoverDep = new System.Windows.Forms.Button();
            this.dtgrdvwDep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwDep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDep
            // 
            this.lblTituloDep.AutoSize = true;
            this.lblTituloDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDep.ForeColor = System.Drawing.Color.Green;
            this.lblTituloDep.Location = new System.Drawing.Point(54, 9);
            this.lblTituloDep.Name = "lblTituloDep";
            this.lblTituloDep.Size = new System.Drawing.Size(159, 25);
            this.lblTituloDep.TabIndex = 0;
            this.lblTituloDep.Text = "Departamento";
            // 
            // lblDesDep
            // 
            this.lblDesDep.AutoSize = true;
            this.lblDesDep.Location = new System.Drawing.Point(12, 87);
            this.lblDesDep.Name = "lblDesDep";
            this.lblDesDep.Size = new System.Drawing.Size(58, 13);
            this.lblDesDep.TabIndex = 1;
            this.lblDesDep.Text = "Descrição:";
            // 
            // lblidDep
            // 
            this.lblidDep.AutoSize = true;
            this.lblidDep.Location = new System.Drawing.Point(12, 61);
            this.lblidDep.Name = "lblidDep";
            this.lblidDep.Size = new System.Drawing.Size(91, 13);
            this.lblidDep.TabIndex = 2;
            this.lblidDep.Text = "ID Departamento:";
            // 
            // txtbidDep
            // 
            this.txtbidDep.Location = new System.Drawing.Point(109, 58);
            this.txtbidDep.Name = "txtbidDep";
            this.txtbidDep.Size = new System.Drawing.Size(149, 20);
            this.txtbidDep.TabIndex = 3;
            // 
            // txtbDesDep
            // 
            this.txtbDesDep.Location = new System.Drawing.Point(76, 84);
            this.txtbDesDep.Name = "txtbDesDep";
            this.txtbDesDep.Size = new System.Drawing.Size(182, 20);
            this.txtbDesDep.TabIndex = 4;
            // 
            // bttnGravarDep
            // 
            this.bttnGravarDep.Location = new System.Drawing.Point(15, 110);
            this.bttnGravarDep.Name = "bttnGravarDep";
            this.bttnGravarDep.Size = new System.Drawing.Size(60, 23);
            this.bttnGravarDep.TabIndex = 5;
            this.bttnGravarDep.Text = "Gravar";
            this.bttnGravarDep.UseVisualStyleBackColor = true;
            this.bttnGravarDep.Click += new System.EventHandler(this.bttnGravarDep_Click);
            // 
            // bttnVoltarDep
            // 
            this.bttnVoltarDep.Location = new System.Drawing.Point(206, 110);
            this.bttnVoltarDep.Name = "bttnVoltarDep";
            this.bttnVoltarDep.Size = new System.Drawing.Size(52, 23);
            this.bttnVoltarDep.TabIndex = 6;
            this.bttnVoltarDep.Text = "Voltar";
            this.bttnVoltarDep.UseVisualStyleBackColor = true;
            this.bttnVoltarDep.Click += new System.EventHandler(this.bttnVoltarDep_Click);
            // 
            // bttnNovoDep
            // 
            this.bttnNovoDep.Location = new System.Drawing.Point(81, 110);
            this.bttnNovoDep.Name = "bttnNovoDep";
            this.bttnNovoDep.Size = new System.Drawing.Size(52, 23);
            this.bttnNovoDep.TabIndex = 7;
            this.bttnNovoDep.Text = "Novo";
            this.bttnNovoDep.UseVisualStyleBackColor = true;
            this.bttnNovoDep.Click += new System.EventHandler(this.bttnNovoDep_Click);
            // 
            // bttnRemoverDep
            // 
            this.bttnRemoverDep.Location = new System.Drawing.Point(140, 110);
            this.bttnRemoverDep.Name = "bttnRemoverDep";
            this.bttnRemoverDep.Size = new System.Drawing.Size(60, 23);
            this.bttnRemoverDep.TabIndex = 8;
            this.bttnRemoverDep.Text = "Remover";
            this.bttnRemoverDep.UseVisualStyleBackColor = true;
            this.bttnRemoverDep.Click += new System.EventHandler(this.bttnRemoverDep_Click);
            // 
            // dtgrdvwDep
            // 
            this.dtgrdvwDep.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtgrdvwDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwDep.Location = new System.Drawing.Point(15, 140);
            this.dtgrdvwDep.Name = "dtgrdvwDep";
            this.dtgrdvwDep.Size = new System.Drawing.Size(243, 164);
            this.dtgrdvwDep.TabIndex = 9;
            // 
            // FormularioDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 320);
            this.Controls.Add(this.dtgrdvwDep);
            this.Controls.Add(this.bttnRemoverDep);
            this.Controls.Add(this.bttnNovoDep);
            this.Controls.Add(this.bttnVoltarDep);
            this.Controls.Add(this.bttnGravarDep);
            this.Controls.Add(this.txtbDesDep);
            this.Controls.Add(this.txtbidDep);
            this.Controls.Add(this.lblidDep);
            this.Controls.Add(this.lblDesDep);
            this.Controls.Add(this.lblTituloDep);
            this.Name = "FormularioDepartamento";
            this.Text = "Cadastro do Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDep;
        private System.Windows.Forms.Label lblDesDep;
        private System.Windows.Forms.Label lblidDep;
        private System.Windows.Forms.TextBox txtbidDep;
        private System.Windows.Forms.TextBox txtbDesDep;
        private System.Windows.Forms.Button bttnGravarDep;
        private System.Windows.Forms.Button bttnVoltarDep;
        private System.Windows.Forms.Button bttnNovoDep;
        private System.Windows.Forms.Button bttnRemoverDep;
        private System.Windows.Forms.DataGridView dtgrdvwDep;
    }
}