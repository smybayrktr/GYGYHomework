



public class CarValidation : Validation
{
    public CarValidation(int personCount, DateTime startDate, DateTime finishTime) : base(personCount, startDate, finishTime)
    {
    }

    public override bool ValidateOfPersonCount()
    {
        if (PersonCount <= 0 || PersonCount > 5)
        {
            Console.WriteLine("Kişi sayısı 0'dan büyük 5'ten küçük olmalı");
            return false;
        }
        return true;
    }
}
