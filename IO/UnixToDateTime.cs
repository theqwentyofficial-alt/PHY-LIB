namespace PHY_LIB.IO
{
    public class UnixToDateTime
    {
        public static DateTime UnixSecondsToDateTime(long seconds)
        {
            DateTimeOffset offset = DateTimeOffset.FromUnixTimeSeconds(seconds);
            DateTime date = offset.UtcDateTime;
            return date;
        }
        public static DateTime UnixMillisecondsToDateTime(long seconds)
        {
            DateTimeOffset offset = DateTimeOffset.FromUnixTimeMilliseconds(seconds);
            DateTime date = offset.UtcDateTime;
            return date;
        }

    }
}
