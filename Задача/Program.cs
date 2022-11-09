Console.WriteLine ("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
string [] a = new string[size];
string [] b = new string[size];

int count = 0;
FillArray (a);
PrintArray (a);
SelectionSort (a);
Console.WriteLine();
Console.WriteLine("Отсортированный массив по условию задачи:");

int i = 0;
if (count == size)
{
    PrintArray (a);
}
else
{
    string [] c = new string[count];
    int j = 0;
    while (i<b.Length)
    {
        
        if(b[i] != null)
        {
            c[j] = b[i];
            j++;
        }
        i++;

    }
    PrintArray (c);
   
}


void PrintArray (string []array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + "\t");
    }
    Console.WriteLine();
}
void FillArray (string []array)
{
    for(int i=0; i< array.Length; i++)
    {
        Console.WriteLine($"Заполните ячейку №{i+1}");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
    Console.WriteLine("Ваш массив:");
}
void SelectionSort(string []array)
{
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            b [i] = array [i];
            count ++;
        }
    }
}
