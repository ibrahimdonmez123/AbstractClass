using System;

abstract class Sekil
{
    public abstract double AlaniHesapla();
}

class Cember : Sekil
{
    public double Cap { get; set; }

    public Cember(double cap)
    {
        Cap = cap;
    }

    public override double AlaniHesapla()
    {
        return Math.PI * Math.Pow(Cap, 2);
    }
}

class Dikdortgen : Sekil
{
    public double Genislik { get; set; }
    public double Uzunluk { get; set; }

    public Dikdortgen(double genislik, double uzunluk)
    {
        Genislik = genislik;
        Uzunluk = uzunluk;
    }

    public override double AlaniHesapla()
    {
        return Genislik * Uzunluk;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Abstract sınıfın kullanımı
        Sekil cember = new Cember(5);
        Sekil dikdortgen = new Dikdortgen(4, 6);

        Console.WriteLine("Çemberin  Alanı: " + cember.AlaniHesapla());
        Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlaniHesapla());

        Console.ReadLine();
    }
}
