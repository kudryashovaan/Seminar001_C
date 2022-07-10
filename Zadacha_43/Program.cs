/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

int InputInt(string output) {     
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine()); 
}

int b1 = InputInt("Введите b1: ");
int k1 = InputInt("Введите k1: ");
int b2 = InputInt("Введите b2: ");
int k2 = InputInt("Введите k2: ");

Console.WriteLine();

