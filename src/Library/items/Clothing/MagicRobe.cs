
namespace RoleplayGame.Items
{
    /// <summary>
    /// Capa mágica. Permite defenderse mas que una capa normal porque magia.
    /// </summary>
    public class MagicRobe : IDefenseItem
    {        
        Magic magic = new Magic();
        Robes robe = new Robes();
        public int DefensePower
        {
            get
            {
                return magic.DefensePower + robe.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Magic Robe";
        }
    }
}