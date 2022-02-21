using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdaSatis : MonoBehaviour
{
    Item item;
    Player player = null;
    private bool triggered;
    [HideInInspector] public Inventory inventory = null;
    public GameObject hurda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered == true)
        {
            Time.timeScale = 0f;
            hurda.SetActive(true);
        }
        if (player == null)
        {
            player = FindObjectOfType<Player>();
            if (item.itemType == Item.ItemType.Trash)
            {
                inventory = player.GetInventory();
            }
        }
    }

    public void Satis()
    {
        if (item.amount > 0 && Enum.GetName(typeof(Item.ItemType), item.itemType).Contains("Trash") && inventory.inventoryType == Inventory.InventoryType.Player)
        {
            item.amount -= item.amount;
            player.GetInventory().RemoveItem(item);
            player.uiInventory.RefreshItems(player.GetInventory());
        }
    }
    public void Ayril()
    {
        Time.timeScale = 1f;
        hurda.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        triggered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
}
