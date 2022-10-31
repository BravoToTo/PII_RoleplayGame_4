namespace RoleplayGame.Items
{
    /// <summary>
    /// Scimitar. Daño medio.
    /// </summary>
    public class Scimitar : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 18;
            }
        }

        public override string ToString()
        {
            return "Scimitar";
        }
    }
}
