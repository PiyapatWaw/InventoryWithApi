using App.Enum;
using App.Utility;
using System.Collections.Generic;

namespace App.Data
{
    public class ArmorPiecing : Ability
    {
        public override List<AbilityResult> Active()
        {
            Dictionary<string, int> parameter = new Dictionary<string, int>();
            parameter.Add(ParameterKey.Value, 10);
            AbilityResult result = new AbilityResult(EAbilityResult.ApplyDamage,parameter);

            var results = new List<AbilityResult>();

            results.Add(result);

            return results;
        }
    }
}