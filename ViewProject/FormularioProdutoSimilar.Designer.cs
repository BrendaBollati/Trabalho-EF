
namespace ViewProject
{
    partial class FormularioProdutoSimilar
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
            this.lblTituloProSim = new System.Windows.Forms.Label();
            this.lblidProSim = new System.Windows.Forms.Label();
            this.lblidProProSim = new System.Windows.Forms.Label();
            this.txtbidProProSim = new System.Windows.Forms.TextBox();
            this.txtbProSim = new System.Windows.Forms.TextBox();
            this.bttnVoltarProSim = new System.Windows.Forms.Button();
            this.bttnGravarProSim = new System.Windows.Forms.Button();
            this.bttnNovoProSim = new System.Windows.Forms.Button();
            this.bttnRemoverProSim = new System.Windows.Forms.Button();
            this.dtgrdvwProSim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwProSim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloProSim
            // 
            this.lblTituloProSim.AutoSize = true;
            this.lblTituloProSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProSim.ForeColor = System.Drawing.Color.Green;
            this.lblTituloProSim.Location = new System.Drawing.Point(42, 9);
            this.lblTituloProSim.Name = "lblTituloProSim";
            this.lblTituloProSim.Size = new System.Drawing.Size(173, 25);
            this.lblTituloProSim.TabIndex = 0;
            this.lblTituloProSim.Text = "Produto Similar";
            // 
            // lblidProSim
            // 
            this.lblidProSim.AutoSize = true;
            this.lblidProSim.Location = new System.Drawing.Point(12, 56);
            this.lblidProSim.Name = "lblidProSim";
            this.lblidProSim.Size = new System.Drawing.Size(61, 13);
            this.lblidProSim.TabIndex = 1;
            this.lblidProSim.Text = "ID Produto:";
            // 
            // lblidProProSim
            // 
            this.lblidProProSim.AutoSize = true;
            this.lblidProProSim.Location = new System.Drawing.Point(12, 82);
            this.lblidProProSim.Name = "lblidProProSim";
            this.lblidProProSim.Size = new System.Drawing.Size(94, 13);
            this.lblidProProSim.TabIndex = 2;
            this.lblidProProSim.Text = "ID Produto Similar:";
            // 
            // txtbidProProSim
            // 
            this.txtbidProProSim.Location = new System.Drawing.Point(79, 53);
            this.txtbidProProSim.Name = "txtbidProProSim";
            this.txtbidProProSim.Size = new System.Drawing.Size(179, 20);
            this.txtbidProProSim.TabIndex = 3;
            // 
            // txtbProSim
            // 
            this.txtbProSim.Location = new System.Drawing.Point(112, 79);
            this.txtbProSim.Name = "txtbProSim";
            this.txtbProSim.Size = new System.Drawing.Size(146, 20);
            this.txtbProSim.TabIndex = 4;
            // 
            // bttnVoltarProSim
            // 
            this.bttnVoltarProSim.Location = new System.Drawing.Point(203, 105);
            this.bttnVoltarProSim.Name = "bttnVoltarProSim";
            this.bttnVoltarProSim.Size = new System.Drawing.Size(55, 23);
            this.bttnVoltarProSim.TabIndex = 5;
            this.bttnVoltarProSim.Text = "Voltar";
            this.bttnVoltarProSim.UseVisualStyleBackColor = true;
            this.bttnVoltarProSim.Click += new System.EventHandler(this.bttnVoltarProSim_Click);
            // 
            // bttnGravarProSim
            // 
            this.bttnGravarProSim.Location = new System.Drawing.Point(12, 105);
            this.bttnGravarProSim.Name = "bttnGravarProSim";
            this.bttnGravarProSim.Size = new System.Drawing.Size(55, 23);
            this.bttnGravarProSim.TabIndex = 6;
            this.bttnGravarProSim.Text = "Gravar";
            this.bttnGravarProSim.UseVisualStyleBackColor = true;
            this.bttnGravarProSim.Click += new System.EventHandler(this.bttnGravarProSim_Click);
            // 
            // bttnNovoProSim
            // 
            this.bttnNovoProSim.Location = new System.Drawing.Point(73, 105);
            this.bttnNovoProSim.Name = "bttnNovoProSim";
            this.bttnNovoProSim.Size = new System.Drawing.Size(55, 23);
            this.bttnNovoProSim.TabIndex = 7;
            this.bttnNovoProSim.Text = "Novo";
            this.bttnNovoProSim.UseVisualStyleBackColor = true;
            this.bttnNovoProSim.Click += new System.EventHandler(this.bttnNovoProSim_Click);
            // 
            // bttnRemoverProSim
            // 
            this.bttnRemoverProSim.Location = new System.Drawing.Point(132, 105);
            this.bttnRemoverProSim.Name = "bttnRemoverProSim";
            this.bttnRemoverProSim.Size = new System.Drawing.Size(65, 23);
            this.bttnRemoverProSim.TabIndex = 8;
            this.bttnRemoverProSim.Text = "Remover";
            this.bttnRemoverProSim.UseVisualStyleBackColor = true;
            this.bttnRemoverProSim.Click += new System.EventHandler(this.bttnRemoverProSim_Click);
            // 
            // dtgrdvwProSim
            // 
            this.dtgrdvwProSim.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtgrdvwProSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwProSim.Location = new System.Drawing.Point(15, 135);
            this.dtgrdvwProSim.Name = "dtgrdvwProSim";
            this.dtgrdvwProSim.Size = new System.Drawing.Size(243, 158);
            this.dtgrdvwProSim.TabIndex = 9;
            // 
            // FormularioProdutoSimilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(278, 309);
            this.Controls.Add(this.dtgrdvwProSim);
            this.Controls.Add(this.bttnRemoverProSim);
            this.Controls.Add(this.bttnNovoProSim);
            this.Controls.Add(this.bttnGravarProSim);
            this.Controls.Add(this.bttnVoltarProSim);
            this.Controls.Add(this.txtbProSim);
            this.Controls.Add(this.txtbidProProSim);
            this.Controls.Add(this.lblidProProSim);
            this.Controls.Add(this.lblidProSim);
            this.Controls.Add(this.lblTituloProSim);
            this.Name = "FormularioProdutoSimilar";
            this.Text = "Cadastro de produto similar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwProSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProSim;
        private System.Windows.Forms.Label lblidProSim;
        private System.Windows.Forms.Label lblidProProSim;
        private System.Windows.Forms.TextBox txtbidProProSim;
        private System.Windows.Forms.TextBox txtbProSim;
        private System.Windows.Forms.Button bttnVoltarProSim;
        private System.Windows.Forms.Button bttnGravarProSim;
        private System.Windows.Forms.Button bttnNovoProSim;
        private System.Windows.Forms.Button bttnRemoverProSim;
        private System.Windows.Forms.DataGridView dtgrdvwProSim;
    }
}