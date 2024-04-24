using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public abstract class Ability
    {
        public abstract List<AbilityResult> Active();
    }
}
