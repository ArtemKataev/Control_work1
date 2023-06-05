int size = Convert.ToInt32(Console.ReadLine());
string [] array = new string [size];
for (int i = 0; i < size; i++)
{
  string number = Convert.ToString(Console.ReadLine()!);
  array[i]= number;
}


string[] arrayFinal = new string[size];
int lenght = 3;
int position = 0;
for (int j = 0; j < size; j++)
{
  if(array[j].Length<=lenght)
  {
    arrayFinal[position]= array[j];
    position++;
  }
}

System.Console.WriteLine();

{
    for (int i = 0; i < size; i++)
    {
        Console.Write(arrayFinal[i] + " ");
    }
    Console.WriteLine();
}


