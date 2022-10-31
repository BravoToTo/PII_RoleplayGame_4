
namespace RoleplayGame.Items
{
    /// <summary>
    /// Armadura de hueso. Baja proteccion
    /// </summary>
    public class BoneArmor : IDefenseItem
    {        public int DefensePower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Bone Armor";
        }
    }
}