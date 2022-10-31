namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada. Permite destruir todo lo que toca.
    /// </summary>
    public class Narsil : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 100;
            }
        }

        public override string ToString()
        {
            return "Narsil";
        }
    }
}
