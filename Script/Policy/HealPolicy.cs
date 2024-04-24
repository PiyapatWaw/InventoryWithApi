using App.Object;

namespace App.Policy
{

    public class HealPolicy : ActionPolicy
    {
        public readonly int value;

        public HealPolicy(int value)
        {
            this.value = value;
        }

        public override void Solve(Character character)
        {
            character.UpdateHp(value);
        }
    }
}