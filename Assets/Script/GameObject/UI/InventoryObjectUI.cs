using System;
using App.Data;
using UnityEngine;
using UnityEngine.UI;

namespace App.UI
{
    public class InventoryObjectUI : MonoBehaviour
    {
        [SerializeField] private Image icon;
        private Action<InventoryItem> onclick;
        private InventoryItem item;
        public void Initialize(InventoryItem item,Action<InventoryItem> onclick = null)
        {
            this.item = item;
            icon.sprite = ServiceContainer.Singleton.ImageDataBase.GetSprite(item.Type);
            this.onclick = onclick;
        }

        public void ShowInformation()
        {
            onclick?.Invoke(item);
        }
    }
}


