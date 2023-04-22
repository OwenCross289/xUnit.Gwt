using Build;
using Cake.Frosting;

public static class Program
{
    public static int Main(string[] args)
    {
        return new CakeHost()
            .UseContext<BuildContext>()
            .Run(args);
    }
}

[IsDependentOn(typeof(TestTask))]
public sealed class Default : FrostingTask
{
}