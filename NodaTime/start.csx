using NodaTime;

var eastern = DateTimeZoneProviders.Tzdb["US/Eastern"];
var now = SystemClock.Instance.Now;
var nextYear = now + Duration.FromStandardDays(365);

var intervals = eastern.GetZoneIntervals(now, nextYear);

foreach (var interval in intervals)
{
    Console.WriteLine(interval);
}
