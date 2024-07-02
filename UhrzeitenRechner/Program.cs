namespace UhrzeitenRechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WorkTime Calculator");
            ClockCalc dateCal = new ClockCalc();

            Console.WriteLine("Beginn (hh:mm): ");
            string startTime = Console.ReadLine();

            var time = StarTimeSplitter.StarTimeSplitterCalc(startTime);

            Console.WriteLine($"Die eingegebene Zeit ist: {time.ToString("HH:mm")} Uhr.");

            Console.WriteLine("Worktime (h): ");
            string workTime = Console.ReadLine();

            if(!double.TryParse(workTime, out double workResult)) Console.WriteLine("Error parsing Worktime (h)");

            Console.WriteLine("Breaktime (min): ");
            string breakTime = Console.ReadLine();

            if (!double.TryParse(breakTime, out double breakResult)) Console.WriteLine("Error parsing Worktime (h)");

            Console.WriteLine(dateCal.DateTimeCalc(time, workResult, breakResult));

            Console.ReadKey();
        }
    }
}
