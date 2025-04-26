using System.Text.Json;

namespace ScreenSound_04.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasPreferidas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasPreferidas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasPreferidas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas -> {Nome}\n");
            foreach (var musica in ListaDeMusicasPreferidas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicasPreferidas
            });

            string nomeArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"O arquivo Json foi criado com sucesso no caminho: {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
