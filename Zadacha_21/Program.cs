/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
int InputInt(string output) {     Console.Write(output);     return Convert.ToInt32(Console.ReadLine()); }

int ax1 = InputInt("Введите координаты первой точки ax1: ");
int ay1 = InputInt("Введите координаты первой точки ay1: ");
int az1 = InputInt("Введите координаты первой точки az1: ");
int bx2 = InputInt("Введите координаты первой точки bx2: ");
int by2 = InputInt("Введите координаты первой точки by2: ");
int bz2 = InputInt("Введите координаты первой точки bz2: ");

double distance = Math.Sqrt((bx2 - ax1)*(bx2 - ax1) + (by2 - ay1)*(by2 - ay1) + (bz2-az1)*(bz2-az1));
Console.WriteLine(distance); 

