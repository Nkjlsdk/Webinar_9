//Задача 68. Вычисление функции Аккермана с помощью рекурсии для двух неотрицательных числа m и n.

Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numM, int numN)//  ввод функции для рекурсии
{
    //Базовый случай
    
    if (numM == 0) return numN + 1;
    if (numN == 0) return Akkerman(numM-1,1);
    //if (numM > 0 && numN > 0) 
    //Рекурсивный случай
    return Akkerman(numM-1, Akkerman(numM, numN-1));
   
}
Console.WriteLine($"Аккерман:{numberM},{numberN} = {Akkerman(numberM, numberN)}");
