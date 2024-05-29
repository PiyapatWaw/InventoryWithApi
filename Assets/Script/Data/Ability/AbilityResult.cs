using App.Enum;
using System.Collections.Generic;

namespace App.Data
{
    public struct AbilityResult
    {
        public readonly EAbilityResult result;
        public readonly Dictionary<string, int> parameter;

        public AbilityResult(EAbilityResult result, Dictionary<string, int> parameter)
        {
            this.result = result;
            this.parameter = parameter;
        }
    }
}
