using IMDBPratik;

List<Film> filmListesi = new List<Film>();

while (true)
{
    // Film bilgilerini kullanıcıdan alma
    Console.Write("Film adını giriniz: ");
    string isim = Console.ReadLine();

    Console.Write("Imdb puanını giriniz: ");
    double imdbPuani;
    while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
    {
        Console.WriteLine("Geçersiz puan! Lütfen 0-10 arasında bir değer girin:");
    }

    // Yeni bir film nesnesi oluştur ve listeye ekleme
    Film yeniFilm = new Film { Isim = isim, ImdbPuani = imdbPuani };
    filmListesi.Add(yeniFilm);

    // Kullanıcıya başka bir film eklemek isteyip istemediğini sorma
    Console.Write("Başka bir film eklemek istiyor musunuz? (E/H): ");
    string cevap = Console.ReadLine().ToUpper();
    if (cevap != "E")
        break;
}

// Bütün filmleri listeleme
Console.WriteLine("\nTüm Filmler:");
foreach (var film in filmListesi)
{
    Console.WriteLine($"Film Adı: {film.Isim}, Imdb Puanı: {film.ImdbPuani}");
}

// Imdb puanı 4 ile 9 arasında olan filmleri listeleme
Console.WriteLine("\nImdb puanı 4 ile 9 arasında olan Filmler:");
var ortaPuanliFilmler = filmListesi.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
foreach (var film in ortaPuanliFilmler)
{
    Console.WriteLine($"Film Adı: {film.Isim}, Imdb Puanı: {film.ImdbPuani}");
}

// İsmi 'A' ile başlayan filmleri listeleme
Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
var aIleBaslayanFilmler = filmListesi.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));
foreach (var film in aIleBaslayanFilmler)
{
    Console.WriteLine($"Film Adı: {film.Isim}, Imdb Puanı: {film.ImdbPuani}");
}