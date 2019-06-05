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
    public partial class ComestivelEditar : Form
    {
        public ComestivelEditar()
        {
            InitializeComponent();
        }

        public ComestivelEditar(Comestivel comestivel)
        {
            InitializeComponent();
            txtNome.Text = comestivel.Nome;
            txtCodigo.Text = comestivel.Id.ToString();
            dtpDataVencimento.Text = comestivel.DataVencimento.ToString("yyyy-MM-dd");
            txtValor.Text = Convert.ToString(comestivel.Valor);
            txtMarca.Text = comestivel.Marca;
            txtQuantidade.Text = Convert.ToString(comestivel.Quantidade);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            comestivel.Id = Convert.ToInt32(txtCodigo.Text);
            comestivel.Nome = txtNome.Text;
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.Marca = txtMarca.Text;
            repositorio.Atualizar(comestivel);

            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Digite ao menos 3 Caracteres em NOME");
                txtNome.Focus(); return;
            }

            try
            {
                comestivel.Valor = Convert.ToDecimal(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor no campo VALOR");
                txtValor.Focus();return;
            }

            try
            {
                comestivel.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor Inteiro no campo QUANTIDADE");
                txtQuantidade.Focus();return;
            }

            if(txtMarca.Text.Length < 3)
            {
                MessageBox.Show("Didite ao menos 3 caracteres em MARCA");
                txtMarca.Focus();return;
            }

            MessageBox.Show("Editado com Sucesso.");
            Close();
        }
    }
}
