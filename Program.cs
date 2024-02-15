// See https://aka.ms/new-console-template for more information
using Feb15WelcomeApp1;

Console.WriteLine("Welcome to Authentication App");
SignIn obj=new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@12345"));

