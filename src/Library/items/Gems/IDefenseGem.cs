namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear gemas de defensa.
    /// </summary>
    public interface IDefenseGem: IGem
    {
        int DefenseBuff{ get; }
    }
}