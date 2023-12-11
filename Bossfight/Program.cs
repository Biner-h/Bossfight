using Bossfight;
using System.IO.Pipes;

static void main()
{
    GameCharacter hero = new GameCharacter("Biner", 100, 40, 10); 
    GameCharacter boss = new GameCharacter("Beetle Juice", 400, new Random().Next(1,31), 10); 

    while (hero.Health > 0 && boss.Health > 0)
    {
        hero.fight(boss);
        if (boss.Health <= 0)
        {
            Console.WriteLine("Biner is the winner");
            break;
        }

        boss.fight(hero);
        if (hero.Health <= 0)
        {
            Console.WriteLine("Beetle Juice is the winner");
            break;
        }
    }
}
main();
