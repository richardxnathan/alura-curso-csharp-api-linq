using System.Text.Json.Serialization;

namespace _03Car.Modelos;

internal class Carro
{

    [JsonPropertyName("marca")]
    public string Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }
    [JsonPropertyName("motor")]
    public string Motor { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O {Marca} {Modelo} é de {Ano} com motor de {Motor}.");
    }

}
