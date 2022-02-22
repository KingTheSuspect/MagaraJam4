using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItemController : MonoBehaviour,IPointerDownHandler
{
    [SerializeField] ItemScriptableObject itemInstance;
    Item item;
    YemekSistemi yemekSistemi;
    public static Item selectedItem;
    [HideInInspector] public Inventory inventory = null;
    MutlulukSistemi mutlulukSistemi;
    Player player=null;
    void Start()
    {
        yemekSistemi = FindObjectOfType<YemekSistemi>(true);
        mutlulukSistemi = FindObjectOfType<MutlulukSistemi>(true);
        if(itemInstance != null)
        {
            item = new Item
            {
                inventoryIcon = itemInstance.icon,
                itemType = itemInstance.itemType,
                amount = itemInstance.amount,
                energyAmount = itemInstance.energyAmount,
                price = itemInstance.price,
                mutluluk = itemInstance.mutluluk,
            };
        }

    }
    void Update()
    {
        if (player == null)
        {
            player = FindObjectOfType<Player>();
            if (item.itemType == Item.ItemType.Trash)
            {
                inventory = player.GetInventory();
            }
        }
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
            if (MutlulukSistemi.mutluluk > 100)
                MutlulukSistemi.mutluluk = 100;
 

            GetComponentInParent<UI_Inventory>().RefreshItems(inventory);
            mutlulukSistemi.SetMutlulukSayar();
            yemekSistemi.SetYemekSayar();
            if (item.amount == 0)
                inventory.RemoveItem(item);
            GetComponentInParent<UI_Inventory>().RefreshItems(inventory);
        }

        if (inventory.inventoryType == Inventory.InventoryType.Market)
        {
            GetComponentInParent<UI_Inventory>().selectedItem = item;
        }
        if(item.itemType == Item.ItemType.Trash && Vector2.Distance(transform.position,player.transform.position)<player.itemGetDistance)  // Calculate Distance
        {
            player.GetInventory().AddItem(item);
            player.uiInventory.RefreshItems(player.GetInventory());
            Destroy(gameObject);
        }
    }

    public void SetItem(Item item)
    {
        this.item = item;
    }
}
