/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}
int m = InputInt("Введите число строк массива: ");
int n = InputInt("Введите число граф массива: ");
Random rnd = new Random();

double[,] a = new double[m, n];
 Random random = new Random();
    
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        a[i, j] = 20.0*rnd.Next()/2147483648-10.0;
        Console.Write("{0,5:f1}", a[i, j]);
    }
    Console.WriteLine();
    }