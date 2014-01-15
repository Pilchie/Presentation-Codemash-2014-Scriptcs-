using System;
using ConfigR;

class Program
{
    static void Main(string[] args)
    {
        var count = Config.Global.Get<long>("Number");
        var uri = Config.Global.Get<Uri>("Uri");

        Console.WriteLine(
            "Got {0} and {1} from the configuration",
            count,
            uri);
    }
}