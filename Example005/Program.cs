Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username == "Galina")
{
    Console.WriteLine("Ура, это же Galina");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}