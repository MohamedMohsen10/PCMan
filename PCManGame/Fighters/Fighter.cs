using System;
using System.Collections.Generic;
using System.Text;

namespace PCManGame
{
    public abstract class Fighter
    {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Weapon { get; set; } = 40;
        public FighterState FighterState { get; set; } = FighterState.Alive;
        public bool Fight(Fighter fighter)
        {
            if (fighter.Weapon >= this.Health)
            {
                fighter.Health -= this.Weapon;
                this.Health = 0;
                this.FighterState = FighterState.Dead;
                return false;
            }
            else if (fighter.Health <= this.Weapon)
            {
                this.Health -= fighter.Weapon;
                fighter.Health = 0;
                fighter.FighterState = FighterState.Dead;
                return true;
            }
            else
            {
                this.Health -= fighter.Weapon;
                fighter.Health -= this.Weapon;
                if (fighter.Health <=0)
                    fighter.FighterState = FighterState.Dead;

                return false;
            }
        }

    }
}
