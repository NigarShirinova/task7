int[,] array =
{
    {101, -200, 300, 603 },
    {400, 0, 600, 800},
    {700, 800, -901, 700 }
};

//task1
Console.WriteLine("task1");
for  (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

//task2
Console.WriteLine("task2");
int sum = 0;
for (int i = 0;i < array.GetLength(0); i++)
{
    for(int j = 0;j < array.GetLength(1); j++)
    { sum += array[i,j]; }
}
Console.WriteLine(sum);

//task3
int sum3 = 0;
Console.WriteLine("task3");
for(int i = 0; i < array.GetLength(0); i++)
{
    sum3 += array[i, 1];
}
Console.WriteLine(sum3);

//task4
Console.WriteLine("task4");
for(int i = 0; i< array.GetLength(0); i++)
{
    for(int j = 0; j< array.GetLength(1); j++)
    {
        if (array[i,j] <0)
        {
            Console.WriteLine(array[i, j]);
        }
    }
}

//task5
Console.WriteLine("task5");
int max = array[0, 0];
int min = array[0, 0];
for(int i = 0;i< array.GetLength(0); i++)
{
    for(int j = 0; j< array.GetLength(1); j++)
    {
        if (array[i,j] > max)
        {
            max= array[i,j];
        }
        else if (array[i,j] < min)
        {
            min = array[i,j];
        }
    }
}
Console.WriteLine(max);
Console.WriteLine(min);


//task6
Console.WriteLine("task6");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == 0)
        {
            array[i, j] = array[i, j];
        }
        else if (array[i, j] > 0)
        {
           
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = 2;
            }
            else { array[i, j] = 1; }
        }

        else
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = -2;
            }
            else { array[i, j] = -1; }
        }
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}



//task7
Console.WriteLine("task7");
int[,] array2 ={
    { 1, 2, 3, 4},
    { 5, 6, 7, 8},
    { 9, 10, 11, 12},
    { 13, 14, 15, 16}
};
for(int i = 0; i < array2.GetLength(0); i++)
{
    for(int j = 0; j< array2.GetLength(1); j++)
    {
        if(i == 1)
        {
            array2[i, j] = 0;
        }
        else
        {
            array2[i, j] = array2[i, j];
        }
    }
   
}
 for(int i = 0;i < array2.GetLength(0); i++)
{
    for(int j=0; j< array2.GetLength(1); j++)
    {
        Console.Write(array2[i,j] + " ");
    }
    Console.WriteLine();
}

//task8
Console.WriteLine("task8");
int[,] array3 =
{
    {1, 2,3 },
    { 4, 5, 6 },
    { 6, 7, 8 }
};
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        if (j == 2)
        {
            array3[i, j] = 0;
        }
        else
        {
            array3[i, j] = array3[i, j];
        }
    }
}
    for(int i=0;i< array3.GetLength(0); i++)
    {
        for(int j=0; j< array3.GetLength(1); j++)
        {
            Console.Write(array3[i,j] + " ");
        }
        Console.WriteLine();
    }


//task9
Console.WriteLine("task9");
int sum9 = 0;
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        if (i == j)
        {
            sum9 += array3[i, j];
        }
    }
}
Console.WriteLine(sum9);


//task10
Console.WriteLine("task10");
int sum10 = 0;
for(int i = 0; i< array2.GetLength(0); i++)
{
    for( int j=0; j< array2.GetLength(1); j++)
    {
        if (i + j == 3)
        {
            sum10 += array2[i, j];
        }
    }
}
Console.WriteLine(sum10);


//task11
Console.WriteLine("task11");
int[,] array5 =
{
    {1, 2, 3, 4, 5 },
    {1, 2, 3,4,5 },
    {1,2,3,4,5},
    {1,2,3,4,5 },
    {1,2,3,4,5 }
};
for (int i = 0;i < array5.GetLength(0); i++)
{
    for(int j=0; j< array5.GetLength(1); j++)
    {
        if (i > j)
        {
            array5 [i,j]= 0;
        }
    }
}
for (int i = 0; i < array5.GetLength(0); i++)
{
    for (int j = 0; j < array5.GetLength(1); j++)
    {
        Console.Write(array5[i,j] + " ");
    }
    Console.WriteLine();
}


//task12
Console.WriteLine("task12");

