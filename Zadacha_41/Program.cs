/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int InputInt(string output) {     
    Console.Write(output);     
    return Convert.ToInt32(Console.ReadLine()); 
}

int m = InputInt("Сколько чисел будет введено с клавиатуры: ");;
int[] array = new int[m];
int count = 0;

for (int i=0; i<array.Length; i++){
    array[i] = InputInt("Введите число: ");
    if (array[i]>0){
        count++;
    }
}
Console.WriteLine("Чисел больше 0: " + count);

