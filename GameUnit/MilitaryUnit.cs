namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health
        {
            get => base.Health + XP;
            set => base.Health = value - XP;
        }

        public override float Cost => AttackPower + XP;

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }
    }

    public class SettlerUnit : Unit
    {
        public SettlerUnit() : base(1, 3)
        {
        }

        public override float Cost => 5;
    }
}
