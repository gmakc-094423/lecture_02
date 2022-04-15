// способы задания массива
// int[] arry = {1, 2, 3, 4};
// int[] arry2 = new int[10];
// int[] arry3 = new[10];
// int[] arry4 = {};
// int[] arry5;

int[] numbers = new int[5];

FillIntArray(numbers);

void FillIntArray (int[] array) {
  int index = 0;
  while (index < array.Length)
  {
    array[index] = new Random().Next(0, 100);
    Console.Write(numbers[index] + ", ");
    index++;
  }
}

// Console.WriteLine(numbers[1]);

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine();
int number = RandomNumber(10, 100);
Console.WriteLine(number);
int first = number / 10;
int second = number % 10;

// if (first > second){
//   Console.WriteLine(first);
// }
int max = MaxNumber(first, second);

Console.WriteLine(max);


int RandomNumber(int min, int max){   // функция получения рандомных чисел
  return new Random().Next(min, max);
}

int MaxNumber(int number1, int number2)   // функция сравнения большего из двух чисел
{
  if (number1 > number2) {
    return number1;
  } 
  return number2;
}

