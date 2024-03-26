
using Thadacha_2;
var Smartphone = new Smartphone( "Apple",  "Iphone 15",  2023,  512, "Black", 100);
Smartphone.Info();

Smartphone.UpdateBattery(59);

if (Smartphone.NeedsToReplaced())
{
    Console.WriteLine("Yes,needs");
    Smartphone.Reset();
}
else
{
    Console.WriteLine("Not necessary");
}
