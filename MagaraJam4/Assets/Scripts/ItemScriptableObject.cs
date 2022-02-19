using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Item;

[CreateAssetMenu(fileName = "InventoryItem", menuName = "InventoryItem/newItem")]
public class ItemScriptableObject:ScriptableObject
{
    public ItemType itemType;
    public int amount;
    public Sprite icon;

}
