using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HurdaSatis : MonoBehaviour
{
    Player player = null;
    private bool triggered;
    [HideInInspector] public Inventory inventory = null;
    public GameObject hurda;
    [SerializeField] Button leaveButton;
    [SerializeField] Button buyButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered == true)
        {
            Time.timeScale = 0f;
            hurda.SetActive(true);
            player.inventoryUI.SetActive(true);
            player.uiInventory.RefreshItems(player.GetInventory());
        }
    }

    public void Satis(Player _player)
    {
        Item selectedItem = _player.GetInventory().GetItemList().FirstOrDefault(item => item.itemType == Item.ItemType.Trash);
        if (selectedItem?.amount>0)
        {
            Player.money += selectedItem.amount * selectedItem.price;
            selectedItem.amount -= selectedItem.amount;

            _player.GetInventory().RemoveItem(selectedItem);
            _player.uiInventory.RefreshItems(_player.GetInventory());
        }
    }
    public void Ayril(Player _player)
    {
        Time.timeScale = 1f;
        hurda.SetActive(false);
        _player.inventoryUI.SetActive(false);
        _player.uiInventory.RefreshItems(_player.GetInventory());

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject.GetComponent<Player>();
        triggered = true;
        buyButton.onClick.RemoveAllListeners();
        buyButton.onClick.AddListener(() =>
        {
            Satis(player);
        });
        leaveButton.onClick.RemoveAllListeners();
        leaveButton.onClick.AddListener(()=> 
        {
            Ayril(player);
        });

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
