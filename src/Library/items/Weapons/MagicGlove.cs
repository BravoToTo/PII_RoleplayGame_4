using System.Collections.Generic;

namespace RoleplayGame.Items
{

  /// <summary>
    /// Guante magico. Su poder se lo da las gemas que estan contenidas en el mismo.
    /// </summary>
/*public class MagicGlove: IDefenseItem, IAttackItem
{
    private List<Igem> gemsList= new List<Igem>();

    public int AttackPower
        {   
            int attack=0;
            
            get
            {
                foreach (Igem gem in this.gemsList)
                {
                    attack+= gem.AttackPower;
                } 
                return attack;   
            }
        }

    public int DefensePower
        {   
            int defense=0;
            
            get
            {
                foreach (Igem gem in this.gemsList)
                {
                    defense+= gem.DefensePower;
                } 
                return defense;   
            }
        }
    public void addGem(Igem gem)
    {
        this.gemsList.Add(gem);
    }
    public void removeGem(Igem gem)
    {
        this.gemsList.Remove(gem);
    }
    public override string ToString()
        {
            return "Magic glove";
        }
}*/
}