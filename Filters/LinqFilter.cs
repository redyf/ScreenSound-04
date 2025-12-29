using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;

public class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica =>
            musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical {genero}");
        artistasPorGeneroMusical.ForEach(artista => Console.WriteLine($"- {artista}"));
    }

    public static void FiltrarMusicasDeArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(artista)).ToList();
        Console.WriteLine($"Exibindo as músicas do artista {artista}");
        musicasDoArtista.ForEach(musica => Console.WriteLine($"- {musica.Nome}"));
    }

    public static void NumerosUnicosNaLista(List<int> numeros)
    {
        var numerosUnicos = numeros.Distinct().ToList();
        Console.WriteLine($"Os números únicos na lista são: ");
        numerosUnicos.ForEach(numero => Console.WriteLine(numero));
    }

    public static void ListaDeLivrosPublicadosApósXAno(List<Livro> livros, int ano)
    {
        var anoDePublicacao = ano;
        var livrosPublicadosAposXAno = livros.Where(livro => livro.AnoDePublicacao > anoDePublicacao).OrderBy(livro => livro.Titulo).Select(livro => livro.Titulo).ToList();

        Console.WriteLine("Esta é a lista de livros publicados após o ano 2000, em ordem alfabética");
        livrosPublicadosAposXAno.ForEach(livro => Console.WriteLine(livro));
    }

    public static void PrecoMedioDoProduto(List<Produto> produtos)
    {
        var calculaPrecoMedio = produtos.Average(p => p.Preco);
        Console.WriteLine($"O preço médio do produto é: {calculaPrecoMedio} ");
    }

    public static void RetornaNumerosPares(List<int> numeros)
    {
        var filtraNumerosPares = numeros.Where(num => num % 2 == 0).ToList();
        filtraNumerosPares.ForEach(num => Console.WriteLine($"O número {num} é par"));
    }
}
