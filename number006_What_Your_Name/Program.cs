Console.WriteLine("Введите Ваше имя");
string username = Console.ReadLine();

if(username.ToLower() == "кирилл")
{
    Console.Write("Привет, мой ЛЮБИМЫЙ Килька!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}