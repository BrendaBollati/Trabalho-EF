
namespace ViewProject
{
    partial class FormularioSubcategoria
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
            this.lblTituloSub = new System.Windows.Forms.Label();
            this.lblidSub = new System.Windows.Forms.Label();
            this.lblCatSub = new System.Windows.Forms.Label();
            this.lblDesSub = new System.Windows.Forms.Label();
            this.txtbidSub = new System.Windows.Forms.TextBox();
            this.txtbDesSub = new System.Windows.Forms.TextBox();
            this.txtbidCatSub = new System.Windows.Forms.TextBox();
            this.bttnVoltarSub = new System.Windows.Forms.Button();
            this.bttnGravarSub = new System.Windows.Forms.Button();
            this.bttnNovoSub = new System.Windows.Forms.Button();
            this.bttnRemoverSub = new System.Windows.Forms.Button();
            this.dtgrdvwSub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSub)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloSub
            // 
            this.lblTituloSub.AutoSize = true;
            this.lblTituloSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSub.ForeColor = System.Drawing.Color.Green;
            this.lblTituloSub.Location = new System.Drawing.Point(51, 9);
            this.lblTituloSub.Name = "lblTituloSub";
            this.lblTituloSub.Size = new System.Drawing.Size(151, 25);
            this.lblTituloSub.TabIndex = 0;
            this.lblTituloSub.Text = "Subcategoria";
            // 
            // lblidSub
            // 
            this.lblidSub.AutoSize = true;
            this.lblidSub.Location = new System.Drawing.Point(11, 57);
            this.lblidSub.Name = "lblidSub";
            this.lblidSub.Size = new System.Drawing.Size(87, 13);
            this.lblidSub.TabIndex = 1;
            this.lblidSub.Text = "ID Subcategoria:";
            // 
            // lblCatSub
            // 
            this.lblCatSub.AutoSize = true;
            this.lblCatSub.Location = new System.Drawing.Point(11, 109);
            this.lblCatSub.Name = "lblCatSub";
            this.lblCatSub.Size = new System.Drawing.Size(69, 13);
            this.lblCatSub.TabIndex = 2;
            this.lblCatSub.Text = "ID Categoria:";
            // 
            // lblDesSub
            // 
            this.lblDesSub.AutoSize = true;
            this.lblDesSub.Location = new System.Drawing.Point(11, 83);
            this.lblDesSub.Name = "lblDesSub";
            this.lblDesSub.Size = new System.Drawing.Size(58, 13);
            this.lblDesSub.TabIndex = 3;
            this.lblDesSub.Text = "Descrição:";
            // 
            // txtbidSub
            // 
            this.txtbidSub.Location = new System.Drawing.Point(104, 54);
            this.txtbidSub.Name = "txtbidSub";
            this.txtbidSub.Size = new System.Drawing.Size(145, 20);
            this.txtbidSub.TabIndex = 4;
            // 
            // txtbDesSub
            // 
            this.txtbDesSub.Location = new System.Drawing.Point(75, 80);
            this.txtbDesSub.Name = "txtbDesSub";
            this.txtbDesSub.Size = new System.Drawing.Size(174, 20);
            this.txtbDesSub.TabIndex = 5;
            // 
            // txtbidCatSub
            // 
            this.txtbidCatSub.Location = new System.Drawing.Point(86, 106);
            this.txtbidCatSub.Name = "txtbidCatSub";
            this.txtbidCatSub.Size = new System.Drawing.Size(163, 20);
            this.txtbidCatSub.TabIndex = 6;
            // 
            // bttnVoltarSub
            // 
            this.bttnVoltarSub.Location = new System.Drawing.Point(195, 132);
            this.bttnVoltarSub.Name = "bttnVoltarSub";
            this.bttnVoltarSub.Size = new System.Drawing.Size(54, 23);
            this.bttnVoltarSub.TabIndex = 7;
            this.bttnVoltarSub.Text = "Voltar";
            this.bttnVoltarSub.UseVisualStyleBackColor = true;
            this.bttnVoltarSub.Click += new System.EventHandler(this.bttnVoltarSub_Click);
            // 
            // bttnGravarSub
            // 
            this.bttnGravarSub.Location = new System.Drawing.Point(14, 132);
            this.bttnGravarSub.Name = "bttnGravarSub";
            this.bttnGravarSub.Size = new System.Drawing.Size(54, 23);
            this.bttnGravarSub.TabIndex = 8;
            this.bttnGravarSub.Text = "Gravar";
            this.bttnGravarSub.UseVisualStyleBackColor = true;
            this.bttnGravarSub.Click += new System.EventHandler(this.bttnGravarSub_Click);
            // 
            // bttnNovoSub
            // 
            this.bttnNovoSub.Location = new System.Drawing.Point(75, 132);
            this.bttnNovoSub.Name = "bttnNovoSub";
            this.bttnNovoSub.Size = new System.Drawing.Size(50, 23);
            this.bttnNovoSub.TabIndex = 9;
            this.bttnNovoSub.Text = "Novo";
            this.bttnNovoSub.UseVisualStyleBackColor = true;
            this.bttnNovoSub.Click += new System.EventHandler(this.bttnNovoSub_Click);
            // 
            // bttnRemoverSub
            // 
            this.bttnRemoverSub.Location = new System.Drawing.Point(129, 132);
            this.bttnRemoverSub.Name = "bttnRemoverSub";
            this.bttnRemoverSub.Size = new System.Drawing.Size(60, 23);
            this.bttnRemoverSub.TabIndex = 10;
            this.bttnRemoverSub.Text = "Remover";
            this.bttnRemoverSub.UseVisualStyleBackColor = true;
            this.bttnRemoverSub.Click += new System.EventHandler(this.bttnRemoverSub_Click);
            // 
            // dtgrdvwSub
            // 
            this.dtgrdvwSub.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtgrdvwSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwSub.Location = new System.Drawing.Point(14, 161);
            this.dtgrdvwSub.Name = "dtgrdvwSub";
            this.dtgrdvwSub.Size = new System.Drawing.Size(235, 162);
            this.dtgrdvwSub.TabIndex = 11;
            // 
            // FormularioSubcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(261, 335);
            this.Controls.Add(this.dtgrdvwSub);
            this.Controls.Add(this.bttnRemoverSub);
            this.Controls.Add(this.bttnNovoSub);
            this.Controls.Add(this.bttnGravarSub);
            this.Controls.Add(this.bttnVoltarSub);
            this.Controls.Add(this.txtbidCatSub);
            this.Controls.Add(this.txtbDesSub);
            this.Controls.Add(this.txtbidSub);
            this.Controls.Add(this.lblDesSub);
            this.Controls.Add(this.lblCatSub);
            this.Controls.Add(this.lblidSub);
            this.Controls.Add(this.lblTituloSub);
            this.Name = "FormularioSubcategoria";
            this.Text = "Cadastro de Subcategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSub;
        private System.Windows.Forms.Label lblidSub;
        private System.Windows.Forms.Label lblCatSub;
        private System.Windows.Forms.Label lblDesSub;
        private System.Windows.Forms.TextBox txtbidSub;
        private System.Windows.Forms.TextBox txtbDesSub;
        private System.Windows.Forms.TextBox txtbidCatSub;
        private System.Windows.Forms.Button bttnVoltarSub;
        private System.Windows.Forms.Button bttnGravarSub;
        private System.Windows.Forms.Button bttnNovoSub;
        private System.Windows.Forms.Button bttnRemoverSub;
        private System.Windows.Forms.DataGridView dtgrdvwSub;
    }
}