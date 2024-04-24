using App.Data;
using App.Enum;
using App.Policy;
using System.Collections.Generic;

namespace App.Equiepment
{
    public class Sword : WeaponItem
    {
        protected List<Ability> abilities;
        public Sword(int iD, EItemType itemType, bool isEquiep, EItemSlot itemSlot, int baseDamage, int level) : base(iD, itemType, isEquiep, itemSlot, baseDamage, level)
        {
            abilities = new List<Ability>();
            abilities.Add(new ArmorPiecing());
        }

        public ActionPolicy Attack()
        {
            AttackPolicy policy = new AttackPolicy(GetDamage(), abilities);
            return policy;
        }
    }
}
