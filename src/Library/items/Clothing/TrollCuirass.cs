
namespace RoleplayGame.Items
{
    /// <summary>
    /// Coraza de troll.
    /// </summary>
    public class TrollCuirass : IDefenseItem
    {        public int DefensePower
        {
            get
            {
                return 25;
            }
        }

        public override string ToString()
        {
            return "Troll Cuirass";
        }
    }
}