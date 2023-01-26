// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int GetNum(string text)
{
  Console.WriteLine(text);
  return int.Parse(Console.ReadLine());
}

void Palindrome(int number)
{
  if (number % 10 == number / 10000)
  {
    if ((number / 1000) % 10 == (number / 10) % 10)
    {
      Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число не является палиндромом");
  }
  else Console.WriteLine("Число не является палиндромом");
}

int num = GetNum("Введите 5 значное число: ");
Palindrome(num);