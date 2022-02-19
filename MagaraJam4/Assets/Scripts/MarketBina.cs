using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketBina : MonoBehaviour
{
    private bool triggered;
    public GameObject hata;
    public Inventory inventory;
    public GameObject Market;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && triggered == true)
        {
            Time.timeScale = 0f;
            Market.SetActive(true);
        }
    }
    public void Satinal()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.Coin, amount = 1 });
    }
    public void Ayril()
    {
        Time.timeScale = 1f;
        Market.SetActive(false);
        hata.SetActive(false);


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
