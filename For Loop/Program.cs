decimal singleTotal = 0;
decimal doubleTotal = 0;

for (int i = 0; i <= 1000; i++)
{
    if (i % 2 == 0)
    {
        doubleTotal += i;
    }
    else
    {
        singleTotal += i;
    }
}

Console.WriteLine("Double Number Total: " + doubleTotal);
Console.WriteLine("Single Number Total: " + singleTotal);

Console.WriteLine("--------------Multiplication----------");


int n = Convert.ToInt32(Console.ReadLine().Trim());
for (int i = 1; i <= 10; i++)
{
    int result = n * i;
    Console.WriteLine(n + " x " + i + " = " + result);
}
int t=6;

for (int i = 1; i <= t; i++)
        {x
            // boşluklar için
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // #'ler için
            for (int k = 1; k <= i; k++)
            {
                Console.Write("#");
            }

            // bir sonraki satıra geçiş
            Console.WriteLine();
        }
