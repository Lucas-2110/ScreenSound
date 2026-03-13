Musica musica1 = new Musica();
musica1.nome = "Essência da paixão";
musica1.artista = "Grupo Revelação";
musica1.duracao = 286;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Console.WriteLine($"O nome da música escolhida é: {musica1.nome}");
Console.WriteLine($"O artista escolhida é: {musica1.artista}");

Musica musica2 = new Musica();
musica2.nome = "Jesus Chorou";
musica2.artista = "Racionais";
musica2.duracao = 568;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();