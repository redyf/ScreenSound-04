using System.Text.Json;
using ScreenSound_04;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas.ForEach(music => music.ExibirDetalhesDaMusica());
    }
    catch (Exception e)
    {
        Console.WriteLine($"Fetching failed: {e.Message}");
    }
}
