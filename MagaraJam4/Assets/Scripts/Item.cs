using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{


    public enum ItemType
    {
        Sword,
        Coin,
        Medkit,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:
            case ItemType.Coin: return ItemAssets.Instance.kola1;
            case ItemType.Sword: return ItemAssets.Instance.kola2;
        }
    }

}
