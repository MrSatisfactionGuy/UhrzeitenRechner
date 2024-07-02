namespace UhrzeitenRechner
{
    public class ClockCalc
    {
        public DateTime DateTimeCalc(string time, double worktime, double breaktime)
        {
            TimeSpan workTime = TimeSpan.FromHours(worktime);
            TimeSpan breakTime = TimeSpan.FromHours(breaktime);

            return new DateTime(workTime.Ticks);
        }
    }
}
