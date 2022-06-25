/*Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается*/

while(true){
    Console.Write("Введите exit для завершения.");
    string exit = Console.ReadLine();
    if (exit.Equals("exit")){
        return;
    }
}