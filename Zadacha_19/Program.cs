/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int InputInt(string output) {     
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine()); 
}

int number = InputInt("Введите пятизначное число: ");
while (number<10000 || number>99999){
    Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

String str = number.ToString();
if(str.Equals(new string(str.Reverse().ToArray()))){
    Console.WriteLine("Палиндром");
}
else Console.WriteLine("Не палиндром");

