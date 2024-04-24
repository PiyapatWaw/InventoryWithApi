using App.Equiepment;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace App
{
    public class Main : MonoBehaviour
    {
        async void Start()
        {
            await new WaitUntil(()=>ServiceContainer.Singleton.Ready).ToUniTask();
            var inventory = await ServiceContainer.Singleton.APIService.GetInventoryAsync();
            if(inventory.inventory[0] is Sword valid)
            {
                Debug.LogFormat("{0} damage {1}",valid.Type,valid.GetDamage());
            }
        }
    }
}
