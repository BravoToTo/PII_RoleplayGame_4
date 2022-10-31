using System.Collections;

namespace RoleplayGame.Items
{
    public class MagicFoxBlade : IAttackItem
    {
        private Magic attack = new Magic();
        private FoxBlade FoxBlade = new FoxBlade();

        public int AttackPower
        {
            get 
            {
                return attack.AttackPower + FoxBlade.AttackPower;
            } 
            
        }

        public override string ToString()
        {
            return "Magic Fox Blade";
        }
    }
}