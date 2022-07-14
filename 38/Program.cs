/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int N = 6;
double [] arr = new double [N];
Random rnd = new Random();
double diff = 0;

double max = arr[0]; double min = arr[0];
for (int i = 0; i < N; i++) {
    if (arr[i] > max) {
        max = arr[i];
    }
    if (arr[i] < min) {
        min = arr[i];
    }
}
diff = max - min;

Console.WriteLine(rnd);
Console.WriteLine(diff);