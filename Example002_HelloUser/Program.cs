/*ReadLine - эта команда считывает данные
 Переменная string(строка) - в ней хранят данные введенные пользователем
 username - имя переменной
 Console.WriteLine - Выводит данные в консоль
 WriteLine - переводит курсор на новую строку
 Write - выводит всё в одну строку*/ 
Console.Write ("Введите ваше имя");
string username = Console.ReadLine();
Console.Write ("Привет, ");
Console.Write (username);