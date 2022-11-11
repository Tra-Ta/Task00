Console.WriteLine("Enter an integer --> ");

int num = Convert.ToInt32(Console.ReadLine());

int start = -num;
if(num < 0) start = num;

int stop = -start;

while(start < stop +1)
{
    Console.Write(start + " ");
    start += 1;
}