using System.Text.Json;
using ScreenSound_04.Models;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
                musicas.ForEach(music => music.ExibirDetalhesDaMusica());

                string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<Filme>>(response)!;
                filmes.ForEach(filme => filme.ExibirDetalhes());

                string respostaPais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
                var paises = JsonSerializer.Deserialize<List<Pais>>(respostaPais)!;
                paises.ForEach(pais => pais.ExibirDetalhes());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fetching failed: {e.Message}");
            }
        }
    }
}
