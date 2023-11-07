int time = DateTime.Now.Hour;

if (time >= 6 && time < 11)
    Console.WriteLine("Good morning!");
else if (time <= 18)
    Console.WriteLine("Have a nice Day!");
else
    Console.WriteLine("Good night!");

string result = time <= 18 ? "Have a nice Day?" : "Good Night!";

result = time >= 6 && time < 11 ? "Good morning!" : time <= 18 ? "Have nice Day!" : "Good Night!";
Console.WriteLine(result);
