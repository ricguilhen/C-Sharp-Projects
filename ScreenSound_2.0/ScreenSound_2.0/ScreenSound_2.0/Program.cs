Banda radiohead = new Banda("Radiohead");

Album albumDoRadiohead = new Album("The Bends");

Musica musica1 = new Musica(radiohead, "High and Dry")
{
    Duracao = 267,
    Disponivel = true,
};

Musica musica2 = new Musica(radiohead, "Just")
{
    Duracao = 246,
    Disponivel = false,
};

albumDoRadiohead.AdicionarMusica(musica1);
albumDoRadiohead.AdicionarMusica(musica2);
radiohead.AdicionarAlbum(albumDoRadiohead);

radiohead.ExibirDiscografia();
Console.WriteLine();

albumDoRadiohead.ExibirMusicasDoAlbum();
Console.WriteLine();

musica1.ExibirFichaTecnica();
Console.WriteLine();

musica2.ExibirFichaTecnica();