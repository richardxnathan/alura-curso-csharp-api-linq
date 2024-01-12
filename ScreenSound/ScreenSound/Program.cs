﻿using ScreenSound.Filtros;
using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
