namespace RoleplayGame.Items
{
    /// <summary>
    /// Katana. Alto filo, alto daño.
    /// </summary>
    public class Katana : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 34;
            }
        }

        public override string ToString()
        {
            return "Katana";
        }
    }
}
