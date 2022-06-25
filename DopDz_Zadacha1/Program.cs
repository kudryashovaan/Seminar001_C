/*В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

string message = "Секретное сообщение";
string password = "1234";

Console.Write("Введите пароль, у вас 3 попытки: ");
int n = 1;
while(n<=3){
string Try = Console.ReadLine();
if (Try.Equals(password)){
    Console.WriteLine(message);
    return;
}
else {Console.WriteLine("Введите пароль еще раз.");}
n++;
}
Console.WriteLine("Попытки ввести пароль закончились!");

