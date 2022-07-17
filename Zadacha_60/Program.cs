/*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)*/

int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray (int[,,] collection, int m, int n, int o){
    Random random = new Random();
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < o; k++){
            collection[i, j, k] = random.Next(10, 100);
            }
        }
    }
}
void PrintArray (int[,,] collection, int m, int n, int o){
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < o; k++){
            Console.Write(collection[i, j, k] + "(" + i + "," + j + "," + k + ")" + " ");
            }
        }
        Console.WriteLine();
    }
}

int m = InputInt("Введите число m: ");
int n = InputInt("Введите число n: ");
int o = InputInt("Введите число o: ");

int[,,] array = new int[m, n, o];
FillArray (array, m, n, o);
PrintArray (array, m, n, o);