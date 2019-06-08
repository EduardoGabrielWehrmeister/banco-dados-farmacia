using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class RemedioEditar : Form
    {
        public RemedioEditar()
        {
            InitializeComponent();
        }

        public RemedioEditar(Remedio remedio)
        {
            InitializeComponent();
            txtNome.Text = remedio.Nome;
            txtCodigo.Text = remedio.Id.ToString();
            cbCategoria.Text = remedio.Categoria.ToString();
            cbFaixa.Text = remedio.Faixa.ToString();
            rtbBula.Text = remedio.Bula;
            rtbContraIndicacao.Text = remedio.ContraIndicacao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Remedio remedio = new Remedio();
            RemedioRepositorio repositorio = new RemedioRepositorio();
            remedio.Id = Convert.ToInt32(txtCodigo.Text);
            remedio.Nome = txtNome.Text;
            remedio.Receita = rbPrecisaReceitaSim.Checked;
            remedio.Categoria = cbCategoria.Text;
            remedio.Solido = rbSolidoSim.Checked;
            remedio.ContraIndicacao = rtbContraIndicacao.Text;
            remedio.Bula = rtbBula.Text;
            remedio.Faixa = cbFaixa.Text;
            remedio.Receita = rbPrecisaReceitaSim.Checked;

            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Informe ao menos 3 no campo NOME");
                txtNome.Focus(); return;
            }

            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria no campo CATEGORIA");
                cbCategoria.DroppedDown = true;
                return;
            }

            if (cbFaixa.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria no campo FAIXA");
                cbFaixa.DroppedDown = true;
                return;
            }

            if (rtbBula.Text.Length < 10)
            {
                MessageBox.Show("Informe ao menos 10 caracteres no compo BULA");
                rtbBula.Focus(); return;
            }

            if (rtbContraIndicacao.Text.Length < 10)
            {
                MessageBox.Show("Informe ao menos 10 caracteres no compo CONTRA INDICAÇÕES");
                rtbContraIndicacao.Focus(); return;
            }

            MessageBox.Show("Editado com sucesso");
            Close();
            repositorio.Atualizar(remedio);
        }
    }
}
