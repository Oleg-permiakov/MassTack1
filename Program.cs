// Задать одномерный  массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значение которых
// лежат в отрезке [20, 90].
int namber = 0;
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < 10; i++)
{
    if (array[i] >= 20 && array[i] <= 90)
    {

       namber = namber + 1;
    }  
    
} 

Console.WriteLine("-" + namber);
