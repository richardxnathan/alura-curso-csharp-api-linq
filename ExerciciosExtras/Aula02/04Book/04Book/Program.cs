// Modelar e desserializar a classe Carro, que pode ser encontrada no link abaixo
// https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json

using _04Book.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta);

        livros[3].ExibirInformacoes();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}    
