/*Задача 68: Напишите программу 
вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

int AkkermanFun(int m, int n){
    if (m == 0){ 
        return n + 1;
    }
    if (m != 0 && n == 0){ 
        return AkkermanFun(m - 1, 1);
    }
    if (m > 0 && n > 0){ 
        return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
    }
    return AkkermanFun(m,n);
}
    
Console.WriteLine(AkkermanFun(2, 3));
        
    
