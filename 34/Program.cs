﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


int N = 6;
int [] arr = new int [N];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < N; i++) {
    arr[i] = rnd.Next(100, 1000);
    if (arr[i] % 2 == 0) {
        count++;
    }
}
Console.WriteLine(count);