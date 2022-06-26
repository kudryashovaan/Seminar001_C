/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите прядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day<1 || day>7){
    Console.Write("Дней недели всего 7! Введите прядковый номер дня недели: ");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day>0 && day <6){
    Console.WriteLine("Это рабочий день.");
}
else {
    Console.WriteLine("Это выходной!");
}
