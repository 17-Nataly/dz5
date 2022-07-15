/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double [] arr = new double [5]{3, 7, 22, 2, 78};
int imax = 0;
int imin = 0;
double result = 0;

for (int i = 0; i < 5; i++) {
    if (arr[i] > arr[imax]) {
        imax = i;
    }
    else if (arr[i] < arr[imin]) {
        imin = i;
    }
}
result = arr[imax] - arr[imin];

Console.WriteLine(result);
