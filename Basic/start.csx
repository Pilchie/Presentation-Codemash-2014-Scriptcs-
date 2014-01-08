var greeter = new Greeter();
greeter.Greet("Hello from scriptcs");

class Greeter
{
    public void Greet(string message)
    {
        Console.WriteLine(message);
    }
}
