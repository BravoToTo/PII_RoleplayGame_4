namespace RoleplayGame.Items
{
    /// <summary>
    /// Daga. Bajo daño.
    /// </summary>
    public class Dagger : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        public override string ToString()
        {
            return "Dagger";
        }
    }
}
