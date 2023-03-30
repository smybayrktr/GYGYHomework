



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
