﻿Album albumDoQueen =  new Album();
albumDoQueen.Nome = "A night at the opera"; 

Musica musica1 = new Musica();
musica1.Nome = "Love of My Life";
musica1.Duracao = 233;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum(); 
