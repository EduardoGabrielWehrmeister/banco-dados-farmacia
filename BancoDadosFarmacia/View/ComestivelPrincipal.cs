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
    public partial class ComestivelPrincipal : Form
    {
        public ComestivelPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarComestivel_Click(object sender, EventArgs e)
        {
            ComestivelLista form = new ComestivelLista();
            form.ShowDialog();
        }
    }
}
