Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Bohemian Rhapsody";
musica1.Duracao = 354;

Musica musica2 = new Musica();
musica2.Nome = "Love of my life";
musica2.Duracao = 213;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();