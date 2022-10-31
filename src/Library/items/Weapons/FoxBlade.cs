using System.Collections;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada con diseño de zorro. Perfecta para ataques rápidos.
    /// </summary>
    public class FoxBlade : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 50;    
            }
        }

        public override string ToString()
        {
            return "Fox Blade";
        }
    }

    
   
}