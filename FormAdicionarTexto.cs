using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RevisadorDeFrase.Modelos;

namespace RevisadorDeFrase
{
    public partial class FormAdicionarTexto : Form
    {
        private readonly RevisadorFraseContext _contexto;

        public FormAdicionarTexto()
        {
            InitializeComponent();

            _contexto = new RevisadorFraseContext();

            PrepararTela();           
        }

        private void PrepararTela()
        {
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);

            comboIdioma.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaPreenchimentoDosCampos();

                if (MessageBox.Show("Deseja salvar este Texto?", "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    var novoTexto = new Texto()
                    {
                        Titulo = textTitulo.Text,
                        Tags = textTags.Text,
                        TextoOutroIdioma = textTexto.Text,
                        TextoPortugues = textTextoPortugues.Text,
                        Idioma = (Idioma)comboIdioma.SelectedItem,
                        DataDeAdicao = DateTime.Now
                    };

                    _contexto.Textos.Add(novoTexto);

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
