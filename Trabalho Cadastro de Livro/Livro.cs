
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

public class Livro
{
    public string codigo { get; set; }
    public string titulo { get; set; }
    public string sinopse { get; set;}
    public string genero { get; set;}
    public string autor { get; set; }
    public string ano { get; set;}
    public string editora { get; set;}
    public double precoaquisicao { get; set; }
    public double lucro { get; set; }
    public double valorvenda { get; set; }


    public Livro()
    {

    }

    public bool Salvar(Livro livro)
    {
        try
        {
            using (var salvar = new StreamWriter("C:\\Cadastro Livro\\Livro.doc"))
            {
                salvar.WriteLine($"Código: {livro.codigo} Título: {livro.titulo} Sinopse: {livro.sinopse} Gênero: {livro.genero} Autor(a): {livro.autor} Ano lançamento: {livro.ano} Editora: {livro.editora} Preço aquisição: {livro.precoaquisicao} Lucro: {livro.lucro} Valor a ser vendido: {livro.valorvenda}");
            }

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public List<Livro> LerArquivo()
    {
        List<Livro> livros = new List<Livro>(); 
        string[] linhas = File.ReadAllLines("C:\\Cadastro Livro\\Livro.doc");

        foreach(string s in linhas)
        {
            string []a = s.Split('-');
            Livro v = new Livro();
            v.codigo = a[0];
 
            

            livros.Add(v);
        }

        foreach(Livro livro in livros)
        {
            MessageBox.Show(livro.codigo + " " + livro.titulo);
        }

        //ler o arquivo
        return livros;
    }
}

