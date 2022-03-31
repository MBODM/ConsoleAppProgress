var name = $"{nameof(SynchronizationContext)}.{nameof(SynchronizationContext.Current)}";

if (SynchronizationContext.Current == null)
{
    Console.WriteLine($"{name} is null");
}
else
{
    Console.WriteLine($"{name} is not null");
}

Console.WriteLine();

IProgress<char> progres = new Progress<char>(c => Console.Write(c));

for (int i = 1; i < 100; i++)
{
    Console.Write(i + " ");

    progres.Report('X');
}

Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.WriteLine();

Console.Read();

Environment.Exit(0);
