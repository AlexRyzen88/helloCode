Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
 
if(username.ToLower() == "Маша")

{
    Console.WriteLine("ура это Маша");

}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}