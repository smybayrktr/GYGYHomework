CarValidation carValidation = new CarValidation(1, DateTime.Now, DateTime.Now.AddHours(-5));
carValidation.Validator(carValidation.ValidateOfTime(), carValidation.ValidateOfPersonCount());


HotelValidation hotelValidation = new HotelValidation(10, DateTime.Now, DateTime.Now.AddDays(10));
hotelValidation.Validator(hotelValidation.ValidateOfTime(), hotelValidation.ValidateOfPersonCount());


ConferenceValidation conferenceValidation = new ConferenceValidation(40, DateTime.Now, DateTime.Now.AddMonths(5));
conferenceValidation.Validator(conferenceValidation.ValidateOfTime(), conferenceValidation.ValidateOfPersonCount());



public abstract class Validation
{
    public int PersonCount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime FinishTime { get; set; }
    public delegate bool validateOfCount();
    public delegate bool validateOfTime();

    public Validation(int personCount, DateTime startDate, DateTime finishTime)
    {
        PersonCount = personCount;
        StartDate = startDate;
        FinishTime = finishTime;
    }

    public abstract bool ValidateOfPersonCount();
    public bool ValidateOfTime()
    {
        if (FinishTime < StartDate)
        {
            Console.WriteLine("Bitiş tarihi başlangıç tarihinden önce olamaz!");
            return false;
        }

        return true;
    }
    public bool Validator(bool validateOfTime,bool validateOfCount)
    {
        if (validateOfTime && validateOfCount)
        {
            Console.WriteLine("Rezervasyon başarıyla yapıldı");
            return true;
        }
        Console.WriteLine("Rezervasyonda hata oluştu");
        return false;
    }
}

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
