﻿ class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida
    {
        get
        {
            return $"A musica {Nome} pertence à banda {Artista}"; 
        }
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano. \n");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+ \n");
        }
    }
}

