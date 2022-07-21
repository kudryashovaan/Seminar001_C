/*Задача 68: Напишите программу 
вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

int AkkermanFun(int n, int m){
    if (n == 0){ 
        return m + 1;
    }
    if (n != 0 && m == 0){ 
        return AkkermanFun(n - 1, 1);
    }
    if (n > 0 && m > 0){ 
        return AkkermanFun(n - 1, AkkermanFun(n, m - 1));
    }
    return AkkermanFun(n,m);
}
    
Console.WriteLine(AkkermanFun(2, 3));
        
    
