/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}
int m = InputInt("Введите число строк массива: ");
int n = InputInt("Введите число граф массива: ");
Console.WriteLine("Массив: ");
int[,] array = new int[m, n];
Random random = new Random();    
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        array[i, j] = random.Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int sumStr = 0;
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        sumStr = sumStr + array[i, j];
    }
    Console.WriteLine("Сумма строки " + (i+1) + ": " + sumStr);
    sumStr = 0;
}

