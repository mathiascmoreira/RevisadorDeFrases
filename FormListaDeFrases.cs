using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RevisadorDeFrase.Modelos;

namespace RevisadorDeFrase
{
    public partial class FormListaDeFrases : Form
    {
        private RevisadorFraseContext _repositorio;

        public FormListaDeFrases()
        {
            InitializeComponent();

            _repositorio = new RevisadorFraseContext();

            comboIdioma.Items.Add(Idioma.Nenhum);
            comboIdioma.Items.Add(Idioma.Portugues);
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);

            CarregarFrases();
        }

        private void CarregarFrases()
        {
            try
            {
                _repositorio = new RevisadorFraseContext();

                Cursor = Cursors.WaitCursor;

                if (comboIdioma.SelectedItem == null)
                    comboIdioma.SelectedItem = Idioma.Nenhum;

                var resultado = _repositorio.Frases.Where(c =>
                    (string.IsNullOrEmpty(textFrase.Text) || c.FraseOutraLingua.Contains(textFrase.Text)) &&
                    (string.IsNullOrEmpty(textFrasePortugues.Text) || c.FraseEmPortugues.Contains(textFrasePortugues.Text)) &&
                    ((Idioma)comboIdioma.SelectedItem == Idioma.Nenhum ||
                     c.Idioma == (Idioma)comboIdioma.SelectedItem)).ToList();

                gridTextos.DataSource = new BindingList<Frase>(resultado);
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var adicionarFraseForm = new FormAdicionarFrase();

            adicionarFraseForm.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarFrases();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja remover as frases selecionadas do banco de dados", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.Default;

                    foreach (var linhaSelecionada in gridTextos.SelectedRows)
                    {
                        var frase = (Frase)((DataGridViewRow)linhaSelecionada).DataBoundItem;

                        if (frase == null)
                            continue;

                        ((BindingList<Frase>)gridTextos.DataSource).Remove(frase);

                        _repositorio.Frases.Remove(frase);
                    }

                    _repositorio.SaveChanges();

                    MessageBox.Show("Alterações salvas com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var linhaSelecionada = (Frase)gridTextos.CurrentRow?.DataBoundItem;

            if (linhaSelecionada == null)
                return;

            var editarTextoForm = new FormEditarFrase(linhaSelecionada);

            editarTextoForm.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEstudarFrases_Click(object sender, EventArgs e)
        {
            var formEstudarFrases = new FormRevisarFrases();

            formEstudarFrases.Show();
        }
    }
}
