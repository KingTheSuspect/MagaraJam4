using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Inventory:MonoBehaviour
{
    public enum InventoryType
    {
        Player,
        Market,
    }
    public InventoryType inventoryType;
    public List<ItemScriptableObject> itemList;
    private List<Item> inventoryItems;
    public int marketItemCount = 3;
    private List<ItemScriptableObject> usedItems = new List<ItemScriptableObject>();
    void Awake()
    {
        inventoryItems = new List<Item>();
        CreateItems();
        SaatSistemi.MarketYenile += OnDayPassed;
        BarinakBina.MarketYenile += OnDayPassed;
    }
    public void AddItem(Item item)
    {
        Item found = inventoryItems.FirstOrDefault(el => el.itemType == item.itemType);    // Check if same type elements exist in the list
        if (found!=null)
        {
            found.amount++;
        }
        else
        {
            inventoryItems.Add(item);
        }
    }
    public List<Item> GetItemList()
    {
        return inventoryItems;
    }
    public void RemoveItem(Item item)
    {
        inventoryItems.Remove(item);
    }

    void CreateItems()
    {
        inventoryItems.Clear();
        int count = itemList.Count;
        if (inventoryType == InventoryType.Market)
            count = marketItemCount;

        for (int i = 0; i < count; i++)   // Creating Inventory Object from ItemAsset
        {
            ItemScriptableObject sc = null;
            if (inventoryType == InventoryType.Market)
                sc = itemList[Random.Range(0, itemList.Count)];
            else
                sc = itemList[i];


            int j = 0;
            while (usedItems.Contains(sc) && inventoryType == InventoryType.Market && j < 1000)
            {
                sc = itemList[Random.Range(0, itemList.Count)];
                if (!usedItems.Contains(sc))
                {
                    usedItems.Add(sc);
                    break;
                }
                j++;
            }
            Item newItem = new Item
            {
                inventoryIcon = sc.icon,
                itemType = sc.itemType,
                amount = sc.amount,
                energyAmount = sc.energyAmount,
                price = sc.price,
                mutluluk = sc.mutluluk,
            };
            if (!usedItems.Contains(sc))
                usedItems.Add(sc);

            AddItem(newItem);
        }
    }
    public void OnDayPassed(object sender,EventArgs e)
    {
        if(inventoryType == InventoryType.Market)
            CreateItems();
    } 
}

