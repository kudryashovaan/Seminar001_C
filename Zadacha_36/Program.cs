/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray (int[] collection){
    for(int i=0; i<collection.Length; i++){
        collection[i] = new Random().Next(int.MinValue,int.MaxValue);
    }
}

void PrintArray (int[] col){
    for(int i=0; i<col.Length; i++){
        Console.Write(col[i] +" ");
    }
    Console.WriteLine();
}

int[] array = new int[10];
int sum = 0;
FillArray (array);
Console.Write("Mассив заполненный случайными числами: ");
PrintArray (array);

for (int i=0; i<array.Length; i++){
    if (array[i]%2 != 0){
        sum = sum + array[i];
    }
}
Console.WriteLine("Cуммa элементов, стоящих на нечётных позициях: " + sum);


