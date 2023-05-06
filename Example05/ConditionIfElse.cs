// Программа на вход принимает имя пользователя и если это имя Маша, 
// то приветствует по особенному, а если любое другое, то по обычному. 

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!!!");
}
else
{
    Console.WriteLine($"Привет, {username}!");
}