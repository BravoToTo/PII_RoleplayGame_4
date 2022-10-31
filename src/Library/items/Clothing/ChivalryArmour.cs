using System.Collections;

namespace RoleplayGame.Items
{
    public class ChivalryArmour : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 50;
            }
            
        }
        public override string ToString()
        {
            return "Chivalry Armour";
        }
    }
}