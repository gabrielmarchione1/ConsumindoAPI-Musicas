using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in todosGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero))
                .Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine($"Exibindo os artistas por genêro musical: {genero}\n");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
        {
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
            Console.WriteLine(nomeArtista);
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        public static void FiltrarMusicasPorTonalidadeCSharp(List<Musica> musicas)
        {
            var musicasCSharp = musicas.Where(musica => musica.Key!.Equals(1)).ToList();
            Console.WriteLine("Músicas C#:\n");
            foreach (var musica in musicasCSharp)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
    }
}