for (int i = 0; i < array5.GetLength(0); i++)
{
    for (int j = 0; j < array5.GetLength(1); j++)
    {
        if (i < j)
        {
            array5[i, j] = 0;
        }
    }
}
for (int i = 0; i < array5.GetLength(0); i++)
{
    for (int j = 0; j < array5.GetLength(1); j++)
    {
        Console.Write(array5[i, j] + " ");
    }
    Console.WriteLine();
}


//task13
Console.WriteLine("task13");
int[,] array13_1 =
{
    {1, 2, 3 },
    { 4, 5, 6 },
    {7, 8 ,9 }
};
int[,] array13_2 ={
    {1, 2, 3 },
    { 4, 5, 6 },
    {7, 8 ,9 }
};
int[,] array13_final =
{
    {0,0,0 },
    {0,0,0 },
    {0,0,0 }
};

for (int i = 0; i < array13_1.GetLength(0); i++)
{
    for(int j=0; j< array13_1.GetLength(1); j++)
    {
        array13_final[i, j] = array13_1[i, j] + array13_2[i, j];    }
}

for (int i = 0; i < array13_final.GetLength(0); i++)
{
    for(int j=0; j< array13_final.GetLength(1); j++)
    {
        Console.Write(array13_final[i,j]+ " ");
    }
    Console.WriteLine();
}


//task14
Console.WriteLine("task14");
int[,] array14 =
{
    {1, 2, 3 },
    { 4, 5, 6 },
    {7, 8, 9 }
};
for(int i = 0;i < array14.GetLength(0); i++)
{
    int sum14 = 0;
    for(int j=0; j< array14.GetLength(1); j++)
    {
        sum14+= array14[i, j];
    }
    Console.WriteLine(sum14);
}

//task15
Console.WriteLine("task15");
for (int i = 0; i < array14.GetLength(1); i++)
{
    int sum15 = 0;
    for (int j = 0; j < array14.GetLength(0); j++)
    {
        sum15 += array14[j, i];
    }
    Console.WriteLine(sum15);
}

//task16
Console.WriteLine("task16");
int[,] array16=
{
    {1, 1, 5, 0, 1, 1 },
    {1, 1, 2, 0, 1, 1 },
    {1, 1, 3, 0, 1, 1 },
    {1, 1, 4, 0, 1, 1 }
};
int shift=Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array16.GetLength(0); i++)
{
    for (int j = 0; j < array16.GetLength(1); j++)
    {
        if (j + shift < array16.GetLength(1))
        {
            array16[i, j + shift] = array16[i, j];
            array16[i, j] = 0;
        }
        if (j < shift)
        {
            array16[i, j] = 0;
        }

    }
}

for(int i = 0; i< array16.GetLength(0); i++)
{
    for(int j=0; j< array16.GetLength(1); j++)
    {
        Console.Write(array16[i,j]+" ");
    }
    Console.WriteLine();
}


//task17
Console.WriteLine("task17");
int[,] array17_1 =
{
    {1, 2, 3 },
    { 4, 5, 6 },
    {7, 8 ,9 }
};
int[,] array17_2 ={
    {1, 2, 3 },
    { 4, 5, 6 },
    {7, 8 ,9 }
};
int[,] array17_final =
{
    {0,0,0 },
    {0,0,0 },
    {0,0,0 }
};

for (int i = 0; i < array17_1.GetLength(0); i++)
{
    for (int j = 0; j < array17_1.GetLength(1); j++)
    {
        array17_final[i, j] = array17_1[i, j] * array17_2[i, j];
    }
}

for (int i = 0; i < array17_final.GetLength(0); i++)
{
    for (int j = 0; j < array17_final.GetLength(1); j++)
    {
        Console.Write(array17_final[i, j] + " ");
    }
    Console.WriteLine();
}

//task18
Console.WriteLine("Task18");
int[,] array18=
{
    {1,2,3},
    { 4, 5, 6},
    { 7, 8, 9},
};
for (int i = 0;i < array18.GetLength(0); i++)
{
    for(int j = 0;j < array18.GetLength(1); j++)
    {
        int number = array18[i,j];
      int  kok_alti= Convert.ToInt32(Math.Sqrt(number));
        int lamp = 0;
        for (int y = 2; y <= kok_alti; y++)
        {
            if (number % y == 0)
            {
          
                lamp = 1;
                break;
            }

        }

        if (lamp == 0 && number!=1)
        {
            Console.WriteLine(number);
        }
    }
}











