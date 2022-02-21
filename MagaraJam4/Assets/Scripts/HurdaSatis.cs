using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdaSatis : MonoBehaviour
{
    Item item;
    Player player = null;
    private bool triggered;
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
    }

    public void Sat()
    {
        if (item.itemType == Item.ItemType.Trash)
        {
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
    private void OnTriggerExit2D(Collider other)
    {
        triggered = false;
    }
}
