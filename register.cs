// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Transactions;

Console.ForegroundColor = ConsoleColor.Cyan;// See https://aka.ms/new-console-template for more information
//аунтификация
Console.WriteLine("введите логин");
Console.WriteLine("введите пароль");
string input = Console.ReadLine();
string unputlag = Console.ReadLine();
string login = "slava";
string password = "hotty";

if (input == login && unputlag == password)
{
    Console.WriteLine("Победа!Вы вошли!");
    Console.WriteLine("введите ширину");
    Console.WriteLine("введите длинну");
    //решение
    double odin = Convert.ToDouble((Console.ReadLine()));
    double dva = Convert.ToDouble((Console.ReadLine()));
    double paint = odin * dva;
    Console.WriteLine(paint);
    Console.ReadKey();
}
else
    Console.WriteLine("Неправильынй логин/пароль");

