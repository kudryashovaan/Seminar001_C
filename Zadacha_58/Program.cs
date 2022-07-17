/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/

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
void ProductOfNumbers (int[,] collectionOne, int[,] collectionTwo, int[,] collectionCopy, int m, int n){
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            collectionCopy[i,j] = collectionOne[i,j] * collectionTwo[i,j];
        }
        
    }
}

Console.WriteLine("Задаем 2 двумерных массива.");
int m = InputInt("Введите число строк массива: ");
int n = InputInt("Введите число граф массива: ");

Console.WriteLine("Массив 1: ");
int[,] arrayOne = new int[m, n];
FillArray (arrayOne, m, n);
PrintArray (arrayOne, m, n);

Console.WriteLine("Массив 2: ");
int[,] arrayTwo = new int[m, n];
FillArray (arrayTwo, m, n);
PrintArray (arrayTwo, m, n);


int[,] arrayCopy = new int[m, n];
ProductOfNumbers(arrayOne, arrayTwo, arrayCopy, m, n);
Console.WriteLine("Их произведение будет равно следующему массиву: ");
PrintArray (arrayCopy, m, n);