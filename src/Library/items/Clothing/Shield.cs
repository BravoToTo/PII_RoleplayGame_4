
namespace RoleplayGame.Items
{
    /// <summary>
    /// Escudo comun
    /// </summary>
    public class Shield : IDefenseItem
    {        public int DefensePower
        {
            get
            {
                return 40;
            }
        }

        public override string ToString()
        {
            return "Common Shield";
        }
    }
}