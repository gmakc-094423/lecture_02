int Max(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (result < arg2) result = arg2;
  if (result < arg3) result = arg3;
  return result;
};

int[] arry = {11, 23, 43, 45, 15, 26, 97, 58, 69};

// применение вложенной функции
// int max = Max(
//   Max(a1, b1, c1), 
//   Max(a2, b2, c2), 
//   Max(a3, b3, c3));

// вложенные функции обращение к массиву
int max = Max(
  Max(arry[0], arry[1], arry[2]), 
  Max(arry[3], arry[4], arry[5]), 
  Max(arry[6], arry[7], arry[8]));

Console.WriteLine(max);
