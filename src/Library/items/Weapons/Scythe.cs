namespace RoleplayGame.Items
{
    /// <summary>
    /// Guadaña. Daño medio.
    /// </summary>
    public class Scythe : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return "Scythe";
        }
    }
}
