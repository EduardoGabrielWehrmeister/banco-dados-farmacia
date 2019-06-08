namespace View
{
    partial class RemedioEditar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSolido = new System.Windows.Forms.Label();
            this.rbSolidoSim = new System.Windows.Forms.RadioButton();
            this.rbSolidoNao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGenerico = new System.Windows.Forms.Label();
            this.rbGenericoSim = new System.Windows.Forms.RadioButton();
            this.rbGenericoNao = new System.Windows.Forms.RadioButton();
            this.gbPrecisaReceita = new System.Windows.Forms.GroupBox();
            this.lblReceita = new System.Windows.Forms.Label();
            this.rbPrecisaReceitaSim = new System.Windows.Forms.RadioButton();
            this.rbPrecisaReceitaNao = new System.Windows.Forms.RadioButton();
            this.rtbBula = new System.Windows.Forms.RichTextBox();
            this.rtbContraIndicacao = new System.Windows.Forms.RichTextBox();
            this.cbFaixa = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblBula = new System.Windows.Forms.Label();
            this.lblContraIndicacao = new System.Windows.Forms.Label();
            this.lblFaixa = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPrecisaReceita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(327, 342);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(461, 96);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSolido);
            this.groupBox3.Controls.Add(this.rbSolidoSim);
            this.groupBox3.Controls.Add(this.rbSolidoNao);
            this.groupBox3.Location = new System.Drawing.Point(327, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 94);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lblSolido
            // 
            this.lblSolido.AutoSize = true;
            this.lblSolido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolido.Location = new System.Drawing.Point(-5, 0);
            this.lblSolido.Name = "lblSolido";
            this.lblSolido.Size = new System.Drawing.Size(72, 25);
            this.lblSolido.TabIndex = 3;
            this.lblSolido.Text = "Sólido";
            // 
            // rbSolidoSim
            // 
            this.rbSolidoSim.AutoSize = true;
            this.rbSolidoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolidoSim.Location = new System.Drawing.Point(6, 28);
            this.rbSolidoSim.Name = "rbSolidoSim";
            this.rbSolidoSim.Size = new System.Drawing.Size(66, 29);
            this.rbSolidoSim.TabIndex = 11;
            this.rbSolidoSim.TabStop = true;
            this.rbSolidoSim.Text = "Sim";
            this.rbSolidoSim.UseVisualStyleBackColor = true;
            // 
            // rbSolidoNao
            // 
            this.rbSolidoNao.AutoSize = true;
            this.rbSolidoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSolidoNao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSolidoNao.Location = new System.Drawing.Point(78, 28);
            this.rbSolidoNao.Name = "rbSolidoNao";
            this.rbSolidoNao.Size = new System.Drawing.Size(69, 29);
            this.rbSolidoNao.TabIndex = 12;
            this.rbSolidoNao.TabStop = true;
            this.rbSolidoNao.Text = "Não";
            this.rbSolidoNao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGenerico);
            this.groupBox2.Controls.Add(this.rbGenericoSim);
            this.groupBox2.Controls.Add(this.rbGenericoNao);
            this.groupBox2.Location = new System.Drawing.Point(327, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 97);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblGenerico
            // 
            this.lblGenerico.AutoSize = true;
            this.lblGenerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerico.Location = new System.Drawing.Point(-5, 0);
            this.lblGenerico.Name = "lblGenerico";
            this.lblGenerico.Size = new System.Drawing.Size(99, 25);
            this.lblGenerico.TabIndex = 1;
            this.lblGenerico.Text = "Genérico";
            // 
            // rbGenericoSim
            // 
            this.rbGenericoSim.AutoSize = true;
            this.rbGenericoSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenericoSim.Location = new System.Drawing.Point(6, 36);
            this.rbGenericoSim.Name = "rbGenericoSim";
            this.rbGenericoSim.Size = new System.Drawing.Size(66, 29);
            this.rbGenericoSim.TabIndex = 8;
            this.rbGenericoSim.TabStop = true;
            this.rbGenericoSim.Text = "Sim";
            this.rbGenericoSim.UseVisualStyleBackColor = true;
            // 
            // rbGenericoNao
            // 
            this.rbGenericoNao.AutoSize = true;
            this.rbGenericoNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenericoNao.Location = new System.Drawing.Point(78, 36);
            this.rbGenericoNao.Name = "rbGenericoNao";
            this.rbGenericoNao.Size = new System.Drawing.Size(69, 29);
            this.rbGenericoNao.TabIndex = 9;
            this.rbGenericoNao.TabStop = true;
            this.rbGenericoNao.Text = "Não";
            this.rbGenericoNao.UseVisualStyleBackColor = true;
            // 
            // gbPrecisaReceita
            // 
            this.gbPrecisaReceita.Controls.Add(this.lblReceita);
            this.gbPrecisaReceita.Controls.Add(this.rbPrecisaReceitaSim);
            this.gbPrecisaReceita.Controls.Add(this.rbPrecisaReceitaNao);
            this.gbPrecisaReceita.Location = new System.Drawing.Point(327, 37);
            this.gbPrecisaReceita.Name = "gbPrecisaReceita";
            this.gbPrecisaReceita.Size = new System.Drawing.Size(461, 96);
            this.gbPrecisaReceita.TabIndex = 34;
            this.gbPrecisaReceita.TabStop = false;
            this.gbPrecisaReceita.Text = "groupBox1";
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceita.Location = new System.Drawing.Point(-5, 0);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(193, 25);
            this.lblReceita.TabIndex = 14;
            this.lblReceita.Text = "Precisa de Receita";
            // 
            // rbPrecisaReceitaSim
            // 
            this.rbPrecisaReceitaSim.AutoSize = true;
            this.rbPrecisaReceitaSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrecisaReceitaSim.Location = new System.Drawing.Point(6, 45);
            this.rbPrecisaReceitaSim.Name = "rbPrecisaReceitaSim";
            this.rbPrecisaReceitaSim.Size = new System.Drawing.Size(66, 29);
            this.rbPrecisaReceitaSim.TabIndex = 15;
            this.rbPrecisaReceitaSim.TabStop = true;
            this.rbPrecisaReceitaSim.Text = "Sim";
            this.rbPrecisaReceitaSim.UseVisualStyleBackColor = true;
            // 
            // rbPrecisaReceitaNao
            // 
            this.rbPrecisaReceitaNao.AutoSize = true;
            this.rbPrecisaReceitaNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrecisaReceitaNao.Location = new System.Drawing.Point(78, 45);
            this.rbPrecisaReceitaNao.Name = "rbPrecisaReceitaNao";
            this.rbPrecisaReceitaNao.Size = new System.Drawing.Size(69, 29);
            this.rbPrecisaReceitaNao.TabIndex = 16;
            this.rbPrecisaReceitaNao.TabStop = true;
            this.rbPrecisaReceitaNao.Text = "Não";
            this.rbPrecisaReceitaNao.UseVisualStyleBackColor = true;
            // 
            // rtbBula
            // 
            this.rtbBula.Location = new System.Drawing.Point(9, 230);
            this.rtbBula.Name = "rtbBula";
            this.rtbBula.Size = new System.Drawing.Size(295, 67);
            this.rtbBula.TabIndex = 33;
            this.rtbBula.Text = "";
            // 
            // rtbContraIndicacao
            // 
            this.rtbContraIndicacao.Location = new System.Drawing.Point(9, 328);
            this.rtbContraIndicacao.Name = "rtbContraIndicacao";
            this.rtbContraIndicacao.Size = new System.Drawing.Size(295, 67);
            this.rtbContraIndicacao.TabIndex = 32;
            this.rtbContraIndicacao.Text = "";
            // 
            // cbFaixa
            // 
            this.cbFaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFaixa.FormattingEnabled = true;
            this.cbFaixa.Items.AddRange(new object[] {
            "Vermelha",
            "Amarela",
            "Branca",
            "Preta"});
            this.cbFaixa.Location = new System.Drawing.Point(9, 166);
            this.cbFaixa.Name = "cbFaixa";
            this.cbFaixa.Size = new System.Drawing.Size(295, 33);
            this.cbFaixa.TabIndex = 31;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Medicamento Fitoterápico.",
            "Medicamento Alopático.",
            "Medicamento Homeopático.",
            "Medicamento Similar.",
            "Medicamento Genérico.",
            "Medicamento de Referência.",
            "Medicamento Manipulado."});
            this.cbCategoria.Location = new System.Drawing.Point(9, 100);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(295, 33);
            this.cbCategoria.TabIndex = 30;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 31);
            this.txtNome.TabIndex = 29;
            // 
            // lblBula
            // 
            this.lblBula.AutoSize = true;
            this.lblBula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBula.Location = new System.Drawing.Point(4, 202);
            this.lblBula.Name = "lblBula";
            this.lblBula.Size = new System.Drawing.Size(55, 25);
            this.lblBula.TabIndex = 28;
            this.lblBula.Text = "Bula";
            // 
            // lblContraIndicacao
            // 
            this.lblContraIndicacao.AutoSize = true;
            this.lblContraIndicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraIndicacao.Location = new System.Drawing.Point(4, 300);
            this.lblContraIndicacao.Name = "lblContraIndicacao";
            this.lblContraIndicacao.Size = new System.Drawing.Size(185, 25);
            this.lblContraIndicacao.TabIndex = 27;
            this.lblContraIndicacao.Text = "Contra Indicações";
            // 
            // lblFaixa
            // 
            this.lblFaixa.AutoSize = true;
            this.lblFaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaixa.Location = new System.Drawing.Point(4, 136);
            this.lblFaixa.Name = "lblFaixa";
            this.lblFaixa.Size = new System.Drawing.Size(65, 25);
            this.lblFaixa.TabIndex = 26;
            this.lblFaixa.Text = "Faixa";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(4, 71);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(105, 25);
            this.lblCategoria.TabIndex = 25;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(4, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(4, 413);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(29, 25);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "Id";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(39, 407);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(265, 31);
            this.txtCodigo.TabIndex = 39;
            // 
            // RemedioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPrecisaReceita);
            this.Controls.Add(this.rtbBula);
            this.Controls.Add(this.rtbContraIndicacao);
            this.Controls.Add(this.cbFaixa);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblBula);
            this.Controls.Add(this.lblContraIndicacao);
            this.Controls.Add(this.lblFaixa);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNome);
            this.Name = "RemedioEditar";
            this.Text = "RemedioEditar";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPrecisaReceita.ResumeLayout(false);
            this.gbPrecisaReceita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSolido;
        private System.Windows.Forms.RadioButton rbSolidoSim;
        private System.Windows.Forms.RadioButton rbSolidoNao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGenerico;
        private System.Windows.Forms.RadioButton rbGenericoSim;
        private System.Windows.Forms.RadioButton rbGenericoNao;
        private System.Windows.Forms.GroupBox gbPrecisaReceita;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.RadioButton rbPrecisaReceitaSim;
        private System.Windows.Forms.RadioButton rbPrecisaReceitaNao;
        private System.Windows.Forms.RichTextBox rtbBula;
        private System.Windows.Forms.RichTextBox rtbContraIndicacao;
        private System.Windows.Forms.ComboBox cbFaixa;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblBula;
        private System.Windows.Forms.Label lblContraIndicacao;
        private System.Windows.Forms.Label lblFaixa;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}