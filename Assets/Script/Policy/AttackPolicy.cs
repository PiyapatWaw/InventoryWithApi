using App.Data;
using App.Object;
using App.Utility;
using System.Collections.Generic;

namespace App.Policy
{
    public class AttackPolicy : ActionPolicy
    {
        public readonly int Damage;
        public readonly List<Ability> AdditionAbility;

        public AttackPolicy(int damage, List<Ability> additionAbility)
        {
            Damage = damage;
            AdditionAbility = additionAbility;
        }

        public override void Solve(Character character)
        {
            int finalDamage = Damage;
            foreach (var ability in AdditionAbility)
            {
                foreach (var result in ability.Active())
                {
                    switch (result.result)
                    {
                        case Enum.EAbilityResult.AddStatus:
                            break;
                        case Enum.EAbilityResult.ApplyDamage:
                            finalDamage += result.parameter[ParameterKey.Value];
                            break;
                        default:
                            break;
                    }
                }
            }
            character.UpdateHp(-finalDamage);
        }
    }
}


