Random coinFlip = new();
int result = coinFlip.Next(0, 2);
Console.WriteLine((result == 0) ? "heads" : "tails"); 