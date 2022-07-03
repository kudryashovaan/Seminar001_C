/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int InputInt(string output) {     
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine()); 
}

int number1 = InputInt("Введите первое число: ");
int number2 = InputInt("Введите второе число: ");
int answer = number1;
for(int i=1; i<number2; i++){
        answer = answer * number1;
    }

Console.WriteLine("Ответ: " + answer);