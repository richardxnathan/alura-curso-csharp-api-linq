using System.Text.Json.Serialization;

namespace _02Country.Modelos;

internal class Pais
{

    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("capital")]
    public string Capital { get; set; }
    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"A capital do {Nome} é a cidade de {Capital} e o idioma falado é o {Idioma}.");
    }

}
