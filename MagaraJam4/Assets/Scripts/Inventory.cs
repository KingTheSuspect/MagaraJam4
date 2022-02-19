using System.Collections;
using System.Collections.Generic;
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
            };
            playerItems.Add(newItem);
        }
    }

    public void AddItem(Item item)
    {
        playerItems.Add(item);
    }
    public List<Item> GetItemList()
    {
        return playerItems;
    }
}

