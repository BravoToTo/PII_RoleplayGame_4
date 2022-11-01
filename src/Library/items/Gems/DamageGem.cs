namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear gemas de daño.
    /// </summary>
    public interface DamageGem: IGem
    {
        int DamageBuff{ get; }
    }
}