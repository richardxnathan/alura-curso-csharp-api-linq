// Modelar e desserializar a classe Carro, que pode ser encontrada no link abaixo
// https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json

using _03Car.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);

        carros[1].ExibirDetalhes();
    } 
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}
