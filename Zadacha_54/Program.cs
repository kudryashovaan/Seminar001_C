/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

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
void SelectionSort(int[,] array, int m, int n){
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n-1; j++){
            for (int k = 0; k < n-1; k++){
                if (array[j,k] > array[j, k + 1]){
                    int max = array[j,k];
                    array[j,k] = array[j, k + 1];
                    array[j, k + 1] = max;
                }
            }
        }    
    }
}
int m = InputInt("Введите число строк массива: ");
int n = InputInt("Введите число граф массива: ");
Console.WriteLine("Массив: ");
int[,] array = new int[m, n];

FillArray (array, m, n);
PrintArray (array, m, n);
SelectionSort (array, m, n);
Console.WriteLine("Массив отсортирован: ");
PrintArray (array, m, n);




