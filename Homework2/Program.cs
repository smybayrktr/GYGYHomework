/*
 * Şifre 6 karakterden kısaysa Uzunluk kısa uyarısı
 * Şifre alfanümerik, sayı ve harften oluşuyosa güçlü
 * Şifre Alfanümerik ve sayı, sayı ve harf, harf alfanümerik kombinasyonlarından oluşuyosa orta
 * Alfanümerik, sayı veya harften herhangi birinden oluşuyorsa zayıfır.
 */

Console.WriteLine("Lütfen şifre giriniz.");
string password = Console.ReadLine();

var lenghtPassword = password.Length < 6 ? "Şifrenizin uzunluğu yetersiz." : "Şifre uzunluğu yeterli.";

var hasNumber = password.Any(x => char.IsNumber(x));
var hasLetter = password.Any(x => char.IsLetter(x));
var hasAlphanumeric = password.Any(x => char.IsPunctuation(x));

if (hasNumber && hasLetter && hasAlphanumeric)
{
    Console.WriteLine("Şifreniz Güçlü");
    
}

else if (hasNumber && hasLetter || hasNumber && hasAlphanumeric || hasAlphanumeric && hasLetter)
{
    Console.WriteLine("Şifreniz Orta");
}

else
{
    Console.WriteLine("Şifreniz Zayıf");
}
Console.ReadLine();