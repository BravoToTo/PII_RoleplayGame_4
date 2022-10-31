namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        Axe = 3,
        Crossbow = 4,
        Dagger = 5,
        FoxBlade = 6,
        Katana = 7,
        MagicFoxBlade = 8,
        //MagicGlove = 9,
        Narsil = 10,
        Scimitar = 11,
        Schyte = 12,
        Stick = 13,
        BoneArmour = 14,
        ChivalryArmour = 15,
        DragonScaleArmor = 16,
        MagicRobe = 17,
        Shield = 18,
        TrollCuirass = 19

    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Axe: return new Axe();
                case ItemType.Crossbow: return new Crossbow();
                case ItemType.Dagger: return new Dagger();
                case ItemType.FoxBlade: return new FoxBlade();
                case ItemType.Katana: return new Katana();
                case ItemType.MagicFoxBlade: return new MagicFoxBlade();
                //case ItemType.MagicGlove: return new MagicGlove();
                case ItemType.Narsil: return new Narsil();
                case ItemType.Scimitar: return new Scimitar();
                case ItemType.Stick: return new Stick();
                case ItemType.BoneArmour: return new BoneArmor();
                case ItemType.ChivalryArmour: return new ChivalryArmour();
                case ItemType.DragonScaleArmor: return new DragonScaleArmor();
                case ItemType.MagicRobe: return new MagicRobe();
                case ItemType.Shield: return new Shield();
                case ItemType.TrollCuirass: return new TrollCuirass();

                default: return null;
            }
        }
    }
}