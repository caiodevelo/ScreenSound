class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do Album {Nome}: \n");
        foreach (var musica in musicas)
        {
           
        Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este áçbum inteiro você precisa de {DuracaoTotal} segundos \n");
    }
}