namespace CurrentTime;

public class CurrentTime
{
    public static string GetFullTime()
    {
        return DateTime.Now.ToString("ddd dd/MM/yyyy HH:mm:ss");
    }

    public static string GetHour()
    {
        return DateTime.Now.ToString("HH\\h");
    }

    public static string GetDate()
    {
        return DateTime.Now.ToString("dd/MM/yyyy");
    }

    public static string GetWritenDate()
    {
        return DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");
    }
}
