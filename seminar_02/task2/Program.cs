// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.  Использовать функцию
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.Write("Введи 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи 2 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Result(int number1, int number2){
  int divNumber = number1 % number2;
  if (divNumber == 0)
  {
    Console.WriteLine("Кратные числа ");
  }
  else {
    Console.WriteLine("Не кратные числа, остаток  " + divNumber);
  }
}

if (number1 < number2){
  int num1 = number2;
  int num2 = number1;
}
else {
  int num1 = number1;
  int num2 = number2;
} 
Result(num1, num2);