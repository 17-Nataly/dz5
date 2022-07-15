/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.WriteLine("Введите длину массива ");
int N = Convert.ToInt32(Console.ReadLine());

int [] arr = new int [N];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < N; i++) {
    arr[i] = rnd.Next(1, 10);
    Console.Write(arr[i] + " ");
    if (arr[i] % 2 == 0) {
        count++;
    }
}
Console.WriteLine("четных чисел " + count);
