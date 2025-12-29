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
}
