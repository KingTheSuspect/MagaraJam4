using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ItemScriptableObject;

public class Item 
{
    public enum ItemType
    {
        Food_Pizza,
        Food_Cola,
        Food_Days,
        Food_Dots,
        Food_Mart,
        Food_Puddies,
        Food_Redcowl,
        Food_Rone,
        Food_Tepsi,
        Food_Cay,
        Food_Burger,
    }

    public Sprite inventoryIcon;
    public int amount;
    public ItemType itemType;
    public int energyAmount = -1;
    public float price = 0f;
    public int mutluluk;
}
