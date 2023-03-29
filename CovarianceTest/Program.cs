FiyatKarsilastirici gitarK = new FiyatKarsilastirici();
List<Gitar> gitarlar = new List<Gitar>();
gitarlar.Add(new Gitar(2000));
gitarlar.Add(new ElektroGitar(8000));
Gitar elektroGitar = new ElektroGitar(500); 
gitarlar.Sort(gitarK);

List<ElektroGitar> elektroGitarlar = new List<ElektroGitar>();
elektroGitarlar.Add(new ElektroGitar(1500));
elektroGitarlar.Add(new ElektroGitar(750));
elektroGitarlar.Sort(gitarK); 


public class Gitar
{
    public virtual void Cal()
    {
        Console.WriteLine("Gitar çalıyor.");
    }
    public double Fiyat { get; set; }
    public Gitar(double fiyat)
    {
        Fiyat = fiyat;
    }
}

public class ElektroGitar: Gitar
{
    public ElektroGitar(double fiyat) : base(fiyat)
    {
    }

    public override void Cal()
    {
        Console.WriteLine("Elektro gitar çalınıyor");
    }
}

public class FiyatKarsilastirici: IComparer<Gitar>
{
    public int Compare (Gitar x, Gitar y)
    {
        if (x.Fiyat > y.Fiyat)
        {
            Console.WriteLine($"{x.Fiyat} fiyatı daha yüksek");
            return 1;
        }
        else if (x.Fiyat < y.Fiyat)
        {
            Console.WriteLine($"{y.Fiyat} fiyatı daha yüksek");
            return -1;
        }
        else
        {
            Console.WriteLine($"{x} ve {y} nin fiyatları aynı");
            return 0;
        }
    }
}