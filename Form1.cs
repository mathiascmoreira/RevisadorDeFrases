using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisadorDeFrase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListaDeTextos_Click(object sender, EventArgs e)
        {
            var listaDeTextosForm = new FormListaDeTextos();

            listaDeTextosForm.Show();
        }

        private void btnListaDeFrases_Click(object sender, EventArgs e)
        {
            var listaDeFrasesForm = new FormListaDeFrases();

            listaDeFrasesForm.Show();
        }
    }
}
