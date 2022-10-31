
namespace RoleplayGame.Items
{
    /// <summary>
    /// Armadura de escamas de dragon. Alta proteccion
    /// </summary>
    public class DragonScaleArmor : IDefenseItem
    {        public int DefensePower
        {
            get
            {
                return 50;
            }
        }

        public override string ToString()
        {
            return "Dragon Scale Armor";
        }
    }
}