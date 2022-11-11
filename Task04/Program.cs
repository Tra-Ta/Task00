Console.WriteLine("Введите трехзначное число -->");

int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num < 1000) Console.WriteLine(num % 10);
else Console.WriteLine("Вне диапозона");
