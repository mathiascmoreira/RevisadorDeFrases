using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RevisadorDeFrase.Modelos;

namespace RevisadorDeFrase
{
    public partial class FormListaDeTextos : Form
    {
        private RevisadorFraseContext _repositorio;
        public FormListaDeTextos()
        {
            InitializeComponent();

            _repositorio = new RevisadorFraseContext();

            PrepararTela();

            CarregarTextos();
        }

        private void PrepararTela()
        {
            comboIdioma.Items.Add(Idioma.Nenhum);
            comboIdioma.Items.Add(Idioma.Ingles);
            comboIdioma.Items.Add(Idioma.Frances);
            comboIdioma.Items.Add(Idioma.Alemao);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var adicionarTextoForm = new FormAdicionarTexto();

            adicionarTextoForm.Show();
        }

        private void CarregarTextos()
        {
            try
            {
                _repositorio = new RevisadorFraseContext();

                Cursor = Cursors.WaitCursor;

                if (comboIdioma.SelectedItem == null)
                    comboIdioma.SelectedItem = Idioma.Nenhum;

                var resultado = _repositorio.Textos.Where(c =>
                    (string.IsNullOrEmpty(textTitulo.Text) || c.Titulo.Contains(textTitulo.Text)) &&
                    (string.IsNullOrEmpty(textTags.Text) || c.Tags.Contains(textTags.Text)) &&
                    ((Idioma)comboIdioma.SelectedItem == Idioma.Nenhum ||
                     c.Idioma == (Idioma)comboIdioma.SelectedItem)).ToList();

                gridTextos.DataSource = new BindingList<Texto>(resultado);
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarTextos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja remover os textos selecionados do banco de dados", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor = Cursors.Default;

                    foreach (var linhaSelecionada in gridTextos.SelectedRows)
                    {
                        var texto = (Texto)((DataGridViewRow)linhaSelecionada).DataBoundItem;

                        if (texto == null)
                            continue;

                        ((BindingList<Texto>)gridTextos.DataSource).Remove(texto);

                        _repositorio.Textos.Remove(texto);
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
            var textoSelecionado = (Texto)gridTextos.CurrentRow?.DataBoundItem;

            if (textoSelecionado == null)
                return;

            var editarTextoForm = new FormEditarTexto(textoSelecionado.ID);

            editarTextoForm.Show();
        }
    }
}
