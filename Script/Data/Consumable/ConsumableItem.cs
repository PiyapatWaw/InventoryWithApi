using App.Enum;
using App.Policy;

namespace App.Data
{

    public abstract class ConsumableItem : InventoryItem
    {
        protected int count;
        public ConsumableItem(int iD, EItemType itemType, int count) : base(iD, itemType)
        {
            this.count = count;
        }

        public abstract ActionPolicy Active();
    }
}