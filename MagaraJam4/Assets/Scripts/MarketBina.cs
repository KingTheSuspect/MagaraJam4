using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketBina : MonoBehaviour
{
    private bool triggered;
    public GameObject hata;
    public GameObject MarketUI;
    Inventory marketInventory;
    Player player = null;
    UI_Inventory marketInventoryUI = null;
    MarketUIController marketUI;
    bool openBefore = false;
    private void Awake()
    {
        marketInventory = transform.GetComponent<Inventory>();
        marketInventoryUI = MarketUI.transform.GetComponentInChildren<UI_Inventory>(true);
        marketUI = MarketUI.transform.GetComponentInChildren<MarketUIController>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered == true)
        {
            Time.timeScale = 0f;
            MarketUI.SetActive(true);
            marketInventoryUI.RefreshItems(marketInventory);
        }
    }
    public void Satinal()
    {
        if (marketInventoryUI.selectedItem != null)
        {

            openBefore = false;
            if (Player.money >= marketInventoryUI.selectedItem.price)
            {
                player.GetInventory().AddItem(marketInventoryUI.selectedItem);
            marketInventory.RemoveItem(marketInventoryUI.selectedItem);
            marketInventoryUI.RefreshItems(marketInventory);
            if (player.uiInventory.gameObject.activeInHierarchy)
                openBefore = true;

            if (!openBefore)
                player.uiInventory.gameObject.SetActive(true);
           
                
                player.uiInventory.RefreshItems(player.GetInventory());
                Player.money -= marketInventoryUI.selectedItem.price;
                marketInventoryUI.selectedItem = null;
            }
            else
            {
                hata.SetActive(true);
            }
        }
        //if(!openBefore)
        //player.uiInventory.gameObject.SetActive(false);

    }

    public void Ayril()
    {
        Time.timeScale = 1f;
        MarketUI.SetActive(false);
        if(hata!=null)
            hata.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggered = true;
        if (player == null)
            player = collision.gameObject.GetComponent<Player>();
        marketUI.buyButton.onClick.RemoveAllListeners();
        marketUI.buyButton.onClick.AddListener(() =>
        {
            Satinal();
        });
        marketUI.leaveButton.onClick.RemoveAllListeners();
        marketUI.leaveButton.onClick.AddListener(() =>
        {
            Ayril();
        });
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        triggered = true;
        if (player == null)
            player = collision.gameObject.GetComponent<Player>();

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggered = false;
    }
}
