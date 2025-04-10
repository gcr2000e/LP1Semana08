using System;
using System.Dynamic;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public abstract float Cost { get; }

        public void Move()
        {
            Console.WriteLine($"Unit moveu {ToRoman(movement)} casas");
        }

        private string ToRoman(int number)
        {
            if (number < 1) return string.Empty;

            return number switch
            {
                1000 => "M" + ToRoman(number - 1000),
                900 => "CM" + ToRoman(number - 900),
                500 => "D" + ToRoman(number - 500),
                400 => "CD" + ToRoman(number - 400),
                100 => "C" + ToRoman(number - 100),
                90 => "XC" + ToRoman(number - 90),
                50 => "L" + ToRoman(number - 50),
                40 => "XL" + ToRoman(number - 40),
                10 => "X" + ToRoman(number - 10),
                9 => "IX" + ToRoman(number - 9),
                5 => "V" + ToRoman(number - 5),
                4 => "IV" + ToRoman(number - 4),
                _ => "I" + ToRoman(number - 1),
            };
        }

        public override string ToString()
        {
            return base.ToString() + $"{GetType().Name}: HP={Health} COST={Cost:F2}";
        }
    }
}
