//task 5
int myValue = 32;
while (1>0)
{
    if (myValue %2 == 0)
    {
        myValue /= 2;
        if(myValue == 1)
        {
            Console.WriteLine("число является степенью 2");
            break;
        }
    }
    else
    {
        Console.WriteLine("число не является степенью 2");
        break;
    }
 
}