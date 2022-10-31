
namespace RoleplayGame.Items
{
    /// <summary>
    /// Capa mágica. Permite defenderse mas que una capa normal porque magia.
    /// </summary>
    public class MagicRobe : IDefenseItem
    {        
        private Magic magic = new Magic();
        private Robes robe = new Robes();
        public int DefensePower
        {
            get
            {
                return this.magic.DefensePower + this.robe.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Magic Robe";
        }
    }
}