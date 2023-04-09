CarValidation carValidation = new CarValidation(1, DateTime.Now, DateTime.Now.AddHours(-5));
carValidation.Validator(carValidation.ValidateOfTime(), carValidation.ValidateOfPersonCount());


HotelValidation hotelValidation = new HotelValidation(10, DateTime.Now, DateTime.Now.AddDays(10));
hotelValidation.Validator(hotelValidation.ValidateOfTime(), hotelValidation.ValidateOfPersonCount());


ConferenceValidation conferenceValidation = new ConferenceValidation(40, DateTime.Now, DateTime.Now.AddMonths(5));
conferenceValidation.Validator(conferenceValidation.ValidateOfTime(), conferenceValidation.ValidateOfPersonCount());
