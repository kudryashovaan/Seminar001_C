/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int n = InputInt("Введите число: "); 
int count = 1; while(count <= n) {     
    int quadro = count * count * count;     
    Console.WriteLine(quadro + " ");     
    count++; 
}     
int InputInt(string output) {     
     Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine()); 
}
