// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.  Использовать функцию
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.Write("Введи 1 число: ");

int[] array = new int[2];

array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи 2 число: ");
array[1] = Convert.ToInt32(Console.ReadLine());

void Result(int[] array){
  int divNumber = array[0] % array[1];
  if (divNumber == 0)
  {
    Console.WriteLine("Кратные числа ");
  }
  else {
    Console.WriteLine("Не кратные числа, остаток  " + divNumber);
  }
}

int[] Comparision(int[] array){
  int[] array1 = new int[2];
  if (array[0] > array[1]){
    array1[0] = array[0];
    array1[1] = array[1];
  }
  else {
    array1[0] = array[1];
    array1[1] = array[0];
  }
  return array1;
}

int[] array1 = Comparision(array);

Result(array1);
 

