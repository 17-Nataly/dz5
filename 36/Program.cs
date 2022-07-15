/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите длину массива ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[N];
Random rnd = new Random();
int sum = 0;

for (int i = 0; i < N; i++) {
    arr[i] = rnd.Next(100, 1000);
    Console.WriteLine(arr[i] + " ");
    if (i % 2 == 1) {
        sum += arr[i];
    }
}
 Console.WriteLine("сумма чисел на нечетных позициях " + sum);