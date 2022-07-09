/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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
int count = 0;
FillArray (array);
Console.Write("Mассив заполненный случайными положительными трёхзначными числами: ");
PrintArray (array);

for (int i=0; i<array.Length; i++){
    if (array[i]%2 == 0){
        count++;
    }
}
Console.WriteLine("Kоличество чётных чисел в массиве: " + count);


