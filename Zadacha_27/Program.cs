/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int InputInt(string output) {     
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine()); 
}

int number = InputInt("Введите число: ");
int number2 = number;
int length = 0;
int answer = 0;
while(number2>0){
        number2 = number2 / 10;
        length++;
    }
for (int i=0; i<length; i++){
    answer = answer + number % 10;
    number = number / 10;
}

Console.WriteLine("Cуммa цифр в числе: " + answer);
