using System.Text.Json.Serialization;

namespace _04Book.Modelos;

internal class Livro
{

    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string Autor { get; set; }
    [JsonPropertyName("paginas")]
    public int QuantidadePaginas { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"O livro '{Titulo}' escrito por {Autor} tem {QuantidadePaginas} páginas.");
    }

}
