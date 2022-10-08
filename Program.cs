char REPITE = '0';
while (REPITE <= '0')
{
    Console.WriteLine("Выберите программу для запуска");
    Console.WriteLine("1. Угадай число ");
    Console.WriteLine("2. Таблица умножения ");
    Console.WriteLine("3. Вывод делителей числа ");
    Console.WriteLine("4. Выход ");

    double z = Convert.ToDouble(Console.ReadLine());

    if (z == 1)
    {
        Random g = new Random();

        int quest = g.Next(0, 100);
        while (true)
        {
           
            Console.WriteLine("Угадай число от 1 до 100!");
            Console.Write("Ответ: ");
            double otvet = Convert.ToDouble(Console.ReadLine());
            if (otvet == quest)
            {
                Console.Clear();
                Console.WriteLine("Правильно!");
                
                break;
            }
            if (otvet > quest)
            {
                Console.Clear();
                Console.WriteLine("Попробуй число поменьше!");
                
            }
            if (otvet < quest)
            {
                Console.Clear();
                Console.WriteLine("Попробуй число побольше!");
               

            }
        }

    }

    if (z == 2)
    {
        Console.Clear();
        Console.WriteLine("Таблица умножения: ");
        {
            int[,] c = new int[10, 10]
            {
                        {1,2,3,4,5,6,7,8,9,10},
                        {2,4,6,8,10,12,14,16,18,20},
                        {3,6,9,12,15,18,21,24,27,30 },
                        {4,8,12,16,20,24,28,32,36,40},
                        {5,10,15,20,25,30,35,40,45,50},
                        {6,12,18,24,30,36,42,48,54,60},
                        {7,14,21,28,35,42,49,56,63,70},
                        {8,16,24,32,40,48,56,64,72,80},
                        {9,18,27,36,45,54,64,72,81,90},
                        {10,20,30,40,50,60,70,80,90,100}
            };
            Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            Console.WriteLine();
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + "  ");
                for (int j = 1; j < 11; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }


    if (z == 3)
    {

        Console.Write("Введите число ");
        int num = int.Parse(Console.ReadLine());

        int i = 1;
        while (i <= num)
        {
            i++;
            if (num % i == 0)
                Console.WriteLine("Число {0} делится без остатка на {1}", num, i);
        }

    }
    if (z == 4)
    {
        break;
    }
    Console.WriteLine("Что бы выйти в меню напишите 0.");
    REPITE = Convert.ToChar(Console.ReadLine());
}