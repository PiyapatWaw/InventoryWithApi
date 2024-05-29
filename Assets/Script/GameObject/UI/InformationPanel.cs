using App.Data;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace App
{
    public class InformationPanel : MonoBehaviour
    {
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI text;

        public void Show(InventoryItem item)
        {
            icon.sprite = ServiceContainer.Singleton.ImageDataBase.GetSprite(item.Type);
            text.text = item.GetDescription();
            
            icon.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
        }

        public void Hide()
        {
            icon.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
        }
    }
}


