using System.Collections;

namespace RoleplayGame.Items
{
    public class Crossbow : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 35;
            }
        }
        public override string ToString()
        {
            return "Crossbow";
        }
    }
}