/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/
int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray (int[,] collection, int m, int n){
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArraySpiral (int[,] collection, int m, int n){
    int row = 0;
    int col = 0;
    int rowx = 1;
    int coly = 0;
    int count = 0;
    int numerator = n;
     
    for (int i = 0; i < collection.Length; i++) {
        collection[row, col] = i + 1;
        if (--numerator == 0) {
            numerator = n * (count %2) + m * ((count + 1) %2) - (count/2 - 1) - 2;
            int temporary = rowx;
            rowx = -coly;
            coly = temporary;
            count++;
        }
     
        col += rowx;
        row += coly;
    }
    
}
int m = InputInt("Введите число m: ");
int n = InputInt("Введите число n: ");
int[,] array = new int[m, n];
FillArraySpiral (array, m, n);
Console.WriteLine("Массив: ");
PrintArray (array, m, n);