/*username.ToLower()-позволяет все символы вашей строки перевести в нижний регистр.
If-если
Else-иначи
*/
Console.Write(" Введите имя пользователя: ");
string username = Console.ReadLine();

if ( username.ToLower() == "вася" )
{
  Console.WriteLine("Здорова братан");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}
