// Crie uma classe e faça a deserialização deste recurso nela, e exibe a classe no console.
// Sinta-se livre para escolher quais dados você deseja utilizar na classe.
// https://anapioficeandfire.com/

using _05GOTAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

    Personagem margaery = JsonSerializer.Deserialize<Personagem>(json)!;
    margaery.ExibirApelidosDaPersonagem();
}

