using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RevisadorDeFrase.Modelos;

namespace RevisadorDeFrase
{
    public partial class FormEditarTexto : Form
    {
        private readonly RevisadorFraseContext _contexto;
        private readonly Texto _texto;

        public FormEditarTexto(int idTexto)
        {
            InitializeComponent();

            _contexto = new RevisadorFraseContext();

            _texto= _contexto.Textos.Find(idTexto);

            PrepararTela();
        }

        private void PrepararTela()
        {
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);

            textTitulo.Text = _texto.Titulo;
            comboIdioma.SelectedItem = _texto.Idioma;
            textTags.Text = _texto.Tags;
            textTexto.Text = _texto.TextoOutroIdioma;
            textTextoPortugues.Text = _texto.TextoPortugues;           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaPreenchimentoDosCampos();

                if (MessageBox.Show("Deseja salvar as alterações neste Texto?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    _texto.Titulo = textTitulo.Text;
                    _texto.Tags = textTags.Text;
                    _texto.TextoOutroIdioma = textTexto.Text;
                    _texto.TextoPortugues = textTextoPortugues.Text;
                    _texto.Idioma = (Idioma)comboIdioma.SelectedItem;

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

        private void VerificaPreenchimentoDosCampos()
        {
            if (string.IsNullOrEmpty(textTitulo.Text))
                throw new Exception("Adicione um título");

            if (comboIdioma.SelectedItem == null || (int)comboIdioma.SelectedItem <= 0)
                throw new Exception("Selecione um idioma");

            if (string.IsNullOrEmpty(textTexto.Text))
                throw new Exception("Adicione um texto");
        }

        private void comboIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            var idiomaSelecionado = (Idioma)comboIdioma.SelectedItem;

            switch (idiomaSelecionado)
            {
                case Idioma.Ingles:
                    tabOutroIdioma.Text = "Texto em Inglês";
                    break;
                case Idioma.Frances:
                    tabOutroIdioma.Text = "Texto em Francês";
                    break;
                case Idioma.Alemao:
                    tabOutroIdioma.Text = "Texto em Alemão";
                    break;
            }
        }

        private void btnLimparLegenda_Click(object sender, EventArgs e)
        {
            var texto = Regex.Replace(textTexto.Text, "(\\[.*?\\])|(\\<.*?\\>)", string.Empty);

            var linhas = texto.Split('\r', '\n').ToList();

            linhas = linhas.FindAll(c => !c.Contains("-->") && !int.TryParse(c, out var saida));

            var builder = new StringBuilder();

            linhas.ForEach(c => builder.Append(" ").Append(c));

            var resultado = builder.ToString();

            while (resultado.Contains("  "))
                resultado = resultado.Replace("  ", " ");

            textTexto.Text = resultado;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
