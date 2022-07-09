/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

void FillArray (int[] collection){
    for(int i=0; i<collection.Length; i++){
        collection[i] = new Random().Next(100,1000);
    }
}

void PrintArray (int[] col){
    for(int i=0; i<col.Length; i++){
        Console.Write(col[i] +" ");
    }
    Console.WriteLine();
}

int[] array = new int[10];
FillArray (array);
Console.Write("Mассив заполненный случайными числами: ");
PrintArray (array);

int min = array[0];
int max = array[0];
int raz = 0;

for (int i=0; i<array.Length; i++){
    if (array[i]<min)
    min = array[i];
    if (array[i]>max)
    max = array[i];
}
raz = max-min;
Console.WriteLine("Минимальное число массива: " + min);
Console.WriteLine("Максимальное число массива: " + max);
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + raz);

