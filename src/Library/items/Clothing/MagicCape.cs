
namespace RoleplayGame.Items
{
    /// <summary>
    /// Capa mágica. Permite defenderse mas que una capa normal porque magia.
    /// </summary>
    public class MagicCape : IDefenseItem
    {        public int DefensePower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "MagicCape";
        }
    }
}