// Урок 9. Как не нужно писать код. Часть 3
Console.WriteLine("Урок 9. Как не нужно писать код. Часть 3\n\n");

//Вывод чисел от n до 1 с помощью рекурсии
void RecursionWriteNumToOne(int num) 
{
    if (num == 1) Console.Write(num + " ");

    if (num > 1) {
        RecursionWriteNumToOne(num - 1);
        Console.Write(num + " ");
    }
    
    if (num < 1) {
        RecursionWriteNumToOne(num + 1);
        Console.Write(num + " ");
    }
}

Console.Write("Задача 64. Вывести числа от n до 1 с помощью рекурсии\n\n");
    
Console.Write("Задайте целое число > ");
int numWrite = Convert.ToInt32(Console.ReadLine());
RecursionWriteNumToOne(numWrite);
Console.WriteLine("\n\n");

//Задача 66. Найти сумму от n до m с помощью рекурсии
Console.Write("Задача 66. Найти сумму от n до m с помощью рекурсии\n\n");

int RecursionSumAllNumToGap(int n1, int n2)
{
    
    if (n1 > n2) return n2 + RecursionSumAllNumToGap(n1 - 1, n2);         
    
    if (n1 < n2) return n1 + RecursionSumAllNumToGap(n1, n2 - 1);
    
    if (n1 == n2) return(n1 + n2);
    else return 0;
}
    
Console.Write("Задайте первое число > ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число > ");
int num2 = Convert.ToInt32(Console.ReadLine());
int rez = RecursionSumAllNumToGap(num1, num2);
Console.WriteLine("Сумма чисел от " + num1 + " до " + num2 + " равна " + rez + "\n\n");


//Задача 68. Вычисление функции Аккермана с помощью рекурсии
Console.Write("Задача 68. Вычисление функции Аккермана с помощью рекурсии\n\n");

int RecursionAccermanFunc(int n, int m)
{     
    if (n == 0) return m + 1;         
    
    else if (n > 0 && m == 0) return RecursionAccermanFunc(n - 1, 1);
    
        else if (n > 0 && m > 0) return RecursionAccermanFunc(n - 1, m - 1);
    else return 0;
}
    
Console.Write("Задайте первое число > ");
int numA1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число > ");
int numA2 = Convert.ToInt32(Console.ReadLine());
int rezA = RecursionAccermanFunc(numA1, numA2);
Console.WriteLine("Функция Аккермана для " + numA1 + " и " + numA2 + " равна " + rezA);


