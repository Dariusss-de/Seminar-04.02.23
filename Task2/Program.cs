// В двумерном массиве поменять местами строки и столбцы, если матрица квадратная т.е m=n

void FillArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100);
        }
    }
}
void PrintArray(int[,] array)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            Console.Write(array[i, j]+"\t");
        }
         Console.WriteLine();
    }
}

void TranspondArray(int[,] array,int arg1, int arg2)
{

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = i; j < array.GetLength(1); j++)
    {
       if(arg1 == arg2)
        {
        int temp = array[i,j];
        array [i, j] =  array [j, i];
        array [j, i] = temp; 
        }
     }
}
}
Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
try
{
    if(line<=0 || column<=0) 
    {
    throw new Exception("wrong line or colum");
    }

}
catch
{
     Console.Write("Введите количество строк: ");
    line = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    column = int.Parse(Console.ReadLine());
}

int[,] arr = new int[line,column];
FillArray(arr);
PrintArray(arr);
TranspondArray(arr,line, column);
PrintArray(arr);
