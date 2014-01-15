Add("Number", 42L);
Add("Uri", new Uri("http://codemash.org"));

#region Fun
long Fib(int ordinal)
{
    if (ordinal <= 0)
    {
        throw new ArgumentException();
    }

    if (ordinal == 1 || ordinal == 2)
    {
        return 1;
    }

    return Fib(ordinal - 1) + Fib(ordinal - 2);
}
#endregion