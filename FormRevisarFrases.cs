using RevisadorDeFrase.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RevisadorDeFrase
{
    public partial class FormRevisarFrases : Form
    {
        private RevisadorFraseContext _repositorio;

        private List<Frase> _frasesParaRevisar { get; set; }

        private Frase _fraseAtual { get; set; }
        public FormRevisarFrases()
        {
            _repositorio = new RevisadorFraseContext();

            InitializeComponent();

            CarregarFrasesParaRevisar();
        }

        private void CarregarFrasesParaRevisar()
        {
            _frasesParaRevisar = _repositorio.Frases.OrderBy(c => c.Compreensao).ThenBy(c => c.DataDaUltimaRevisao).Take(100).ToList();

            _frasesParaRevisar.ForEach(c => { c.Compreensao = 0; c.DataDaUltimaRevisao = DateTime.Now; });

            MostarProximaFrase();
        }

        private void MostarProximaFrase()
        {
            if (!_frasesParaRevisar.Any())
                RevisaoConcluida();

            var proximaPosicao = new Random().Next() % _frasesParaRevisar.Count();

            _fraseAtual = _frasesParaRevisar[proximaPosicao];

            textFrase.Text = _fraseAtual.FraseOutraLingua;
        }

        private void RevisaoConcluida()
        {
            _repositorio.SaveChanges();

            var confirmation = MessageBox.Show("Revisao concluida com sucesso! Deseja revisar mais frases?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (confirmation != DialogResult.Yes)
                Close();

            CarregarFrasesParaRevisar();
        }

        private void btnAcertou_Click(object sender, EventArgs e)
        {
            if (_fraseAtual.Compreensao == 0)
                _fraseAtual.Compreensao = 10;

            _frasesParaRevisar.Remove(_fraseAtual);

            MostarProximaFrase();
        }

        private void btnErrou_Click(object sender, EventArgs e)
        {

            if (_fraseAtual.Compreensao == 0)
                _fraseAtual.Compreensao = -1;

            MostarProximaFrase();
        }

        private void btnMaisOuMenos_Click(object sender, EventArgs e)
        {
            if (_fraseAtual.Compreensao == 0)
                _fraseAtual.Compreensao = 5;

            MostarProximaFrase();
        }

        private void btnResposta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            textFrasePortugues.Text = _fraseAtual.FraseEmPortugues;
        }

        private void btnResposta_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            textFrasePortugues.Text = string.Empty;
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
