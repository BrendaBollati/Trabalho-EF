
namespace ViewProject
{
    partial class FormularioCategoria
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
            this.lblTituloCat = new System.Windows.Forms.Label();
            this.lblidCat = new System.Windows.Forms.Label();
            this.lblDesCat = new System.Windows.Forms.Label();
            this.lblDepCat = new System.Windows.Forms.Label();
            this.txtbidCat = new System.Windows.Forms.TextBox();
            this.txtbDesCat = new System.Windows.Forms.TextBox();
            this.txtbidDepCat = new System.Windows.Forms.TextBox();
            this.bttnVoltarCat = new System.Windows.Forms.Button();
            this.bttnGravarCat = new System.Windows.Forms.Button();
            this.bttnRemoverCat = new System.Windows.Forms.Button();
            this.bttnNovoCat = new System.Windows.Forms.Button();
            this.dtgrdvwCat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCat
            // 
            this.lblTituloCat.AutoSize = true;
            this.lblTituloCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCat.ForeColor = System.Drawing.Color.Green;
            this.lblTituloCat.Location = new System.Drawing.Point(82, 9);
            this.lblTituloCat.Name = "lblTituloCat";
            this.lblTituloCat.Size = new System.Drawing.Size(114, 25);
            this.lblTituloCat.TabIndex = 0;
            this.lblTituloCat.Text = "Categoria";
            // 
            // lblidCat
            // 
            this.lblidCat.AutoSize = true;
            this.lblidCat.Location = new System.Drawing.Point(12, 50);
            this.lblidCat.Name = "lblidCat";
            this.lblidCat.Size = new System.Drawing.Size(69, 13);
            this.lblidCat.TabIndex = 1;
            this.lblidCat.Text = "ID Categoria:";
            // 
            // lblDesCat
            // 
            this.lblDesCat.AutoSize = true;
            this.lblDesCat.Location = new System.Drawing.Point(12, 76);
            this.lblDesCat.Name = "lblDesCat";
            this.lblDesCat.Size = new System.Drawing.Size(58, 13);
            this.lblDesCat.TabIndex = 2;
            this.lblDesCat.Text = "Descrição:";
            // 
            // lblDepCat
            // 
            this.lblDepCat.AutoSize = true;
            this.lblDepCat.Location = new System.Drawing.Point(12, 102);
            this.lblDepCat.Name = "lblDepCat";
            this.lblDepCat.Size = new System.Drawing.Size(91, 13);
            this.lblDepCat.TabIndex = 3;
            this.lblDepCat.Text = "ID Departamento:";
            // 
            // txtbidCat
            // 
            this.txtbidCat.Location = new System.Drawing.Point(87, 47);
            this.txtbidCat.Name = "txtbidCat";
            this.txtbidCat.Size = new System.Drawing.Size(173, 20);
            this.txtbidCat.TabIndex = 4;
            // 
            // txtbDesCat
            // 
            this.txtbDesCat.Location = new System.Drawing.Point(76, 73);
            this.txtbDesCat.Name = "txtbDesCat";
            this.txtbDesCat.Size = new System.Drawing.Size(184, 20);
            this.txtbDesCat.TabIndex = 5;
            // 
            // txtbidDepCat
            // 
            this.txtbidDepCat.Location = new System.Drawing.Point(109, 99);
            this.txtbidDepCat.Name = "txtbidDepCat";
            this.txtbidDepCat.Size = new System.Drawing.Size(151, 20);
            this.txtbidDepCat.TabIndex = 6;
            // 
            // bttnVoltarCat
            // 
            this.bttnVoltarCat.Location = new System.Drawing.Point(209, 125);
            this.bttnVoltarCat.Name = "bttnVoltarCat";
            this.bttnVoltarCat.Size = new System.Drawing.Size(51, 23);
            this.bttnVoltarCat.TabIndex = 7;
            this.bttnVoltarCat.Text = "Voltar";
            this.bttnVoltarCat.UseVisualStyleBackColor = true;
            this.bttnVoltarCat.Click += new System.EventHandler(this.bttnVoltarCat_Click);
            // 
            // bttnGravarCat
            // 
            this.bttnGravarCat.Location = new System.Drawing.Point(15, 125);
            this.bttnGravarCat.Name = "bttnGravarCat";
            this.bttnGravarCat.Size = new System.Drawing.Size(51, 23);
            this.bttnGravarCat.TabIndex = 8;
            this.bttnGravarCat.Text = "Gravar";
            this.bttnGravarCat.UseVisualStyleBackColor = true;
            this.bttnGravarCat.Click += new System.EventHandler(this.bttnGravarCat_Click);
            // 
            // bttnRemoverCat
            // 
            this.bttnRemoverCat.Location = new System.Drawing.Point(134, 125);
            this.bttnRemoverCat.Name = "bttnRemoverCat";
            this.bttnRemoverCat.Size = new System.Drawing.Size(62, 23);
            this.bttnRemoverCat.TabIndex = 9;
            this.bttnRemoverCat.Text = "Remover";
            this.bttnRemoverCat.UseVisualStyleBackColor = true;
            this.bttnRemoverCat.Click += new System.EventHandler(this.bttnRemoverCat_Click);
            // 
            // bttnNovoCat
            // 
            this.bttnNovoCat.Location = new System.Drawing.Point(76, 125);
            this.bttnNovoCat.Name = "bttnNovoCat";
            this.bttnNovoCat.Size = new System.Drawing.Size(51, 23);
            this.bttnNovoCat.TabIndex = 10;
            this.bttnNovoCat.Text = "Novo";
            this.bttnNovoCat.UseVisualStyleBackColor = true;
            this.bttnNovoCat.Click += new System.EventHandler(this.bttnNovoCat_Click);
            // 
            // dtgrdvwCat
            // 
            this.dtgrdvwCat.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtgrdvwCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwCat.Location = new System.Drawing.Point(15, 155);
            this.dtgrdvwCat.Name = "dtgrdvwCat";
            this.dtgrdvwCat.Size = new System.Drawing.Size(245, 150);
            this.dtgrdvwCat.TabIndex = 11;
            // 
            // FormularioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(272, 320);
            this.Controls.Add(this.dtgrdvwCat);
            this.Controls.Add(this.bttnNovoCat);
            this.Controls.Add(this.bttnRemoverCat);
            this.Controls.Add(this.bttnGravarCat);
            this.Controls.Add(this.bttnVoltarCat);
            this.Controls.Add(this.txtbidDepCat);
            this.Controls.Add(this.txtbDesCat);
            this.Controls.Add(this.txtbidCat);
            this.Controls.Add(this.lblDepCat);
            this.Controls.Add(this.lblDesCat);
            this.Controls.Add(this.lblidCat);
            this.Controls.Add(this.lblTituloCat);
            this.Name = "FormularioCategoria";
            this.Text = "FormularioCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCat;
        private System.Windows.Forms.Label lblidCat;
        private System.Windows.Forms.Label lblDesCat;
        private System.Windows.Forms.Label lblDepCat;
        private System.Windows.Forms.TextBox txtbidCat;
        private System.Windows.Forms.TextBox txtbDesCat;
        private System.Windows.Forms.TextBox txtbidDepCat;
        private System.Windows.Forms.Button bttnVoltarCat;
        private System.Windows.Forms.Button bttnGravarCat;
        private System.Windows.Forms.Button bttnRemoverCat;
        private System.Windows.Forms.Button bttnNovoCat;
        private System.Windows.Forms.DataGridView dtgrdvwCat;
    }
}