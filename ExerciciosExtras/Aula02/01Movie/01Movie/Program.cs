// Modelar e desserializar a classe Filme, que pode ser encontrada no link abaixo:
// https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json

using _01Movie.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta);

        filmes[5].ExibirInformacoes();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
