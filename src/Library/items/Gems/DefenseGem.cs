namespace RoleplayGame.Items
{
    /// <summary>
    /// Interfaz que permite crear gemas de defensa.
    /// </summary>
    public interface DefenseGem: IGem
    {
        int DefenseBuff{ get; }
    }
}