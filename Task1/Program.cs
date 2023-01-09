//Написать программу, которая на вход получает массив, 
//а на выходе собирает новый массив только из чисел, кратных 5.
int[] arr = {2, 5, 6, 10, 32, 30};

int count = 0;
int index = 0;

while (index < arr.Length)
{
    if (arr[index] % 5 == 0)
    {
        count++;
    }
    index++;
}
int[] arrNew = new int[count];
index = 0;
int IndexNew = 0;

while (index < arr.Length)
{
    if (arr[index] % 5 == 0)

    {
        arrNew[IndexNew] = arr[index];
        IndexNew++;
    }
    index++;
}
Console.WriteLine(arrNew);
index = 0;
while (index < arrNew.Length)
{
    System.Console.WriteLine(arrNew[index]);
    index++;
}