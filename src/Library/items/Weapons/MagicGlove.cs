using System.Collections.Generic;
 
namespace RoleplayGame.Items
{

  /// <summary>
    /// Guante magico. Su poder se lo da las gemas que estan contenidas en el mismo.
    /// </summary>
public class MagicGlove: IDefenseItem, IAttackItem
{
    private List<Gem> gemsList= new List<Gem>();

    public int AttackPower
        {   
            get
            {   
                int attack=0; 
                foreach (Gem gem in this.gemsList)
                {
                    attack+= gem.DamageBuff;
                } 
                return attack;   
            }
        }

    public int DefensePower
        {   
            
            get
            {
                int defense=0;

                foreach (Gem gem in this.gemsList)
                {
                    defense+= gem.DefenseBuff;
                } 
                return defense;   
            }
        }
    public void addGem(Gem gem)
    {
        this.gemsList.Add(gem);
    }
    public void removeGem(Gem gem)
    {
        this.gemsList.Remove(gem);
    }
    public override string ToString()
        {
            return "Magic glove";
        }
}
}