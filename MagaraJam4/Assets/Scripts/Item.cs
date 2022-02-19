using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ItemScriptableObject;

public class Item 
{
    public enum ItemType
    {
        Sword,
        Coin,
        Medkit,
    }

    public Sprite inventoryIcon;
    public int amount;
    public ItemType itemType; 
}
