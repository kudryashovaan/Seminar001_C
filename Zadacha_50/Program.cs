/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine());
}
int m = InputInt("Введите число строк массива: ");
int n = InputInt("Введите число граф массива: ");
Console.WriteLine("Массив: ");
int[,] array = new int[m, n];
Random random = new Random();    
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        array[i, j] = random.Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
int position = InputInt("Введите позицию элемента в двумерном массиве: ");
int count = 0;
int element = 0;
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        element = array[i, j];
        if (i!=0 || j!=0){
        count++;
        }
        if (position == count){
            Console.WriteLine("Элемент на позиции " + position + " = " + element);
        }
        else if (position > count && i==(m-1) && j==(n-1)) {
            Console.WriteLine("Такого числа на позиции "  + position + " в массиве нет.");
        }
    }       
}


