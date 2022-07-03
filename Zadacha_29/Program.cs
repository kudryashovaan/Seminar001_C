/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void FillArray (int[] collection){
    for(int i=0; i<collection.Length; i++){
        collection[i] = new Random().Next(1,10);
    }
}

void PrintArray (int[] col){
    for(int i=0; i<col.Length; i++){
        Console.Write(col[i]);
    }
    Console.WriteLine();
}

int[] array = new int[8];

FillArray (array);
Console.Write("Массив: ");
PrintArray (array);
