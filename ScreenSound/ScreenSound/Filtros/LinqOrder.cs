using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqOrder
{

    public static void FiltrarEOrdenarArtistas(List<Musica> musicas)
    {
        var artistas = musicas.Select(artistas => artistas.Artista).Distinct().ToList().Order();

        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

}
