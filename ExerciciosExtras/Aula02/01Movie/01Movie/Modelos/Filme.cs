using System.Text.Json.Serialization;

namespace _01Movie.Modelos;

internal class Filme
{

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"{Nome} ({Ano})");
    }


}
