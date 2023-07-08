
namespace ViewProject
{
    partial class FormularioProduto
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
            this.lblprodID = new System.Windows.Forms.Label();
            this.lblprodCod = new System.Windows.Forms.Label();
            this.txtbprodID = new System.Windows.Forms.TextBox();
            this.txtbprodCod = new System.Windows.Forms.TextBox();
            this.lblprodutoDes = new System.Windows.Forms.Label();
            this.txtbprodDes = new System.Windows.Forms.TextBox();
            this.lblSubIDprod = new System.Windows.Forms.Label();
            this.lblMarIDprod = new System.Windows.Forms.Label();
            this.dtgrdvwPro = new System.Windows.Forms.DataGridView();
            this.txtbprodSubID = new System.Windows.Forms.TextBox();
            this.txtbprodMar = new System.Windows.Forms.TextBox();
            this.txtbprodUniMed = new System.Windows.Forms.TextBox();
            this.txtbPesBru = new System.Windows.Forms.TextBox();
            this.txtbprodStatus = new System.Windows.Forms.TextBox();
            this.txtbprodEspTec = new System.Windows.Forms.TextBox();
            this.lblprodUniMed = new System.Windows.Forms.Label();
            this.lblprodEspTec = new System.Windows.Forms.Label();
            this.lblprodStatus = new System.Windows.Forms.Label();
            this.lblprodPesBru = new System.Windows.Forms.Label();
            this.lblprodPesLiq = new System.Windows.Forms.Label();
            this.txtbprodPesLiq = new System.Windows.Forms.TextBox();
            this.txtbprodQtdMult = new System.Windows.Forms.TextBox();
            this.lblprodQtdMult = new System.Windows.Forms.Label();
            this.lblprodQtdMin = new System.Windows.Forms.Label();
            this.txtbprodQtdMin = new System.Windows.Forms.TextBox();
            this.lblprodCodBar = new System.Windows.Forms.Label();
            this.txtbprodCodBar = new System.Windows.Forms.TextBox();
            this.bttnGravar = new System.Windows.Forms.Button();
            this.bttnNovo = new System.Windows.Forms.Button();
            this.bttnRemover = new System.Windows.Forms.Button();
            this.bttnVoltarPro = new System.Windows.Forms.Button();
            this.lblTituloPro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwPro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprodID
            // 
            this.lblprodID.AutoSize = true;
            this.lblprodID.Location = new System.Drawing.Point(11, 25);
            this.lblprodID.Name = "lblprodID";
            this.lblprodID.Size = new System.Drawing.Size(21, 13);
            this.lblprodID.TabIndex = 0;
            this.lblprodID.Text = "ID:";
            // 
            // lblprodCod
            // 
            this.lblprodCod.AutoSize = true;
            this.lblprodCod.Location = new System.Drawing.Point(11, 51);
            this.lblprodCod.Name = "lblprodCod";
            this.lblprodCod.Size = new System.Drawing.Size(43, 13);
            this.lblprodCod.TabIndex = 1;
            this.lblprodCod.Text = "Codigo:";
            // 
            // txtbprodID
            // 
            this.txtbprodID.Location = new System.Drawing.Point(38, 22);
            this.txtbprodID.Name = "txtbprodID";
            this.txtbprodID.Size = new System.Drawing.Size(220, 20);
            this.txtbprodID.TabIndex = 2;
            // 
            // txtbprodCod
            // 
            this.txtbprodCod.Location = new System.Drawing.Point(60, 48);
            this.txtbprodCod.Name = "txtbprodCod";
            this.txtbprodCod.Size = new System.Drawing.Size(198, 20);
            this.txtbprodCod.TabIndex = 3;
            // 
            // lblprodutoDes
            // 
            this.lblprodutoDes.AutoSize = true;
            this.lblprodutoDes.Location = new System.Drawing.Point(11, 78);
            this.lblprodutoDes.Name = "lblprodutoDes";
            this.lblprodutoDes.Size = new System.Drawing.Size(58, 13);
            this.lblprodutoDes.TabIndex = 4;
            this.lblprodutoDes.Text = "Descrição:";
            // 
            // txtbprodDes
            // 
            this.txtbprodDes.Location = new System.Drawing.Point(76, 75);
            this.txtbprodDes.Name = "txtbprodDes";
            this.txtbprodDes.Size = new System.Drawing.Size(182, 20);
            this.txtbprodDes.TabIndex = 5;
            // 
            // lblSubIDprod
            // 
            this.lblSubIDprod.AutoSize = true;
            this.lblSubIDprod.Location = new System.Drawing.Point(11, 108);
            this.lblSubIDprod.Name = "lblSubIDprod";
            this.lblSubIDprod.Size = new System.Drawing.Size(87, 13);
            this.lblSubIDprod.TabIndex = 6;
            this.lblSubIDprod.Text = "Subcategoria ID:";
            // 
            // lblMarIDprod
            // 
            this.lblMarIDprod.AutoSize = true;
            this.lblMarIDprod.Location = new System.Drawing.Point(11, 130);
            this.lblMarIDprod.Name = "lblMarIDprod";
            this.lblMarIDprod.Size = new System.Drawing.Size(54, 13);
            this.lblMarIDprod.TabIndex = 7;
            this.lblMarIDprod.Text = "Marca ID:";
            // 
            // dtgrdvwPro
            // 
            this.dtgrdvwPro.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtgrdvwPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwPro.Location = new System.Drawing.Point(265, 48);
            this.dtgrdvwPro.Name = "dtgrdvwPro";
            this.dtgrdvwPro.Size = new System.Drawing.Size(555, 263);
            this.dtgrdvwPro.TabIndex = 8;
            // 
            // txtbprodSubID
            // 
            this.txtbprodSubID.Location = new System.Drawing.Point(104, 101);
            this.txtbprodSubID.Name = "txtbprodSubID";
            this.txtbprodSubID.Size = new System.Drawing.Size(154, 20);
            this.txtbprodSubID.TabIndex = 9;
            // 
            // txtbprodMar
            // 
            this.txtbprodMar.Location = new System.Drawing.Point(71, 127);
            this.txtbprodMar.Name = "txtbprodMar";
            this.txtbprodMar.Size = new System.Drawing.Size(187, 20);
            this.txtbprodMar.TabIndex = 10;
            // 
            // txtbprodUniMed
            // 
            this.txtbprodUniMed.Location = new System.Drawing.Point(120, 153);
            this.txtbprodUniMed.Name = "txtbprodUniMed";
            this.txtbprodUniMed.Size = new System.Drawing.Size(138, 20);
            this.txtbprodUniMed.TabIndex = 11;
            // 
            // txtbPesBru
            // 
            this.txtbPesBru.Location = new System.Drawing.Point(79, 231);
            this.txtbPesBru.Name = "txtbPesBru";
            this.txtbPesBru.Size = new System.Drawing.Size(179, 20);
            this.txtbPesBru.TabIndex = 12;
            // 
            // txtbprodStatus
            // 
            this.txtbprodStatus.Location = new System.Drawing.Point(57, 205);
            this.txtbprodStatus.Name = "txtbprodStatus";
            this.txtbprodStatus.Size = new System.Drawing.Size(201, 20);
            this.txtbprodStatus.TabIndex = 13;
            // 
            // txtbprodEspTec
            // 
            this.txtbprodEspTec.Location = new System.Drawing.Point(136, 179);
            this.txtbprodEspTec.Name = "txtbprodEspTec";
            this.txtbprodEspTec.Size = new System.Drawing.Size(122, 20);
            this.txtbprodEspTec.TabIndex = 14;
            // 
            // lblprodUniMed
            // 
            this.lblprodUniMed.AutoSize = true;
            this.lblprodUniMed.Location = new System.Drawing.Point(11, 156);
            this.lblprodUniMed.Name = "lblprodUniMed";
            this.lblprodUniMed.Size = new System.Drawing.Size(102, 13);
            this.lblprodUniMed.TabIndex = 15;
            this.lblprodUniMed.Text = "Unidade Medida ID:";
            // 
            // lblprodEspTec
            // 
            this.lblprodEspTec.AutoSize = true;
            this.lblprodEspTec.Location = new System.Drawing.Point(11, 182);
            this.lblprodEspTec.Name = "lblprodEspTec";
            this.lblprodEspTec.Size = new System.Drawing.Size(119, 13);
            this.lblprodEspTec.TabIndex = 16;
            this.lblprodEspTec.Text = "Especificação Tecnica:";
            // 
            // lblprodStatus
            // 
            this.lblprodStatus.AutoSize = true;
            this.lblprodStatus.Location = new System.Drawing.Point(11, 208);
            this.lblprodStatus.Name = "lblprodStatus";
            this.lblprodStatus.Size = new System.Drawing.Size(40, 13);
            this.lblprodStatus.TabIndex = 17;
            this.lblprodStatus.Text = "Status:";
            // 
            // lblprodPesBru
            // 
            this.lblprodPesBru.AutoSize = true;
            this.lblprodPesBru.Location = new System.Drawing.Point(11, 234);
            this.lblprodPesBru.Name = "lblprodPesBru";
            this.lblprodPesBru.Size = new System.Drawing.Size(62, 13);
            this.lblprodPesBru.TabIndex = 18;
            this.lblprodPesBru.Text = "Peso Bruto:";
            // 
            // lblprodPesLiq
            // 
            this.lblprodPesLiq.AutoSize = true;
            this.lblprodPesLiq.Location = new System.Drawing.Point(11, 260);
            this.lblprodPesLiq.Name = "lblprodPesLiq";
            this.lblprodPesLiq.Size = new System.Drawing.Size(71, 13);
            this.lblprodPesLiq.TabIndex = 19;
            this.lblprodPesLiq.Text = "Peso Liquido:";
            // 
            // txtbprodPesLiq
            // 
            this.txtbprodPesLiq.Location = new System.Drawing.Point(88, 257);
            this.txtbprodPesLiq.Name = "txtbprodPesLiq";
            this.txtbprodPesLiq.Size = new System.Drawing.Size(170, 20);
            this.txtbprodPesLiq.TabIndex = 20;
            // 
            // txtbprodQtdMult
            // 
            this.txtbprodQtdMult.Location = new System.Drawing.Point(105, 283);
            this.txtbprodQtdMult.Name = "txtbprodQtdMult";
            this.txtbprodQtdMult.Size = new System.Drawing.Size(153, 20);
            this.txtbprodQtdMult.TabIndex = 21;
            // 
            // lblprodQtdMult
            // 
            this.lblprodQtdMult.AutoSize = true;
            this.lblprodQtdMult.Location = new System.Drawing.Point(11, 286);
            this.lblprodQtdMult.Name = "lblprodQtdMult";
            this.lblprodQtdMult.Size = new System.Drawing.Size(88, 13);
            this.lblprodQtdMult.TabIndex = 22;
            this.lblprodQtdMult.Text = "Quantidade Mult:";
            // 
            // lblprodQtdMin
            // 
            this.lblprodQtdMin.AutoSize = true;
            this.lblprodQtdMin.Location = new System.Drawing.Point(11, 312);
            this.lblprodQtdMin.Name = "lblprodQtdMin";
            this.lblprodQtdMin.Size = new System.Drawing.Size(85, 13);
            this.lblprodQtdMin.TabIndex = 23;
            this.lblprodQtdMin.Text = "Quantidade Min:";
            // 
            // txtbprodQtdMin
            // 
            this.txtbprodQtdMin.Location = new System.Drawing.Point(102, 309);
            this.txtbprodQtdMin.Name = "txtbprodQtdMin";
            this.txtbprodQtdMin.Size = new System.Drawing.Size(156, 20);
            this.txtbprodQtdMin.TabIndex = 24;
            // 
            // lblprodCodBar
            // 
            this.lblprodCodBar.AutoSize = true;
            this.lblprodCodBar.Location = new System.Drawing.Point(11, 338);
            this.lblprodCodBar.Name = "lblprodCodBar";
            this.lblprodCodBar.Size = new System.Drawing.Size(91, 13);
            this.lblprodCodBar.TabIndex = 25;
            this.lblprodCodBar.Text = "Codigo de Barras:";
            // 
            // txtbprodCodBar
            // 
            this.txtbprodCodBar.Location = new System.Drawing.Point(108, 335);
            this.txtbprodCodBar.Name = "txtbprodCodBar";
            this.txtbprodCodBar.Size = new System.Drawing.Size(150, 20);
            this.txtbprodCodBar.TabIndex = 26;
            // 
            // bttnGravar
            // 
            this.bttnGravar.Location = new System.Drawing.Point(279, 317);
            this.bttnGravar.Name = "bttnGravar";
            this.bttnGravar.Size = new System.Drawing.Size(75, 23);
            this.bttnGravar.TabIndex = 27;
            this.bttnGravar.Text = "Gravar";
            this.bttnGravar.UseVisualStyleBackColor = true;
            this.bttnGravar.Click += new System.EventHandler(this.bttnGravar_Click);
            // 
            // bttnNovo
            // 
            this.bttnNovo.Location = new System.Drawing.Point(360, 316);
            this.bttnNovo.Name = "bttnNovo";
            this.bttnNovo.Size = new System.Drawing.Size(75, 23);
            this.bttnNovo.TabIndex = 28;
            this.bttnNovo.Text = "Novo";
            this.bttnNovo.UseVisualStyleBackColor = true;
            this.bttnNovo.Click += new System.EventHandler(this.bttnNovo_Click);
            // 
            // bttnRemover
            // 
            this.bttnRemover.Location = new System.Drawing.Point(441, 317);
            this.bttnRemover.Name = "bttnRemover";
            this.bttnRemover.Size = new System.Drawing.Size(75, 23);
            this.bttnRemover.TabIndex = 29;
            this.bttnRemover.Text = "Remover";
            this.bttnRemover.UseVisualStyleBackColor = true;
            this.bttnRemover.Click += new System.EventHandler(this.bttnRemover_Click);
            // 
            // bttnVoltarPro
            // 
            this.bttnVoltarPro.Location = new System.Drawing.Point(745, 316);
            this.bttnVoltarPro.Name = "bttnVoltarPro";
            this.bttnVoltarPro.Size = new System.Drawing.Size(75, 23);
            this.bttnVoltarPro.TabIndex = 30;
            this.bttnVoltarPro.Text = "Voltar";
            this.bttnVoltarPro.UseVisualStyleBackColor = true;
            this.bttnVoltarPro.Click += new System.EventHandler(this.bttnVoltarPro_Click);
            // 
            // lblTituloPro
            // 
            this.lblTituloPro.AutoSize = true;
            this.lblTituloPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPro.ForeColor = System.Drawing.Color.Green;
            this.lblTituloPro.Location = new System.Drawing.Point(503, 9);
            this.lblTituloPro.Name = "lblTituloPro";
            this.lblTituloPro.Size = new System.Drawing.Size(94, 25);
            this.lblTituloPro.TabIndex = 31;
            this.lblTituloPro.Text = "Produto";
            // 
            // FormularioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 361);
            this.Controls.Add(this.lblTituloPro);
            this.Controls.Add(this.bttnVoltarPro);
            this.Controls.Add(this.bttnRemover);
            this.Controls.Add(this.bttnNovo);
            this.Controls.Add(this.bttnGravar);
            this.Controls.Add(this.txtbprodCodBar);
            this.Controls.Add(this.lblprodCodBar);
            this.Controls.Add(this.txtbprodQtdMin);
            this.Controls.Add(this.lblprodQtdMin);
            this.Controls.Add(this.lblprodQtdMult);
            this.Controls.Add(this.txtbprodQtdMult);
            this.Controls.Add(this.txtbprodPesLiq);
            this.Controls.Add(this.lblprodPesLiq);
            this.Controls.Add(this.lblprodPesBru);
            this.Controls.Add(this.lblprodStatus);
            this.Controls.Add(this.lblprodEspTec);
            this.Controls.Add(this.lblprodUniMed);
            this.Controls.Add(this.txtbprodEspTec);
            this.Controls.Add(this.txtbprodStatus);
            this.Controls.Add(this.txtbPesBru);
            this.Controls.Add(this.txtbprodUniMed);
            this.Controls.Add(this.txtbprodMar);
            this.Controls.Add(this.txtbprodSubID);
            this.Controls.Add(this.dtgrdvwPro);
            this.Controls.Add(this.lblMarIDprod);
            this.Controls.Add(this.lblSubIDprod);
            this.Controls.Add(this.txtbprodDes);
            this.Controls.Add(this.lblprodutoDes);
            this.Controls.Add(this.txtbprodCod);
            this.Controls.Add(this.txtbprodID);
            this.Controls.Add(this.lblprodCod);
            this.Controls.Add(this.lblprodID);
            this.Name = "FormularioProduto";
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprodID;
        private System.Windows.Forms.Label lblprodCod;
        private System.Windows.Forms.TextBox txtbprodID;
        private System.Windows.Forms.TextBox txtbprodCod;
        private System.Windows.Forms.Label lblprodutoDes;
        private System.Windows.Forms.TextBox txtbprodDes;
        private System.Windows.Forms.Label lblSubIDprod;
        private System.Windows.Forms.Label lblMarIDprod;
        private System.Windows.Forms.DataGridView dtgrdvwPro;
        private System.Windows.Forms.TextBox txtbprodSubID;
        private System.Windows.Forms.TextBox txtbprodMar;
        private System.Windows.Forms.TextBox txtbprodUniMed;
        private System.Windows.Forms.TextBox txtbPesBru;
        private System.Windows.Forms.TextBox txtbprodStatus;
        private System.Windows.Forms.TextBox txtbprodEspTec;
        private System.Windows.Forms.Label lblprodUniMed;
        private System.Windows.Forms.Label lblprodEspTec;
        private System.Windows.Forms.Label lblprodStatus;
        private System.Windows.Forms.Label lblprodPesBru;
        private System.Windows.Forms.Label lblprodPesLiq;
        private System.Windows.Forms.TextBox txtbprodPesLiq;
        private System.Windows.Forms.TextBox txtbprodQtdMult;
        private System.Windows.Forms.Label lblprodQtdMult;
        private System.Windows.Forms.Label lblprodQtdMin;
        private System.Windows.Forms.TextBox txtbprodQtdMin;
        private System.Windows.Forms.Label lblprodCodBar;
        private System.Windows.Forms.TextBox txtbprodCodBar;
        private System.Windows.Forms.Button bttnGravar;
        private System.Windows.Forms.Button bttnNovo;
        private System.Windows.Forms.Button bttnRemover;
        private System.Windows.Forms.Button bttnVoltarPro;
        private System.Windows.Forms.Label lblTituloPro;
    }
}