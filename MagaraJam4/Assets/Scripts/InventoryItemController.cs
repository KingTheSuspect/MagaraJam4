using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItemController : MonoBehaviour,IPointerDownHandler
{
    Item item;
    YemekSistemi yemekSistemi;
    public static Item selectedItem;
    public Inventory inventory = null;
    MutlulukSistemi mutluluksistemi;
    void Start()
    {
        yemekSistemi = FindObjectOfType<YemekSistemi>(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (item.amount > 0 && YemekSistemi.yemek<100 && Enum.GetName(typeof(Item.ItemType),item.itemType).Contains("Food") && inventory.inventoryType == Inventory.InventoryType.Player)
        {
            item.amount -= 1;
            YemekSistemi.yemek += item.energyAmount;
            MutlulukSistemi.mutluluk += item.mutluluk;
            if (YemekSistemi.yemek > 100)
                YemekSistemi.yemek = 100;

            GetComponentInParent<UI_Inventory>().RefreshItems(inventory);
            mutluluksistemi.SetMutlulukSayar();
            yemekSistemi.SetYemekSayar();
        }

        if (inventory.inventoryType == Inventory.InventoryType.Market)
        {
            GetComponentInParent<UI_Inventory>().selectedItem = item;
        }
    }

    public void SetItem(Item item)
    {
        this.item = item;
    }
}
