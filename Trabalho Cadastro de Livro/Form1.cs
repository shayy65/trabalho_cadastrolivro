using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Cadastro_de_Livro

{
    public partial class Form1 : Form
    {
        List<Livro> livros = new List<Livro>();
        public Form1()
        {
            InitializeComponent();
            Livro v = new Livro();
            v.LerArquivo();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            try
            {
                livro.codigo = txt_codigo.Text;
                livro.titulo = txt_titulo.Text;
                livro.sinopse = txt_sinopse.Text;
                livro.genero = cb_genero.Text;
                livro.autor = txt_autor.Text;
                livro.ano = txt_ano.Text;
                livro.editora= txt_editora.Text;
                livro.precoaquisicao = Convert.ToDouble(txt_valoraquisicao.Text);
                livro.lucro = Convert.ToDouble(txt_lucro.Text);

                double calculo = (livro.lucro / 100) * livro.precoaquisicao;
                livro.valorvenda = calculo + livro.precoaquisicao;

                txt_valorvenda.Text = Convert.ToString(livro.valorvenda);
                livros.Add(livro);

                dataGrid_livro.DataSource = null;
                dataGrid_livro.Refresh();
                dataGrid_livro.DataSource = livros;

                

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido!" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado!" + ex.Message);
            }


            if (livro.Salvar(livro))
            {
                MessageBox.Show($"Livro salvo com sucesso.");
                //MessageBox.Show(livro.LerArquivo());

            }
            else
            {
                MessageBox.Show("Erro ao salvar livro.");
            }

        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_titulo.Clear();
            txt_sinopse.Clear();
            cb_genero.ResetText();
            txt_autor.Clear();
            txt_ano.Clear();
            txt_editora.Clear();
            txt_valoraquisicao.Clear();
            txt_lucro.Clear();
            txt_valorvenda.Clear();
        }

        private void bt_exluir_Click(object sender, EventArgs e)
        {
            int index = dataGrid_livro.CurrentCell.RowIndex;
            livros.RemoveAt(index);

            dataGrid_livro.DataSource = null;
            dataGrid_livro.Refresh();
            dataGrid_livro.DataSource = livros;
        }

    }
}
