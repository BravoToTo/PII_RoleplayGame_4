namespace RoleplayGame.Items
{
    public class Gem: IAttackGem,IDefenseGem
    {
        public int DamageBuff
        {
            get
            {
                return 15;
            }
        }
        public int DefenseBuff
        {
            get
            {
                return 15;
            }
        }
    }

}