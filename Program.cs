Musica musica1 = new Musica();
musica1.Nome = "Essência da paixão";
musica1.Artista = "Grupo Revelação";
musica1.Duracao = 286;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Jesus Chorou";
musica2.Artista = "Racionais";
musica2.Duracao = 568;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();