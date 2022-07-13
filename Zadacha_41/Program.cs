/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.WriteLine("Введите числа через запятую: ");
string str = Console.ReadLine();
Console.WriteLine();
int count = 0;

for (int i=0; i<str.Length; i++){   
    if ((i+1)<str.Length &&str[i] == '-'){
        i++;
        while ((i+1)<str.Length && char.IsDigit(str[i])){
            if((i+1)<str.Length && !char.IsDigit(str[i+1])){
                continue;
            }  
            i++;
            continue;
        }
        
    }
    while ((i+1)<str.Length && char.IsDigit(str[i+1])) {
        i++;
        if (!char.IsDigit(str[i+1]) && (i+1)<str.Length){
        count++;
        continue;
        }
    } 
    if (char.IsDigit(str[i])){       
        if (str[i] > '0') 
        count++;
    }
}
Console.WriteLine("Чисел больше 0: " + count);

