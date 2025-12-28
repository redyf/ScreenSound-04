using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

public class Filme
{
    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("rank")]
    public string PosicaoNoRank { get; set; }

    [JsonPropertyName("year")]
    public string AnoDeLancamento { get; set; }

    [JsonPropertyName("imDbRating")]
    public string Avaliacao { get; set; }

    [JsonPropertyName("imDbRatingCount")]
    public string NumeroDeAvaliacoes { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Posicação no rank: {PosicaoNoRank}");
        Console.WriteLine($"Ano de lançamento: {AnoDeLancamento}");
        Console.WriteLine($"Avaliação média: {Avaliacao}");
        Console.WriteLine($"Número de avaliações: {NumeroDeAvaliacoes}");
    }
}
