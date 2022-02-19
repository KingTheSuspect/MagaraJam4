using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItemController : MonoBehaviour,IPointerDownHandler
{
    Item item;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (item.amount > 0 && YemekSistemi.yemek<100 && Enum.GetName(typeof(Item.ItemType),item.itemType).Contains("Food"))
        {
            item.amount -= 1;
            YemekSistemi.yemek += item.energyAmount;
            if (YemekSistemi.yemek > 100)
                YemekSistemi.yemek = 100;

            GetComponentInParent<UI_Inventory>().RefreshInventoryItems();
        }

    }

    public void SetItem(Item item)
    {
        this.item = item;
    }
}
