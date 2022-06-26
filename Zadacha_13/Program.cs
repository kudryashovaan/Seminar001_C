/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int third = 0;
if (number<100 && number>-100){
    Console.WriteLine("Tретьей цифры нет.");
}
if(number>99 || number<-99){
    while(number>999 || number<-999){
        number = number/10;
    }
    third = number%10;
Console.WriteLine("Tретья цифра: " + third);
}


