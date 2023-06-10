// See https://aka.ms/new-console-template for more information
Console.WriteLine("Concise syntax , Expression baesd ,Pattern matching ,Simplified null checking!");

//OldSwitchUseOf();
NewSwirchUseOf();

Console.ReadLine();


static void OldSwitchUseOf()
{
    Console.WriteLine("Gümler için sayı Giriniz = ");
    int number = Convert.ToInt32(Console.ReadLine());
    string dayOfWeek = string.Empty;
    switch (number)
    {
        case 1:
            dayOfWeek = "Sunday";
            break;
        case 2:
            dayOfWeek = "Monday";
            break;
        case 3:
            dayOfWeek = "Tuesday";
            break;
        case 4:
            dayOfWeek = "Mednesday";
            break;
        case 5:
            dayOfWeek = "Thursday";
            break;
        case 6:
            dayOfWeek = "Friday";
            break;
        case 7:
            dayOfWeek = "Saturday";
            break;

        default:
            dayOfWeek = "Invalid input";
            break;
    }
    Console.WriteLine(dayOfWeek);
}


static void NewSwirchUseOf()
{
    Console.WriteLine("Gümler için sayı Giriniz = ");
    int number = Convert.ToInt32(Console.ReadLine());
    string dayOfWeek = number switch
    {
        1 => "Sunday",
        2 => "Monday",
        3 => "Tuesday",
        4 => "Wednesday",
        5 => "Thursday",
        6 => "Friday",
        7 => "Saturday",
        _ => "Invalid input",
    };
    Console.WriteLine(dayOfWeek);
}







