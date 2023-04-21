// .Net 6.0

internal class davaleba3
{
    static double Calculate(double sigrdze, double sigane)
    {
        return sigrdze * sigane;
    }

    static double Calculate(double sigrdze, double sigane, double simagle)
    {
        return sigrdze*sigane * simagle;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Calculate(4,5));
        Console.WriteLine(Calculate(4,5,6));
    }
}
