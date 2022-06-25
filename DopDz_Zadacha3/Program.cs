/*Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. 
Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше. 
На отгадывание дается 3 попытки.*/

int RandomNumber = new Random().Next(0, 10);
Console.WriteLine(RandomNumber);
int count = 1;
int limit = 3;

Console.WriteLine("Программа загадала случайное число в диапазоне от 0 до 10. Угадай число. Число попыток = " + limit);
Console.Write("Введите число с клавиатуры: ");

while (count<=limit){
    int number = Convert.ToInt32(Console.ReadLine());
    if (RandomNumber.Equals(number)){
        Console.Write("Поздравляем! Вы угадали число!");
        return;
    }
    else {
        if(number<RandomNumber) {
            Console.WriteLine("Ваше число меньше загаданного!");
        }
        else {
            Console.WriteLine("Ваше число больше загаданного!");
        }
        if(count<=limit-1){
            Console.Write("Введите число с клавиатуры: ");
        }  
    }
    count++;
}
Console.Write("Вы проиграли!");
