



public class ConferenceValidation : Validation
{
    public ConferenceValidation(int personCount, DateTime startDate, DateTime finishTime) : base(personCount, startDate, finishTime)
    {
    }

    public override bool ValidateOfPersonCount()
    {
        if (PersonCount <= 0 || PersonCount > 50)
        {
            Console.WriteLine("Kişi sayısı 0'dan büyük 50'den küçük olmalı");
            return false;
        }
        return true;
    }
}
