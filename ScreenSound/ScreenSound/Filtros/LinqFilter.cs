using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{

    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var generos = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistas = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(artistas => artistas.Artista).Distinct().ToList();

        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var listaMusicas = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();

        Console.WriteLine(artista);
        foreach (var musica in listaMusicas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var listaMusicas = musicas.Where(musica => musica.Ano.Contains(ano)).ToList();

        Console.WriteLine($"Músicas do ano de {ano}:");
        foreach (var musica in listaMusicas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

}
