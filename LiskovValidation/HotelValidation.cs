



public class HotelValidation : Validation
{
    public HotelValidation(int personCount, DateTime startDate, DateTime finishTime) : base(personCount, startDate, finishTime)
    {
    }

    public override bool ValidateOfPersonCount()
    {
        if (PersonCount <= 0 || PersonCount > 10)
        {
            Console.WriteLine("Kişi sayısı 0'dan büyük 10'dan küçük olmalı");
            return false;
        }
        return true;
    }
}
