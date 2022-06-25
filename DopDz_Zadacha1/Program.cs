/*В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

string message = "Секретное сообщение";
string password = "1234";

Console.Write("Введите пароль, у вас 3 попытки: ");

string FirstTry = Console.ReadLine();

if (FirstTry.Equals(password)){
    Console.WriteLine(message);
    return;
}
else {Console.WriteLine("Введите пароль еще раз. осталос 2 попытки!");}

string SecondTry = Console.ReadLine();

if (SecondTry.Equals(password)){
    Console.WriteLine(message);
    return;
}
else {Console.WriteLine("Введите пароль еще раз. осталос 1 попытка!");}

string ThirdTry = Console.ReadLine();

if (ThirdTry.Equals(password)){
    Console.WriteLine(message);
    return;
}
else {
    Console.WriteLine("Попытки ввести пароль закончились!");
}
