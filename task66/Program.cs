/*Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от М до N.
M = 1;N = 15 -> 120
M = 4; N = 8. -> 30*/

int ShowNumbers(int m, int n)
{
    if(m - n <= 0)
  {
    return m + ShowNumbers(m + 1, n);
  }
  return 0;
} 

Console.Write(ShowNumbers(2, 5));
