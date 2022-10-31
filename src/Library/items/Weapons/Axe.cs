namespace RoleplayGame.Items
{
    /// <summary>
    /// Hacha. Arma pesada de daño medio.
    /// </summary>
    public class Axe : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 21;
            }
        }

        public override string ToString()
        {
            return "Axe";
        }
    }
}
