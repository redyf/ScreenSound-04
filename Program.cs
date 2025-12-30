using System.Text.Json;
using ScreenSound_04.Filters;
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
                // musicas.ForEach(music => music.ExibirDetalhesDaMusica());

                // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
                // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
                // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
                // LinqFilter.FiltrarMusicasDeArtista(musicas, "iann dior");
                LinqFilter.FiltrarMusicasPorAno(musicas, 2012);
                var musicasPreferidasDeMateus = new MusicasPreferidas("Mateus");
                musicasPreferidasDeMateus.AdicionarMusicasFavoritas(musicas[1]);
                musicasPreferidasDeMateus.AdicionarMusicasFavoritas(musicas[10]);
                musicasPreferidasDeMateus.AdicionarMusicasFavoritas(musicas[14]);

                musicasPreferidasDeMateus.ExibirMusicasFavoritas();
                musicasPreferidasDeMateus.GerarArquivoJson();
                // List<int> numerosComDuplicatas = new List<int> { 1, 1, 1, 2, 3, 4, 5, 5, 5, 6, 6, 7, 8 };
                // LinqFilter.NumerosUnicosNaLista(numerosComDuplicatas);
                //
                // List<Livro> meusLivros = new List<Livro>{
                //   new Livro { Titulo = "Aprendendo LINQ", AnoDePublicacao = 2001, Autor = "Mateus"},
                //   new Livro { Titulo = "Jogando CS2", AnoDePublicacao = 1999, Autor = "Valve"},
                //   new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoDePublicacao = 1998 },
                //   new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoDePublicacao = 2021 },
                //   new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoDePublicacao = 2002 },
                // };
                //
                // LinqFilter.ListaDeLivrosPublicadosApósXAno(meusLivros, 2020);
                //
                // List<Produto> meusProdutos = new List<Produto>{
                //   new Produto{Nome = "Skin dragonlore", Preco = 14900.99m},
                //   new Produto{Nome = "Garrafa térmica", Preco = 49.99m},
                //   new Produto{Nome = "Beyblade", Preco = 50m},
                // };
                //
                // LinqFilter.PrecoMedioDoProduto(meusProdutos);
                //
                // List<int> listaDeNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                //
                // LinqFilter.RetornaNumerosPares(listaDeNumeros);

                // string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                // var filmes = JsonSerializer.Deserialize<List<Filme>>(response)!;
                // filmes.ForEach(filme => filme.ExibirDetalhes());
                //
                // string respostaPais = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
                // var paises = JsonSerializer.Deserialize<List<Pais>>(respostaPais)!;
                // paises.ForEach(pais => pais.ExibirDetalhes());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Fetching failed: {e.Message}");
            }
        }
    }
}
