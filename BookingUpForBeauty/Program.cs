using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var parseDate = DateTime.Parse(appointmentDateDescription);
        return parseDate;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;   
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int hour = appointmentDate.Hour;
        return hour >= 12 && hour < 18;
        
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        DateTime niver = new DateTime(2024,9,15);
        return niver;

    }
}
