namespace UhrzeitenRechner
{
    public static class StarTimeSplitter
    {
        public static DateTime StarTimeSplitterCalc(string beginTime)
        {
            if (String.IsNullOrWhiteSpace(beginTime)) return new DateTime(0);
            if (beginTime.Length > 5) return new DateTime(0);

            int hours = 0;
            int minutes = 0;
            int length = beginTime.Length;
            int i = 0;

            while (i < length && char.IsDigit(beginTime[i]))
            {
                hours = hours * 10 + (beginTime[i] - '0');
                i++;
            }

            if (i < length && beginTime[i] == ':') { i++; }

            while (i < length && char.IsDigit(beginTime[i]))
            {
                minutes = minutes * 10 + (beginTime[i] - '0');
                i++;
            }

            DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, 0);
            return time;
        }
    }
}
