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
        Food_Pizza,
        Food_Cola,
    }

    public Sprite inventoryIcon;
    public int amount;
    public ItemType itemType;
    public int energyAmount = -1;
    public float price = 0f;
}
