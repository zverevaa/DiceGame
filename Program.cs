int EnemyCount = 0;
int PlayerCount = 0;

for (int i = 0; i < 3; i++)
{
    Random rnd = new Random();
    int Enemy = rnd.Next(1, 6);
    Console.Write("Пожалуйста, введите число между 1 и 6:");
    int Player = int.Parse(Console.ReadLine());

    if (Player > 6)
    {
        Console.Clear();
        Console.WriteLine("Ваше число больше 6, попоробуйте еще раз.");
    }
    else if (Player < 1)
    {
        Console.Clear();
        Console.WriteLine("Ваше число меньше 1, попоробуйте еще раз.");
    }
    else
    {

        if (Enemy > Player)
        {
            Console.WriteLine("Ваше число: " + Player);
            Console.WriteLine("Число AI: " + Enemy);
            Console.WriteLine("Выиграл компьютер!");
            EnemyCount += 1;
            Console.WriteLine("Текущий счёт: " + EnemyCount + " " + PlayerCount);
        }
        else if (Player > Enemy)
        {
            Console.WriteLine("Ваше число: " + Player);
            Console.WriteLine("Число AI: " + Enemy);
            Console.WriteLine("Вы выиграли!");
            PlayerCount += 1;
            Console.WriteLine("Текущий счёт: " + EnemyCount + " " + PlayerCount);
        }
        else
        {
            Console.WriteLine("Ничья!");
            i = i - 1;
        }

        
    }    
}

if (EnemyCount > PlayerCount)
{
    Console.WriteLine("Побеждает компьтер со счетом: " + EnemyCount + " : " + PlayerCount);
}
else
{
    Console.WriteLine("Поздравляю, Вы победили со счетом: " + EnemyCount + " : " + PlayerCount);
}
