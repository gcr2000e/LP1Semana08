using System;
using System.Runtime.CompilerServices;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Unit military = new MilitaryUnit(mov: 9, health: 10, attackPower: 4);
            Unit settler = new SettlerUnit();

            Console.WriteLine("--- Military Unit ---");
            military.Move();
            Console.WriteLine($"Health: {military.Health}");
            Console.WriteLine($"Cost: {military.Cost}");

            Console.WriteLine("\n--- Settler Unit ---");
            settler.Move();
            Console.WriteLine($"Health: {settler.Health}");
            Console.WriteLine($"Cost: {settler.Cost}");
        }
    }
}
