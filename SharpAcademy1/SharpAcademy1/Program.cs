using SharpAcademy1;


var menu = new Menu();

var name = GetName();

menu.ShowMenu(name);

string GetName()
{
    Console.WriteLine("Please enter your name");
    var name = Console.ReadLine();
    return name;
}




