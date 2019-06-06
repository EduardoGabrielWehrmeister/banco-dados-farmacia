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
    public partial class ComestivelCadastro : Form
    {
        public ComestivelCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Comestivel comestivel = new Comestivel();
            comestivel.Nome = txtNome.Text;
            comestivel.DataVencimento = Convert.ToDateTime(dtpDataVencimento.Text);
            comestivel.Marca = txtMarca.Text;

            if (txtNome.Text.Length < 3)
            {
                MessageBox.Show("Informe ao menos 3 caracteres em NOME");
                txtNome.Focus(); return;
            }

            try
            {
                comestivel.Valor = Convert.ToDecimal(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um número no campo VALOR");
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
                MessageBox.Show("Informe ao menos 3 caracteres no campo MARCA");
                txtMarca.Focus();return;
            }
            Close();

            ComestivelRepositorio repositorio = new ComestivelRepositorio();
            repositorio.Inserir(comestivel);
        }
    }
}
