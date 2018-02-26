using RevisadorDeFrase.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RevisadorDeFrase
{
    public partial class FormRevisarTexto : Form
    {
        private readonly RevisadorFraseContext _contexto;

        private List<Texto> _textosParaRevisar;
        private List<RevisaoDoTexto> _historicoDosTextos;
        private Texto _textoAtual;

        public FormRevisarTexto()
        {
            InitializeComponent();

            _contexto = new RevisadorFraseContext();

            _textosParaRevisar = new List<Texto>();

            _historicoDosTextos = new List<RevisaoDoTexto>();

            PrepararTela();

            IniciarRevisao();
        }

        private void PrepararTela()
        {
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);
        }

        private void IniciarRevisao()
        {
            CarregarTextosParaRevisar();

            if (!_textosParaRevisar.Any())
            {
                if (MessageBox.Show("Não há textos para revisar hoje e nem textos novos, deseja adiantar a proxima revisão", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    AdiantarRevisao();
                else
                    Close();
            }

            CarregarProximoTexto();
        }

        private void AdiantarRevisao()
        {
            throw new NotImplementedException();
        }

        private void CarregarProximoTexto()
        {
            if (!_textosParaRevisar.Any())
            {
                if (MessageBox.Show("Revisão concluida, deseja adiantar a proxima revisão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    AdiantarRevisao();
                else
                    Close();
            }

            _textoAtual = _textosParaRevisar.First();

            if (_textoAtual.DataDaPrimeiraRevisao == null)
                _textoAtual.DataDaPrimeiraRevisao = DateTime.Now;

            PreencherControles();
        }

        private void CarregarTextosParaRevisar()
        {
            var textos = _contexto.Textos.Where(c => c.DataDaProximaRevisao.Value.Date.Equals(DateTime.Now.Date) && c.DataDaPrimeiraRevisao != null).ToList();

            var quantidade = textos.Count();

            if (quantidade < 100)
            {
                var quantidadeDeFrasesNovas = 100 - quantidade;

                var textosNovos = _contexto.Textos.Where(c => c.DataDaPrimeiraRevisao == null).Take(quantidadeDeFrasesNovas).ToList();

                textos.AddRange(textosNovos);
            }

            _textosParaRevisar = textos;
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            try
            {
                PreencherObjeto();

                _textoAtual.DataDaUltimaRevisao = DateTime.Now;

                _textoAtual.DataDaProximaRevisao = DateTime.Now.AddMinutes(5);

                _textosParaRevisar.Remove(_textoAtual);

                _textosParaRevisar.Add(_textoAtual);

                AdicioanarHistorico(ResultadoDaRevisao.Dificil);

                CarregarProximoTexto();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void btnNormal_Click(object sender, EventArgs e)
        {
            try
            {
                PreencherObjeto();

                _textoAtual.DataDaUltimaRevisao = DateTime.Now;

                _textoAtual.DataDaProximaRevisao = DateTime.Now.AddDays(1);

                _textosParaRevisar.Remove(_textoAtual);

                AdicioanarHistorico(ResultadoDaRevisao.Normal);

                CarregarProximoTexto();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            try
            {
                PreencherObjeto();

                var diasParaProximaRevisao = ObterDiasParaProximaRevisao();

                _textoAtual.DataDaUltimaRevisao = DateTime.Now;

                _textoAtual.DataDaProximaRevisao = DateTime.Now.AddDays(diasParaProximaRevisao);

                _textosParaRevisar.Remove(_textoAtual);

                AdicioanarHistorico(ResultadoDaRevisao.Facil);

                CarregarProximoTexto();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObterDiasParaProximaRevisao()
        {
            if (_textoAtual.DataDaProximaRevisao.Value.Date < DateTime.Now.Date)
                return 4;

            return (_textoAtual.DataDaProximaRevisao.Value.Date - _textoAtual.DataDaUltimaRevisao.Value.Date).Days + 4;
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

        private void PreencherControles()
        {
            textTitulo.Text = _textoAtual.Titulo;
            comboIdioma.SelectedItem = _textoAtual.Idioma;
            textTags.Text = _textoAtual.Tags;
            textTexto.Text = _textoAtual.TextoOutroIdioma;
            textTextoPortugues.Text = _textoAtual.TextoPortugues;
        }

        private void PreencherObjeto()
        {
            VerificaPreenchimentoDosCampos();

            _textoAtual.Titulo = textTitulo.Text;
            _textoAtual.Idioma = (Idioma)comboIdioma.SelectedItem;
            _textoAtual.Tags = textTags.Text;
            _textoAtual.TextoOutroIdioma = textTexto.Text;
            _textoAtual.TextoPortugues = textTextoPortugues.Text;
        }

        private void AdicioanarHistorico(ResultadoDaRevisao resultado)
        {
            var historico = new RevisaoDoTexto
            {
                IdDoTexto = _textoAtual.ID,
                DataDaRevisao = _textoAtual.DataDaUltimaRevisao,
                DataDaProximaRevisao = _textoAtual.DataDaProximaRevisao,
                ResultadoDaRevisao = resultado
            };

            _historicoDosTextos.Add(historico);
        }
    }
}
