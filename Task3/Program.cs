// //Написать программу, которая на вход получает массив, 
//а на выходе собирает новый массив только из чисел, кратных 5.
int[] CreateCollection(int size)
{
    int[] collection = new int[size];
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(20);
        index = index + 1;
    }
    return collection;
}
int SolutionExercise(int[] array)
{
    int currentPosition = 0;
    int sum = 0;
    int Length = array.Length;

    while (currentPosition < Length)
    {
        int currentElement = array[currentPosition];
        if (currentElement % 5 = 0)
        {
            sum = sum + currentElement;
        }
        currentPosition = currentPosition + 1;
    }
    return sum;
}

int[] array = CreateCollection(size: 10);
int sum = SolutionExercise(array);
Console.WriteLine(sum);