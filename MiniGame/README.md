```mermaid
classDiagram
    class Program {
        +Main()
    }

    class Character {
        -Weapon[] weapons
        +string Name
        +Fight()
    }

    class Player {
        +Player(string name)
    }

    class Enemy {
        +Enemy(string name)
    }

    class Weapon {
        -float power
        +Weapon(float power)
    }

    class Gun {
        -int Ammo
        +Gun(float power, int ammo)
        +FireGun()
    }

    class Sword {
        -float BladeLength
        +Sword(float power, float bladeLength)
        +AttackWithSword()
    }

    Character <|-- Player
    Character <|-- Enemy
    Weapon <|-- Gun
    Weapon <|-- Sword
    Character --> Weapon : has weapons[]
    Program --> Character : uses
