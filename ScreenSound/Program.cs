/*Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

albumDoQueen.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia();
*/

Episodio ep1 = new(1, "Técnica de facilitação", 45);
ep1.AdicionarConvidado("Gustavo Guanabara");
ep1.AdicionarConvidado("Ana Clara");

Episodio ep2 = new(1, "Técnica de aprendizado", 67);
ep2.AdicionarConvidado("Fernando");
ep2.AdicionarConvidado("Lucas");

Podcast podcast = new("Podcast Especial", "Lucas");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();