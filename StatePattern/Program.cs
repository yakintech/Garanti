

using StatePattern.Models;

var assistant = new Assistant();

assistant.Answer();
Console.ReadLine();

//change mode
assistant.Change(new NightMode());
assistant.Answer();
Console.ReadLine();

//change mode
assistant.Change(new AwayMode());
assistant.Answer();
Console.ReadLine();

