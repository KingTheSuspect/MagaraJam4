using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdaSatis : MonoBehaviour
{
    Item item;
    Player player = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sat()
    {
        if (item.itemType == Item.ItemType.Trash)
        {
            player.GetInventory().RemoveItem(Item.ItemType.Trash);
            player.uiInventory.RefreshItems(player.GetInventory());
        }
    }
}
