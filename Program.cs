
using Bankaccount;

LogIn AccessToAccount = new LogIn("", "");
Startsite UserInterface = new Startsite();

Console.Clear();

GetData();

Console.Clear();

Console.WriteLine($"Username is {AccessToAccount.Setusername}\n" +
                  $"Password {AccessToAccount.PasswordInput}");

Console.Write("y (yes), n (no) ");
AccessToAccount.SetSaving(Console.ReadLine());



Update();
while (UserInterface.ToString() != "3")
{
    UserInterface.WahlAussuchen(Console.ReadLine());
    Update();
}
Console.Clear();
Console.WriteLine("Exiting");


void Update()
{
    Console.Clear();
    Console.WriteLine("Morhaf`s Bank for better World");
    Console.WriteLine
    ($"Welcomme {(AccessToAccount.Setusername.ToUpper())}\n" + 
     $"Guthaben:{UserInterface.GetGuthaben()}Euro\n"+ 
     $"Schulden:{UserInterface.GetSchulden()}Euro\n" +
     $"Spenden: {UserInterface.GetSpenden()} Euro\n\n"+
     $"What you want to do?\n" +
     $"1:  Spenden\n" +
     $"2:  Schulden zahlen\n" +
     $"3:  Exit");
}

void GetData()
{
    while (AccessToAccount.Setusername.Length <= 2)
    {
        
        Console.Write("Username: ");
        AccessToAccount.Setusername = Console.ReadLine();
        Console.Clear();
    }

    while (AccessToAccount.PasswordInput.Length < 7)
    {
        Console.Write("Password: ");
        AccessToAccount.PasswordInput = Console.ReadLine();
        Console.Clear();
    }
}

