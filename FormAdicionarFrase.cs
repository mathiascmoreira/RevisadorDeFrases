using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevisadorDeFrase.Modelos;

namespace RevisadorDeFrase
{
    public partial class FormAdicionarFrase : Form
    {
        private readonly RevisadorFraseContext _contexto;

        public FormAdicionarFrase()
        {
            InitializeComponent();

            _contexto = new RevisadorFraseContext();

            comboIdioma.Items.Add(Idioma.Nenhum);
            comboIdioma.Items.Add(Idioma.Portugues);
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaValidadeDaFrase();

                if (MessageBox.Show("Deseja salvar esta Frase?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    var novaFrase = new Frase()
                    {
                        FraseEmPortugues = textFrasePortugues.Text,
                        FraseOutraLingua = textFrase.Text,
                        Idioma = (Idioma)comboIdioma.SelectedItem,
                        Compreensao = 0,
                        DataDaUltimaRevisao = DateTime.Now.AddMonths(-2)
                    };

                    _contexto.Frases.Add(novaFrase);

                    _contexto.SaveChanges();

                    MessageBox.Show("Texto salvo com sucesso?", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    textFrase.Text = string.Empty;
                    textFrasePortugues.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void VerificaValidadeDaFrase()
        {
            if (string.IsNullOrEmpty(textFrasePortugues.Text) || string.IsNullOrEmpty(textFrase.Text))
                throw new Exception("Os dois campos de frase devem estar preenchidos");

            if (comboIdioma.SelectedItem == null || (int)comboIdioma.SelectedItem <= 0)
                throw new Exception("Selecione um idioma");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
