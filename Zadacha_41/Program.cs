/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через запятую: ");
string str = Console.ReadLine();
string strings = str.Replace(",", "");
char[] ch = new char[strings.Length];
ch = strings.ToCharArray();
int[] number = new int [ch.Length];

for (int i=0; i<ch.Length; i++){
    number[i] = Convert.ToInt32(new string(ch[i], 1));
    Console.Write(number[i] + " ");
}
Console.WriteLine();
int count = 0;
for (int i=0; i<number.Length; i++){
   if (number[i]>0){
       count++;
   }
}
Console.WriteLine("Чисел больше 0: " + count);

