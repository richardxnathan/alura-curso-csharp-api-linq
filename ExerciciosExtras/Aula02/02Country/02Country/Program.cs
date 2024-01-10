// Modelar e desserializar a classe Pais, que pode ser encontrada no link abaixo
// https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json

using _02Country.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);

        paises[3].ExibirInformacoes();
    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}
