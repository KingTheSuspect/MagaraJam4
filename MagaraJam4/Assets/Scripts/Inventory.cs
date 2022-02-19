using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory:MonoBehaviour
{
    public List<ItemScriptableObject> itemList;
    private List<Item> playerItems;
    void Awake()
    {
        playerItems = new List<Item>();
        for (int i = 0; i < itemList.Count; i++)   // Creating Inventory Object from ItemAsset
        {
            Item newItem = new Item
            {
                inventoryIcon = itemList[i].icon,
                itemType = itemList[i].itemType,
                amount = itemList[i].amount,
                energyAmount = itemList[i].energyAmount,
            };
            AddItem(newItem);
        }
    }

    public void AddItem(Item item)
    {
        Item found = playerItems.FirstOrDefault(el => el.itemType == item.itemType);    // Check if same type elements exist in the list
        if (found!=null)
        {
            found.amount++;
        }
        else
        {
            playerItems.Add(item);
        }
    }
    public List<Item> GetItemList()
    {
        return playerItems;
    }
}

