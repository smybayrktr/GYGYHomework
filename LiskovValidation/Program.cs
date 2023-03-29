CarValidation carValidationInstance = new CarValidation(-1, DateTime.Now, DateTime.Now.AddHours(2));
carValidationInstance.Validate();

HotelValidation hotelValidation = new HotelValidation(10, DateTime.Now, DateTime.Now.AddDays(10));
hotelValidation.Validate();

ConferenceValidation conferenceValidation = new ConferenceValidation(40, DateTime.Now, DateTime.Now.AddMonths(5));
conferenceValidation.Validate();



public abstract class Validation
{
    public int PersonCount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime FinishTime { get; set; }

    public Validation(int personCount, DateTime startDate, DateTime finishTime)
    {
        PersonCount = personCount;
        StartDate = startDate;
        FinishTime = finishTime;
    }

    public abstract void Validate();
}

public class CarValidation : Validation
{
    public CarValidation(int personCount, DateTime startDate, DateTime finishTime) : base(personCount, startDate, finishTime)
    {
    }

    public override void Validate()
    {
        if (PersonCount <= 0 || PersonCount > 5)
        {
            Console.WriteLine("Kişi sayısı 0'dan büyük 5'ten küçük olmalı");
        }
    }
}

public class HotelValidation : Validation
{
    public HotelValidation(int personCount, DateTime startDate, DateTime finishTime) : base(personCount, startDate, finishTime)
    {
    }

    public override void Validate()
    {
        if (PersonCount <= 0 || PersonCount > 10)
        {
            Console.WriteLine("Kişi sayısı 0'dan büyük 10'dan küçük olmalı");
        }
    }
}

public class ConferenceValidation : Validation
{
    public ConferenceValidation(int personCount, DateTime startDate, DateTime finishTime) : base(personCount, startDate, finishTime)
    {
    }

    public override void Validate()
    {
        if (PersonCount <= 0 || PersonCount > 50)
        {
            Console.WriteLine("Kişi sayısı 0'dan büyük 50'den küçük olmalı");
        }
    }
}
