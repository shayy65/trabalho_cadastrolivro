
using System;
using System.IO;
using System.Linq.Expressions;

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
                salvar.WriteLine($"Código: {livro.codigo}");
                salvar.WriteLine($"Título: {livro.titulo}");
                salvar.WriteLine($"Sinopse: {livro.sinopse}");
                salvar.WriteLine($"Gênero: {livro.genero}");
                salvar.WriteLine($"Autor(a): {livro.autor}");
                salvar.WriteLine($"Ano lançamento: {livro.ano}");
                salvar.WriteLine($"Editora: {livro.editora}");
                salvar.WriteLine($"Preço aquisição: {livro.precoaquisicao}");
                salvar.WriteLine($"Lucro: {livro.lucro}");
                salvar.WriteLine("Valor a ser vendido: {livro.valorvenda}");
            }
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}

