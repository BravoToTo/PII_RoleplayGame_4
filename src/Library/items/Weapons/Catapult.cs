using System.Collections;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Catapulta, herramienta medieval de guerra
    /// </summary>
 
    public class Catapult: IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 40;
            }
            
        }
        public override string ToString()
        {
            return "to fly, catapulted";
        }
    }
}
