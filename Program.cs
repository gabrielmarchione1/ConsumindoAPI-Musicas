using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        musicas[2].ExibirDetalhesMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");

        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Travis Scott");

        //var musicasPreferidas = new MusicasPreferidas("PlaylistDoMarch");

        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();

        //LinqFilter.FiltrarMusicasPorTonalidadeCSharp(musicas);
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Temos um problema: {ex}");
    }   
}