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
            this.SuspendLayout();
            // 
            // btnCadastrarComestivel
            // 
            this.btnCadastrarComestivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarComestivel.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarComestivel.Name = "btnCadastrarComestivel";
            this.btnCadastrarComestivel.Size = new System.Drawing.Size(312, 179);
            this.btnCadastrarComestivel.TabIndex = 1;
            this.btnCadastrarComestivel.Text = "Cadastrar Comestivel";
            this.btnCadastrarComestivel.UseVisualStyleBackColor = true;
            this.btnCadastrarComestivel.Click += new System.EventHandler(this.btnCadastrarComestivel_Click);
            // 
            // ComestivelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarComestivel);
            this.Name = "ComestivelPrincipal";
            this.Text = "ComestivelPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarComestivel;
    }
}