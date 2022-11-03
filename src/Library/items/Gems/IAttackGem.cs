namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear gemas de daño.
    /// </summary>
    public interface IAttackGem: IGem
    {
        int DamageBuff{ get; }
    }
}