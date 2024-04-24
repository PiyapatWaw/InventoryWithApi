using App.Policy;
using UnityEngine;

namespace App.Object
{
    public abstract class Character : MonoBehaviour
    {
        protected int hp;

        public void SolvePolicy(ActionPolicy policy)
        {
            policy.Solve(this);
        }


        public void UpdateHp(int value)
        {
            hp += value;
        }
    }
}
