
namespace ViewProject
{
    partial class FormularioMarca
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
            this.lblTituloMar = new System.Windows.Forms.Label();
            this.lblDesMar = new System.Windows.Forms.Label();
            this.lblidMar = new System.Windows.Forms.Label();
            this.txtbidMar = new System.Windows.Forms.TextBox();
            this.txtbDesMar = new System.Windows.Forms.TextBox();
            this.bttnVoltarMar = new System.Windows.Forms.Button();
            this.bttnGravarMar = new System.Windows.Forms.Button();
            this.bttnNovoMar = new System.Windows.Forms.Button();
            this.bttnRemoverMar = new System.Windows.Forms.Button();
            this.dtgrdvwMar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwMar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloMar
            // 
            this.lblTituloMar.AutoSize = true;
            this.lblTituloMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMar.ForeColor = System.Drawing.Color.Green;
            this.lblTituloMar.Location = new System.Drawing.Point(96, 9);
            this.lblTituloMar.Name = "lblTituloMar";
            this.lblTituloMar.Size = new System.Drawing.Size(77, 25);
            this.lblTituloMar.TabIndex = 0;
            this.lblTituloMar.Text = "Marca";
            // 
            // lblDesMar
            // 
            this.lblDesMar.AutoSize = true;
            this.lblDesMar.Location = new System.Drawing.Point(12, 81);
            this.lblDesMar.Name = "lblDesMar";
            this.lblDesMar.Size = new System.Drawing.Size(58, 13);
            this.lblDesMar.TabIndex = 1;
            this.lblDesMar.Text = "Descrição:";
            // 
            // lblidMar
            // 
            this.lblidMar.AutoSize = true;
            this.lblidMar.Location = new System.Drawing.Point(12, 55);
            this.lblidMar.Name = "lblidMar";
            this.lblidMar.Size = new System.Drawing.Size(54, 13);
            this.lblidMar.TabIndex = 3;
            this.lblidMar.Text = "ID Marca:";
            // 
            // txtbidMar
            // 
            this.txtbidMar.Location = new System.Drawing.Point(72, 52);
            this.txtbidMar.Name = "txtbidMar";
            this.txtbidMar.Size = new System.Drawing.Size(184, 20);
            this.txtbidMar.TabIndex = 4;
            // 
            // txtbDesMar
            // 
            this.txtbDesMar.Location = new System.Drawing.Point(76, 78);
            this.txtbDesMar.Name = "txtbDesMar";
            this.txtbDesMar.Size = new System.Drawing.Size(180, 20);
            this.txtbDesMar.TabIndex = 5;
            // 
            // bttnVoltarMar
            // 
            this.bttnVoltarMar.Location = new System.Drawing.Point(204, 104);
            this.bttnVoltarMar.Name = "bttnVoltarMar";
            this.bttnVoltarMar.Size = new System.Drawing.Size(52, 23);
            this.bttnVoltarMar.TabIndex = 6;
            this.bttnVoltarMar.Text = "Voltar";
            this.bttnVoltarMar.UseVisualStyleBackColor = true;
            this.bttnVoltarMar.Click += new System.EventHandler(this.bttnVoltarMar_Click);
            // 
            // bttnGravarMar
            // 
            this.bttnGravarMar.Location = new System.Drawing.Point(15, 104);
            this.bttnGravarMar.Name = "bttnGravarMar";
            this.bttnGravarMar.Size = new System.Drawing.Size(52, 23);
            this.bttnGravarMar.TabIndex = 7;
            this.bttnGravarMar.Text = "Gravar";
            this.bttnGravarMar.UseVisualStyleBackColor = true;
            this.bttnGravarMar.Click += new System.EventHandler(this.bttnGravarMar_Click);
            // 
            // bttnNovoMar
            // 
            this.bttnNovoMar.Location = new System.Drawing.Point(73, 104);
            this.bttnNovoMar.Name = "bttnNovoMar";
            this.bttnNovoMar.Size = new System.Drawing.Size(52, 23);
            this.bttnNovoMar.TabIndex = 8;
            this.bttnNovoMar.Text = "Novo";
            this.bttnNovoMar.UseVisualStyleBackColor = true;
            this.bttnNovoMar.Click += new System.EventHandler(this.bttnNovoMar_Click);
            // 
            // bttnRemoverMar
            // 
            this.bttnRemoverMar.Location = new System.Drawing.Point(137, 104);
            this.bttnRemoverMar.Name = "bttnRemoverMar";
            this.bttnRemoverMar.Size = new System.Drawing.Size(61, 23);
            this.bttnRemoverMar.TabIndex = 9;
            this.bttnRemoverMar.Text = "Remover";
            this.bttnRemoverMar.UseVisualStyleBackColor = true;
            this.bttnRemoverMar.Click += new System.EventHandler(this.bttnRemoverMar_Click);
            // 
            // dtgrdvwMar
            // 
            this.dtgrdvwMar.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtgrdvwMar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwMar.Location = new System.Drawing.Point(15, 134);
            this.dtgrdvwMar.Name = "dtgrdvwMar";
            this.dtgrdvwMar.Size = new System.Drawing.Size(241, 164);
            this.dtgrdvwMar.TabIndex = 10;
            // 
            // FormularioMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(268, 310);
            this.Controls.Add(this.dtgrdvwMar);
            this.Controls.Add(this.bttnRemoverMar);
            this.Controls.Add(this.bttnNovoMar);
            this.Controls.Add(this.bttnGravarMar);
            this.Controls.Add(this.bttnVoltarMar);
            this.Controls.Add(this.txtbDesMar);
            this.Controls.Add(this.txtbidMar);
            this.Controls.Add(this.lblidMar);
            this.Controls.Add(this.lblDesMar);
            this.Controls.Add(this.lblTituloMar);
            this.Name = "FormularioMarca";
            this.Text = "Cadastro de Marca";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwMar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMar;
        private System.Windows.Forms.Label lblDesMar;
        private System.Windows.Forms.Label lblidMar;
        private System.Windows.Forms.TextBox txtbidMar;
        private System.Windows.Forms.TextBox txtbDesMar;
        private System.Windows.Forms.Button bttnVoltarMar;
        private System.Windows.Forms.Button bttnGravarMar;
        private System.Windows.Forms.Button bttnNovoMar;
        private System.Windows.Forms.Button bttnRemoverMar;
        private System.Windows.Forms.DataGridView dtgrdvwMar;
    }
}