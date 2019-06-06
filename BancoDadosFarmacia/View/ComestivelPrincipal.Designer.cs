namespace View
{
    partial class ComestivelPrincipal
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
            this.btnCadastrarComestivel = new System.Windows.Forms.Button();
            this.btnCadastrarRemedios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarComestivel
            // 
            this.btnCadastrarComestivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarComestivel.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarComestivel.Name = "btnCadastrarComestivel";
            this.btnCadastrarComestivel.Size = new System.Drawing.Size(372, 204);
            this.btnCadastrarComestivel.TabIndex = 1;
            this.btnCadastrarComestivel.Text = "Cadastrar Comestivel";
            this.btnCadastrarComestivel.UseVisualStyleBackColor = true;
            this.btnCadastrarComestivel.Click += new System.EventHandler(this.btnCadastrarComestivel_Click);
            // 
            // btnCadastrarRemedios
            // 
            this.btnCadastrarRemedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarRemedios.Location = new System.Drawing.Point(405, 12);
            this.btnCadastrarRemedios.Name = "btnCadastrarRemedios";
            this.btnCadastrarRemedios.Size = new System.Drawing.Size(383, 204);
            this.btnCadastrarRemedios.TabIndex = 2;
            this.btnCadastrarRemedios.Text = "Cadastrar Remédios";
            this.btnCadastrarRemedios.UseVisualStyleBackColor = true;
            this.btnCadastrarRemedios.Click += new System.EventHandler(this.btnCadastrarRemedios_Click);
            // 
            // ComestivelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarRemedios);
            this.Controls.Add(this.btnCadastrarComestivel);
            this.Name = "ComestivelPrincipal";
            this.Text = "ComestivelPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarComestivel;
        private System.Windows.Forms.Button btnCadastrarRemedios;
    }
}