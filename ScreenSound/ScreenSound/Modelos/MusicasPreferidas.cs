using System.Text.Json;

namespace ScreenSound.Modelos;

internal class MusicasPreferidas
{

    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicas = [];
    }

    public void AdicionarMusica(Musica musica)
    {
        ListaDeMusicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"\nPlaylist do {Nome}");

        foreach (var musica in ListaDeMusicas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public void GerarArquivoJson()
    {
        var json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

}
