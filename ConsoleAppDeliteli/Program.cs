using ClassLibraryDeliteli;
// Тест для вывода делителей числа n. Ожидаемый ввод - целое натуральное число n
void Test1()
{
    int n = 20;
    string result = Deliteli.PrintDivisiors(n);
    if (result == "1,2,4,5,10,20")
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test1();
// Тест для поиска чисел с ровно 5 делителями в диапазоне [m, n]
// Ожидаемый ввод - целые числа m и n
void Test2()
{
    int m = 0;
    int n = 25;
    string result = Deliteli.PrintNumbersWith5Divisors(m, n);
    if (result == "Числа ровно с 5 делителями в диапазоне [0, 25]: 16")
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test2();
// Тест для факторизации числа n
// Ожидаемый ввод - целое число n
void Test3()
{
    int n = 180;
    string result = Deliteli.GetFactorizationString(n);
    if (result == "180 = 2^2 * 3^2 * 5")
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test3();
// Тест для поиска первых N простых чисел
// Ожидаемый ввод - целое число (количество) n
void Test4()
{
    int n = 10;
    string result = Deliteli.PrintFirstNPrimes(n);
    if (result == "Первые 10 простых чисел: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29")
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test4();
// Тест для поиска первых N простых чисел (алгоритм Решето Эратосфена)
// Ожидаемый ввод - целое число (количество) n
void Test5()
{
    int n = 10;
    string result = Deliteli.PrintPrimes(n);
    if (result == "Первые 10 простых чисел: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29")
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test5();
// Тест для поиска наибольшего общего делителя двух чисел (алгоритм Эвклида)
// Ожидаемый ввод - целые числа n и m
void Test6()
{
    int n = 10;
    int m = 5;
    int result = Deliteli.NOD(n, m);
    if (result == 5)
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test6();
// Тест для поиска наименьшего общего кратного двух чисел
// Ожидаемый ввод - целые числа n и m
void Test7()
{
    int n = 10;
    int m = 5;
    int result = Deliteli.NOK(n, m);
    if (result == 10)
    {
        Console.WriteLine("Тест пройден успешно");
    }
    else
    {
        Console.WriteLine("Тест не пройден");
    }
}
Test7();