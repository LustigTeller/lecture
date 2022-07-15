Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if ( username.ToLower() == "рома")
{
    Console.WriteLine("Привет, РОМА!!");
}
else
{
    Console.WriteLine($"Привет, {username}");
}