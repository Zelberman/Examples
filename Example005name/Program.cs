// имена

Console.WriteLine("Привет, назови свое имя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
    {
        Console.WriteLine("Hello my friend, Masha");
    }
else
    {
        Console.WriteLine("Hello, ");
        Console.WriteLine(username);
    }
