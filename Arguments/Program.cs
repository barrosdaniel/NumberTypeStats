WriteLine($"There are {args.Length} argument/s.");
foreach (var arg in args)
{
    WriteLine(arg);
}

if (args.Length < 2)
{
    WriteLine("You must specify two colors and a size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}

ForegroundColor = (ConsoleColor)Enum.Parse(
        enumType: typeof(ConsoleColor),
        value: args[0],
        ignoreCase: true
    );

BackgroundColor = (ConsoleColor)Enum.Parse(
        enumType: typeof(ConsoleColor),
        value: args[1],
        ignoreCase: true
    );

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
}