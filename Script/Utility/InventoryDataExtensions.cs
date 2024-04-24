using System.Collections.Generic;
using System.Linq;
using App.Data;
using App.Equiepment;
using Newtonsoft.Json;

namespace App.Utility
{
    public static class InventoryDataExtensions
    {
        public static InventoryData DeSerialize(string json)
        {
            // Deserialize JSON into a list of dictionaries
            var jsonObjectList = JsonConvert.DeserializeObject<List<Dictionary<string, List<Dictionary<string, object>>>>>(json);

            // Get the first JSON object
            var jsonObject = jsonObjectList.FirstOrDefault();

            // if payload is null or not match return default
            if (jsonObject == null || !jsonObject.TryGetValue("inventory", out var inventory))
            {
                return new InventoryData();
            }
            
            //the list of result
            var inventoryDataList = new List<InventoryItem>();
            
            // loop to create item in list
            foreach (var item in inventory)
            {
                if (item.TryGetValue("Type", out var typeValue) && typeValue is string itemType)
                {
                    switch (itemType)
                    {
                        case nameof(Sword):
                            inventoryDataList.Add(JsonConvert.DeserializeObject<Sword>(JsonConvert.SerializeObject(item)));
                            break;
                    }
                }
            }
            
            return new InventoryData { inventory = inventoryDataList };
        }
    }
}
