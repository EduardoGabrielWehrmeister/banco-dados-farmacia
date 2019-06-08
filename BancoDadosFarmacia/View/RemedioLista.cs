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
    public partial class RemedioLista : Form
    {
        public RemedioLista()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RemedioCadastro cadastro = new RemedioCadastro();
            cadastro.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RemedioRepositorio repositorio = new RemedioRepositorio();
            repositorio.Apagar(id);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void AtualizarTabela()
        {
            RemedioRepositorio repositorio = new RemedioRepositorio();
            List<Remedio> remedios = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();

            for(int i = 0; i < remedios.Count; i++)
            {
                Remedio remedio = remedios[i];
                dataGridView1.Rows.Add(new object[] { remedio.Id, remedio.Nome, remedio.Faixa, remedio.Categoria, remedio.Receita });
            }
        }

        private void RemedioLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            RemedioRepositorio repositorio = new RemedioRepositorio();
            Remedio remedio = repositorio.ObterPeloId(id);

            RemedioEditar remedioEditar = new RemedioEditar(remedio);
            remedioEditar.ShowDialog();
        }
    }
}
