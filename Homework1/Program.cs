int[] numbers = {2,3,4,10,14,9,4,-4 };
int minValue = numbers[0];
int maxValue = numbers[0];
double average = 0;
int totalValue = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]<minValue)
    {
        minValue = numbers[i];
    }
    if (numbers[i]>maxValue)
    {
        maxValue = numbers[i];
    }
    totalValue += numbers[i];
    average = totalValue / numbers.Length;
}
Console.WriteLine("Dizideki en büyük değer: "+maxValue);
Console.WriteLine("Dizideki en küçük değer: " + minValue);
Console.WriteLine("Dizinin toplamı: " + totalValue);
Console.WriteLine("Dizinin ortalaması: " + average);
Console.ReadLine();