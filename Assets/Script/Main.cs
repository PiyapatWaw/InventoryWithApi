using System.Collections.Generic;
using App.Data;
using App.Equiepment;
using App.UI;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace App
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private InventoryObjectUI prefab;
        [SerializeField] private Transform uiHolder;
        [SerializeField] private InformationPanel informationPanel;
        private List<InventoryObjectUI> allObject = new List<InventoryObjectUI>();

        public async void Load()
        {
            foreach (var ui in allObject)
            {
                Destroy(ui);
            }
            await new WaitUntil(()=>ServiceContainer.Singleton.Ready).ToUniTask();
            var inventory = await ServiceContainer.Singleton.APIService.GetInventoryAsync();
            if(inventory.inventory != null)
            {
                foreach (var item in inventory.inventory)
                {
                    var ui = Instantiate(prefab, uiHolder);
                    ui.Initialize(item,informationPanel.Show);
                    allObject.Add(ui);
                }
            }
        }
    }
}
