namespace AtivProdutos
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodMovto = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblDtMovto = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.gboTipo = new System.Windows.Forms.GroupBox();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.lblObs = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCodMovto = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dtpMovto = new System.Windows.Forms.DateTimePicker();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvMovto = new System.Windows.Forms.DataGridView();
            this.gboTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimento";
            // 
            // lblCodMovto
            // 
            this.lblCodMovto.AutoSize = true;
            this.lblCodMovto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodMovto.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCodMovto.Location = new System.Drawing.Point(77, 106);
            this.lblCodMovto.Name = "lblCodMovto";
            this.lblCodMovto.Size = new System.Drawing.Size(57, 13);
            this.lblCodMovto.TabIndex = 1;
            this.lblCodMovto.Text = "CodMovto";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCod.Location = new System.Drawing.Point(77, 152);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(41, 13);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Codigo";
            // 
            // lblDtMovto
            // 
            this.lblDtMovto.AutoSize = true;
            this.lblDtMovto.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtMovto.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDtMovto.Location = new System.Drawing.Point(77, 201);
            this.lblDtMovto.Name = "lblDtMovto";
            this.lblDtMovto.Size = new System.Drawing.Size(88, 13);
            this.lblDtMovto.TabIndex = 3;
            this.lblDtMovto.Text = "Data Movimento";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblQuant.Location = new System.Drawing.Point(84, 374);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(63, 13);
            this.lblQuant.TabIndex = 4;
            this.lblQuant.Text = "Quantidade";
            // 
            // gboTipo
            // 
            this.gboTipo.Controls.Add(this.rdbSaida);
            this.gboTipo.Controls.Add(this.rdbEntrada);
            this.gboTipo.Location = new System.Drawing.Point(80, 247);
            this.gboTipo.Name = "gboTipo";
            this.gboTipo.Size = new System.Drawing.Size(143, 100);
            this.gboTipo.TabIndex = 4;
            this.gboTipo.TabStop = false;
            this.gboTipo.Text = "Tipo";
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSaida.ForeColor = System.Drawing.Color.SkyBlue;
            this.rdbSaida.Location = new System.Drawing.Point(6, 68);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(53, 17);
            this.rdbSaida.TabIndex = 6;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "Saida";
            this.rdbSaida.UseVisualStyleBackColor = true;
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntrada.ForeColor = System.Drawing.Color.SkyBlue;
            this.rdbEntrada.Location = new System.Drawing.Point(7, 34);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(65, 17);
            this.rdbEntrada.TabIndex = 5;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblObs.Location = new System.Drawing.Point(86, 403);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(66, 13);
            this.lblObs.TabIndex = 6;
            this.lblObs.Text = "Observação";
            // 
            // btnInserir
            // 
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Location = new System.Drawing.Point(86, 516);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCodMovto
            // 
            this.txtCodMovto.Location = new System.Drawing.Point(180, 106);
            this.txtCodMovto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodMovto.Name = "txtCodMovto";
            this.txtCodMovto.Size = new System.Drawing.Size(68, 21);
            this.txtCodMovto.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(180, 152);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(68, 21);
            this.txtCod.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(275, 89);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(207, 106);
            this.txtDesc.TabIndex = 88;
            this.txtDesc.Visible = false;
            // 
            // dtpMovto
            // 
            this.dtpMovto.Location = new System.Drawing.Point(174, 201);
            this.dtpMovto.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMovto.Name = "dtpMovto";
            this.dtpMovto.Size = new System.Drawing.Size(232, 21);
            this.dtpMovto.TabIndex = 3;
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(174, 374);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(68, 21);
            this.txtQuant.TabIndex = 7;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(86, 418);
            this.txtObs.Margin = new System.Windows.Forms.Padding(2);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(219, 84);
            this.txtObs.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(180, 516);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(86, 545);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 11;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.Color.Black;
            this.btnAlterar.Location = new System.Drawing.Point(180, 545);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 25);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvMovto
            // 
            this.dgvMovto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMovto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovto.Location = new System.Drawing.Point(362, 289);
            this.dgvMovto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMovto.Name = "dgvMovto";
            this.dgvMovto.RowHeadersWidth = 62;
            this.dgvMovto.RowTemplate.Height = 28;
            this.dgvMovto.Size = new System.Drawing.Size(396, 250);
            this.dgvMovto.TabIndex = 17;
            this.dgvMovto.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 600);
            this.Controls.Add(this.dgvMovto);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.dtpMovto);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtCodMovto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.gboTipo);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblDtMovto);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblCodMovto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gboTipo.ResumeLayout(false);
            this.gboTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodMovto;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblDtMovto;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.GroupBox gboTipo;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtCodMovto;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtpMovto;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvMovto;
    }
}