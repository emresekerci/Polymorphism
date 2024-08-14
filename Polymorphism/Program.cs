using Polymorphism;

// Kare örneği
BaseGeometrikSekil kare = new Kare();
kare.Genislik = 5;
kare.Yukseklik = 5;
Console.WriteLine("Kare alanı: " + kare.AlanHesapla(kare.Genislik, kare.Yukseklik));

// Dikdörtgen örneği
BaseGeometrikSekil dikdortgen = new Dikdortgen();
dikdortgen.Genislik = 5;
dikdortgen.Yukseklik = 10;
Console.WriteLine("Dikdörtgen alanı: " + dikdortgen.AlanHesapla(dikdortgen.Genislik, dikdortgen.Yukseklik));

// Dik üçgen örneği
BaseGeometrikSekil dikucgen = new DikUcgen();
dikucgen.Genislik = 5;
dikucgen.Yukseklik = 10;
Console.WriteLine("Dik üçgen alanı: " + dikucgen.AlanHesapla(dikucgen.Genislik, dikucgen.Yukseklik));