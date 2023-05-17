bool running = true;
int qCount = 0;


Console.WriteLine("press Q... and just keep pressing");
Console.ReadLine();

while (running)
{

    if (Console.ReadKey(true).Key == ConsoleKey.Q)
    {
        qCount++;
        Console.WriteLine($"{qCount}");
    }

    Console.Clear();

    Console.WriteLine($"'Q' key count: {qCount}");
    Console.WriteLine("Press 'ESC' to quit the game.");

    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
    {
        running = false;
    }

}
