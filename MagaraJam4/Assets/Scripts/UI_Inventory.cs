using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Transform itemSlotContainer;
    private Transform itemSlotTemplete;
    List<RectTransform> canvasList = new List<RectTransform>();
    public Item selectedItem = null;
    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplete = itemSlotContainer.Find("itemSlotTemplete");
    }
 
    public void RefreshItems(Inventory inventory)
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 120f;
        for(int i = 0; i < canvasList.Count; i++)
        {
            Destroy(canvasList[i].gameObject);
        }
        canvasList.Clear();
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplete, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, -y * itemSlotCellSize);
            itemSlotRectTransform.Find("image").GetComponent<SpriteRenderer>().sprite = item.inventoryIcon;
            InventoryItemController controller = itemSlotRectTransform.Find("image").gameObject.AddComponent<InventoryItemController>();
            controller.inventory = inventory;
            controller.SetItem(item);
            itemSlotRectTransform.Find("Count").GetComponent<TMPro.TMP_Text>().text = item.amount.ToString();
            if (inventory.inventoryType == Inventory.InventoryType.Market)
                itemSlotRectTransform.Find("Count").GetComponent<TMPro.TMP_Text>().text = "$" + item.price.ToString();

            x++;
            if (x > 4)
            {
                x = 0;
                y++;
            }
            canvasList.Add(itemSlotRectTransform);
        }
    }
}
