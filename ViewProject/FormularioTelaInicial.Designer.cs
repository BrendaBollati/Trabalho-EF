
namespace ViewProject
{
    partial class FormularioTelaInicial
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
            this.lblSBVTela = new System.Windows.Forms.Label();
            this.groupBoxCadastro = new System.Windows.Forms.GroupBox();
            this.radiobttnUniMed = new System.Windows.Forms.RadioButton();
            this.radiobttnSub = new System.Windows.Forms.RadioButton();
            this.radiobttnProSim = new System.Windows.Forms.RadioButton();
            this.radiobttnPro = new System.Windows.Forms.RadioButton();
            this.radiobttnPecVen = new System.Windows.Forms.RadioButton();
            this.radiobttnMar = new System.Windows.Forms.RadioButton();
            this.radiobttnDep = new System.Windows.Forms.RadioButton();
            this.radiobttnCat = new System.Windows.Forms.RadioButton();
            this.groupBoxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSBVTela
            // 
            this.lblSBVTela.AutoSize = true;
            this.lblSBVTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBVTela.ForeColor = System.Drawing.Color.Green;
            this.lblSBVTela.Location = new System.Drawing.Point(95, 9);
            this.lblSBVTela.Name = "lblSBVTela";
            this.lblSBVTela.Size = new System.Drawing.Size(179, 25);
            this.lblSBVTela.TabIndex = 0;
            this.lblSBVTela.Text = "Seja Bem Vindo";
            // 
            // groupBoxCadastro
            // 
            this.groupBoxCadastro.Controls.Add(this.radiobttnUniMed);
            this.groupBoxCadastro.Controls.Add(this.radiobttnSub);
            this.groupBoxCadastro.Controls.Add(this.radiobttnProSim);
            this.groupBoxCadastro.Controls.Add(this.radiobttnPro);
            this.groupBoxCadastro.Controls.Add(this.radiobttnPecVen);
            this.groupBoxCadastro.Controls.Add(this.radiobttnMar);
            this.groupBoxCadastro.Controls.Add(this.radiobttnDep);
            this.groupBoxCadastro.Controls.Add(this.radiobttnCat);
            this.groupBoxCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastro.Location = new System.Drawing.Point(13, 56);
            this.groupBoxCadastro.Name = "groupBoxCadastro";
            this.groupBoxCadastro.Size = new System.Drawing.Size(354, 130);
            this.groupBoxCadastro.TabIndex = 1;
            this.groupBoxCadastro.TabStop = false;
            this.groupBoxCadastro.Text = "Cadastros";
            // 
            // radiobttnUniMed
            // 
            this.radiobttnUniMed.AutoSize = true;
            this.radiobttnUniMed.Location = new System.Drawing.Point(182, 99);
            this.radiobttnUniMed.Name = "radiobttnUniMed";
            this.radiobttnUniMed.Size = new System.Drawing.Size(163, 20);
            this.radiobttnUniMed.TabIndex = 7;
            this.radiobttnUniMed.TabStop = true;
            this.radiobttnUniMed.Text = "Unidade de Medida";
            this.radiobttnUniMed.UseVisualStyleBackColor = true;
            this.radiobttnUniMed.CheckedChanged += new System.EventHandler(this.radiobttnUniMed_CheckedChanged);
            // 
            // radiobttnSub
            // 
            this.radiobttnSub.AutoSize = true;
            this.radiobttnSub.Location = new System.Drawing.Point(182, 73);
            this.radiobttnSub.Name = "radiobttnSub";
            this.radiobttnSub.Size = new System.Drawing.Size(119, 20);
            this.radiobttnSub.TabIndex = 6;
            this.radiobttnSub.TabStop = true;
            this.radiobttnSub.Text = "Subcategoria";
            this.radiobttnSub.UseVisualStyleBackColor = true;
            this.radiobttnSub.CheckedChanged += new System.EventHandler(this.radiobttnSub_CheckedChanged);
            // 
            // radiobttnProSim
            // 
            this.radiobttnProSim.AutoSize = true;
            this.radiobttnProSim.Location = new System.Drawing.Point(182, 47);
            this.radiobttnProSim.Name = "radiobttnProSim";
            this.radiobttnProSim.Size = new System.Drawing.Size(132, 20);
            this.radiobttnProSim.TabIndex = 5;
            this.radiobttnProSim.TabStop = true;
            this.radiobttnProSim.Text = "Produto Similar";
            this.radiobttnProSim.UseVisualStyleBackColor = true;
            this.radiobttnProSim.CheckedChanged += new System.EventHandler(this.radiobttnProSim_CheckedChanged);
            // 
            // radiobttnPro
            // 
            this.radiobttnPro.AutoSize = true;
            this.radiobttnPro.Location = new System.Drawing.Point(182, 21);
            this.radiobttnPro.Name = "radiobttnPro";
            this.radiobttnPro.Size = new System.Drawing.Size(80, 20);
            this.radiobttnPro.TabIndex = 4;
            this.radiobttnPro.TabStop = true;
            this.radiobttnPro.Text = "Produto";
            this.radiobttnPro.UseVisualStyleBackColor = true;
            this.radiobttnPro.CheckedChanged += new System.EventHandler(this.radiobttnPro_CheckedChanged);
            // 
            // radiobttnPecVen
            // 
            this.radiobttnPecVen.AutoSize = true;
            this.radiobttnPecVen.Location = new System.Drawing.Point(7, 99);
            this.radiobttnPecVen.Name = "radiobttnPecVen";
            this.radiobttnPecVen.Size = new System.Drawing.Size(138, 20);
            this.radiobttnPecVen.TabIndex = 3;
            this.radiobttnPecVen.TabStop = true;
            this.radiobttnPecVen.Text = "Preço da Venda";
            this.radiobttnPecVen.UseVisualStyleBackColor = true;
            this.radiobttnPecVen.CheckedChanged += new System.EventHandler(this.radiobttnPecVen_CheckedChanged);
            // 
            // radiobttnMar
            // 
            this.radiobttnMar.AutoSize = true;
            this.radiobttnMar.Location = new System.Drawing.Point(7, 73);
            this.radiobttnMar.Name = "radiobttnMar";
            this.radiobttnMar.Size = new System.Drawing.Size(69, 20);
            this.radiobttnMar.TabIndex = 2;
            this.radiobttnMar.TabStop = true;
            this.radiobttnMar.Text = "Marca";
            this.radiobttnMar.UseVisualStyleBackColor = true;
            this.radiobttnMar.CheckedChanged += new System.EventHandler(this.radiobttnMar_CheckedChanged);
            // 
            // radiobttnDep
            // 
            this.radiobttnDep.AutoSize = true;
            this.radiobttnDep.Location = new System.Drawing.Point(7, 47);
            this.radiobttnDep.Name = "radiobttnDep";
            this.radiobttnDep.Size = new System.Drawing.Size(124, 20);
            this.radiobttnDep.TabIndex = 1;
            this.radiobttnDep.TabStop = true;
            this.radiobttnDep.Text = "Departamento";
            this.radiobttnDep.UseVisualStyleBackColor = true;
            this.radiobttnDep.CheckedChanged += new System.EventHandler(this.radiobttnDep_CheckedChanged);
            // 
            // radiobttnCat
            // 
            this.radiobttnCat.AutoSize = true;
            this.radiobttnCat.Location = new System.Drawing.Point(7, 21);
            this.radiobttnCat.Name = "radiobttnCat";
            this.radiobttnCat.Size = new System.Drawing.Size(94, 20);
            this.radiobttnCat.TabIndex = 0;
            this.radiobttnCat.TabStop = true;
            this.radiobttnCat.Text = "Categoria";
            this.radiobttnCat.UseVisualStyleBackColor = true;
            this.radiobttnCat.CheckedChanged += new System.EventHandler(this.radiobttnCat_CheckedChanged);
            // 
            // FormularioTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 199);
            this.Controls.Add(this.groupBoxCadastro);
            this.Controls.Add(this.lblSBVTela);
            this.Name = "FormularioTelaInicial";
            this.Text = "Tela inicial";
            this.Load += new System.EventHandler(this.FormularioTelaInicial_Load);
            this.groupBoxCadastro.ResumeLayout(false);
            this.groupBoxCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSBVTela;
        private System.Windows.Forms.GroupBox groupBoxCadastro;
        private System.Windows.Forms.RadioButton radiobttnSub;
        private System.Windows.Forms.RadioButton radiobttnProSim;
        private System.Windows.Forms.RadioButton radiobttnPro;
        private System.Windows.Forms.RadioButton radiobttnPecVen;
        private System.Windows.Forms.RadioButton radiobttnMar;
        private System.Windows.Forms.RadioButton radiobttnDep;
        private System.Windows.Forms.RadioButton radiobttnCat;
        private System.Windows.Forms.RadioButton radiobttnUniMed;
    }
}