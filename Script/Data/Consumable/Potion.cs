using App.Enum;
using App.Policy;

namespace App.Data
{
    public class Potion : ConsumableItem
    {
        protected const int value = 10;

        public Potion(int iD, EItemType itemType, int count) : base(iD, itemType, count)
        {
        }

        public override ActionPolicy Active()
        {
            return new HealPolicy(value);
        }
    }
}
