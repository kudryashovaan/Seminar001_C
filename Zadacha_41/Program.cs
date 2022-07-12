/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.WriteLine("Введите числа через запятую: ");
string str = Console.ReadLine();

Console.WriteLine();
int count = 0;
string x = "-";
for (int i = 0; i < str.Length; i++){   
    if ((i+2)<str.Length && str[i].Equals(x.ToString()))
        i=i+2;
    if (str[i] > '0' && i + 1 < str.Length && char.IsDigit(str[i + 1]))
        //xz
    if (char.IsDigit(str[i]))    
    {       
        if (str[i] > '0') 
        count++;
    }
}
Console.WriteLine("Чисел больше 0: " + count);

