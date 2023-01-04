/*68: Напишите программу вычисления функции Аккермана с _помощью рекурсии. Даны два неотрицательных числа т и п.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2-> A(m,n) = 29*/

int MakeAccFunction(int n, int m)
{
    //if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return MakeAccFunction(n - 1, 1);
    if (n > 0 && m > 0) return MakeAccFunction(n - 1, MakeAccFunction(n, m - 1));
    return 0;
}

Console.Write(MakeAccFunction(3, 2));
