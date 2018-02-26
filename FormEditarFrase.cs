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
    public partial class FormEditarFrase : Form
    {
        private readonly RevisadorFraseContext _contexto;
        private readonly Frase _frase;

        public FormEditarFrase(Frase frase)
        {
            InitializeComponent();

            _contexto = new RevisadorFraseContext();

            _frase = _contexto.Frases.Find(frase.ID);

            comboIdioma.Items.Add(Idioma.Nenhum);
            comboIdioma.Items.Add(Idioma.Portugues);
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);

            textFrase.Text = _frase.FraseOutraLingua;
            textFrasePortugues.Text = _frase.FraseEmPortugues;
            comboIdioma.SelectedItem = _frase.Idioma;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaValidadeDaFrase();

                if (MessageBox.Show("Deseja salvar as alterações nesta frase?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    _frase.FraseOutraLingua = textFrase.Text;
                    _frase.FraseEmPortugues = textFrasePortugues.Text;
                    _frase.Idioma = (Idioma)comboIdioma.SelectedItem;

                    _contexto.SaveChanges();

                    MessageBox.Show("Texto salvo com sucesso?", "Sucesso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
