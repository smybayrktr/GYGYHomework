class Ogretmen
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public Ogretmen(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
    }
}

class Sinif
{
    public string Ad { get; set; }
    public Ogretmen SorumluOgretmen { get; set; }
    public List<Student> Ogrenciler { get; set; }

    public Sinif(string ad, Ogretmen sorumluOgretmen)
    {
        Ad = ad;
        SorumluOgretmen = sorumluOgretmen;
        Ogrenciler = new List<Student>();
    }
}

class Student
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public Student(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
    }
}

