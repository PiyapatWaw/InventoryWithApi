using App.Enum;
using Newtonsoft.Json;

namespace App.Data
{
    public abstract class EquiepmentItem : InventoryItem
    {
        [JsonProperty] private bool isEquiep;
        [JsonProperty] protected readonly EItemSlot itemSlot;

        protected EquiepmentItem(int iD, EItemType itemType, bool isEquiep, EItemSlot itemSlot) : base(iD, itemType)
        {
            this.isEquiep = isEquiep;
            this.itemSlot = itemSlot;
        }

        public bool IsEquiep { get => isEquiep; private set => isEquiep = value; }

        public void Equiep()
        {
            isEquiep = true;
        }

        public void DeEquiep()
        {
            isEquiep = true;
        }
    }

    public class WeaponItem : EquiepmentItem
    {
        [JsonProperty] protected int baseDamage;
        [JsonProperty] protected int level;

        protected WeaponItem(int iD, EItemType itemType, bool isEquiep, EItemSlot itemSlot, int baseDamage,int level) : base(iD, itemType, isEquiep, itemSlot)
        {
            this.baseDamage = baseDamage;
            this.level = level;
        }

        public int GetDamage()
        {
            return baseDamage * level;
        }
    }
    
}
