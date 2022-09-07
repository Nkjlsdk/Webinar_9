// Вывести числа от M до N. Найти сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N > M:");
int numberN = Convert.ToInt32(Console.ReadLine());
int Sum(int numM, int numN)//  ввод функции для рекурсии
{
    //Базовый случай
    
    if (numN-numM == 1) return numN+numM;
    //Рекурсивный случай
    return (numN+Sum(numM, numN-1));
   
}
Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {Sum(numberM, numberN)}");
