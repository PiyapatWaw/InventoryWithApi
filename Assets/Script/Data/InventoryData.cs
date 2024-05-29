using System;
using App.Enum;
using System.Collections.Generic;
using System.Linq;
using App.Equiepment;
using Newtonsoft.Json;

namespace App.Data
{
    public class InventoryData
    {
        public List<InventoryItem> inventory = new List<InventoryItem>();

        public void AddInventory(InventoryItem Item)
        {
            inventory.Add(Item);
        }
        
        public void RemoveInventory(InventoryItem Item)
        {
            inventory.Remove(Item);
        }
    }

    public abstract class InventoryItem
    {
        public int ID;
        public EItemType ItemType;
        public string Type;

        public InventoryItem()
        {

        }

        public InventoryItem(int iD, EItemType itemType)
        {
            ID = iD;
            ItemType = itemType;
            Type = this.GetType().Name;
        }

        public abstract String GetDescription();
    }
}