
namespace Bossfight
{
    internal class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        private int intStamina { get; set; }       

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
            intStamina = stamina;
        }

        public void fight(GameCharacter opponent)
        {
            if (Stamina == 0)
            {
                recharge();
                return;
            }

            int damageTaken = opponent.Strength;
            Health -= damageTaken;
            Console.WriteLine($"Enemy hit for {damageTaken} damage, {Name} now has {Health} health left.");
            Stamina -= 10;

        }

        public void recharge()
        {
            Stamina = intStamina;
            Console.WriteLine("Character recharged stamina!");
        }
    }
}
