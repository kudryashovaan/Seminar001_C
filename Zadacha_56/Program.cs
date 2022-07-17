/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray (int[,] collection, int m, int n){
    Random random = new Random();
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            collection[i, j] = random.Next(0, 10);
        }
    }
}
void PrintArray (int[,] collection, int m, int n){
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void SumStringArray (int[,] collection, int[] str, int m, int n){
    int sum = 0;
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            sum+= collection[i,j];
        }
    str[i] = sum;
    sum = 0;
    
    }
}
void PrintSumStringArray(int[] array){
    int count = array.Length;

    for(int i=0; i<count; i++){
        Console.WriteLine("Сумма строки " + (i+1) + " = " + array[i]);
    }
    Console.WriteLine();
}
void IndexOfMinStrArray(int[] array){
    int min = array[0];
    int str = 1;
    for (int i = 0; i<array.Length; i++){
        if (array[i]<min){
            min = array[i];
            str = i+1;
        }
    }
    Console.WriteLine("Наименьшая сумма элементов в (во): " + str + " строке.");
}

Console.WriteLine("Задаем прямоугольный двумерный массив.");
int m = InputInt("Введите число строк массива: ");
int n = InputInt("Введите число граф массива: ");
Console.WriteLine("Массив: ");

int[,] array = new int[m, n];
FillArray (array, m, n);
PrintArray (array, m, n);

int[] strArray = new int[m];
SumStringArray (array, strArray, m, n);
PrintSumStringArray(strArray);
IndexOfMinStrArray(strArray);

