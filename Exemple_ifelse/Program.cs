Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username == "volk")
{
    Console.WriteLine("Привет, групый");
}
else
{
    Console.Write("Добро пожаловать, ");
    Console.WriteLine(username);
}