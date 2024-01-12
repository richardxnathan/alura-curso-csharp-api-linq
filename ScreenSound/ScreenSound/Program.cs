using ScreenSound.Filtros;
using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

        musicasPreferidasEmilly.AdicionarMusica(musicas[500]);
        musicasPreferidasEmilly.AdicionarMusica(musicas[637]);
        musicasPreferidasEmilly.AdicionarMusica(musicas[428]);
        musicasPreferidasEmilly.AdicionarMusica(musicas[13]);
        musicasPreferidasEmilly.AdicionarMusica(musicas[71]);

        musicasPreferidasEmilly.ExibirMusicas();

        musicasPreferidasEmilly.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
